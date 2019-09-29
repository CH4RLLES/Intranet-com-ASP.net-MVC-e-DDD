using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using IntranetCPT.Models;
using IntranetCPT.Models.Colaborador;
using IntranetCPT.Models.Enums;
using IntranetCPT.Servicos;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace IntranetCPT.Controllers
{
    public class LoginController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> Login([Bind] LoginDTO usuario)
        {
            var token = await BuscaToken();
            
            var usu = await EfetuarLogin(usuario, token);
            if (usu.Status == EnumStatusAcesso.Ativo)
            {
                var colaborador = await BuscaColaborador(usu.IdColaborador.ToString(), token);

                var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.NameIdentifier, usu.IdColaborador.ToString()),
                        new Claim(ClaimTypes.Name, colaborador.Nome),
                        new Claim(ClaimTypes.Authentication, token),
                        new Claim(ClaimTypes.Actor, colaborador.AdminIntranet.ToString()),
                    };

                ClaimsIdentity userIdentity = new ClaimsIdentity(claims, "login");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

                await HttpContext.SignInAsync(principal, new AuthenticationProperties
                {
                    IsPersistent = true,
                    ExpiresUtc = DateTime.UtcNow.AddMinutes(20)
                });
                
                return RedirectToAction("Principal", "Colaborador");
            }
            else
            {
                TempData["LoginUsuarioFalhou"] = "O login Falhou. " + usu.Status.GetEnumDescription();
                return RedirectToAction("Index", "Home");
            }
        }

        private async Task<string> BuscaToken()
        {
            var caminho = "http://10.100.132.31:5000/folhadeponto.webapi/api/Token/BuscaToken?nome=Intranet&token=D4107C17A3F9CF71765DDA8BA09C8604C0F1732BF9CCBEFA08B3C20148E7779E";
            var dados = await new WebApiServicos().GetAsync<RetornaToken>(caminho, "");

            if (dados.Erro)
                return "Erro";

            return dados.Mensagem;
        }
        private async Task<LoginDTO> EfetuarLogin(LoginDTO login, string token)
        {
            var caminho = "http://10.100.132.31:5000/folhadeponto.webapi/api/Login/EfetuarLogin";
            return await new WebApiServicos().PostAsync<LoginDTO>(caminho, login, token);
        }
        private async Task<ColaboradorDTO> BuscaColaborador(string id, string token)
        {
            var caminho = "http://10.100.132.31:5000/folhadeponto.webapi/api/Login/BuscaColaborador?id=" + id;
            return await new WebApiServicos().GetAsync<ColaboradorDTO>(caminho, token);
        }
    }
}