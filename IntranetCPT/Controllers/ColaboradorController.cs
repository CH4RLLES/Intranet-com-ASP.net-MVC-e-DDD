using IntranetCPT.Models;
using IntranetCPT.Models.Colaborador;
using IntranetCPT.Servicos;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace IntranetCPT.Controllers
{
    public class ColaboradorController : Controller
    {
        private readonly UsuarioLogado _usuario;

        public ColaboradorController(UsuarioLogado usuario)
        {
            _usuario = usuario;
        }

        public IActionResult Principal()
        {
            return View();
        }

        public IActionResult Noticias()
        {
            return View();
        }

        public IActionResult Manuais()
        {
            return View();
        }

        public IActionResult Treinamentos()
        {
            return View();
        }
        public IActionResult Avisos()
        {
            return View();
        }

        public IActionResult SolicitacaoTI()
        {
            return View();
        }

        public IActionResult Ramais()
        {
            return View();
        }

        public IActionResult Ouvidoria()
        {
            return View();
        }

        public async Task<IActionResult> Aniversariantes()
        {
            var caminho = "http://10.100.132.31:5000/folhadeponto.webapi/api/Login/ListarAniversariantes";
            var dados = await new WebApiServicos().GetAsync<AniversariantesDTO>(caminho, _usuario.Token);
            return View(Json(dados));
        }
    }
}