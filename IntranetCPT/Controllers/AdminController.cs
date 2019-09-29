using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntranetCPT.Dominio.Entidades;
using IntranetCPT.Models;
using IntranetCPT.Models.Filtros;
using IntranetCPT.Servicos.Servicos;
using Microsoft.AspNetCore.Mvc;

namespace IntranetCPT.Controllers
{
    public class AdminController : Controller
    {
        private readonly UsuarioLogado _usuario;

    

        

        public AdminController(UsuarioLogado usuario)
        {
            _usuario = usuario;
        }

        public IActionResult Principal()
        {
           // if (!VerAcesso())
             //   return View("AcessoNegado");

            return View();
        }

        private bool VerAcesso()
        {
            if (_usuario.Admin)
                return true;
            else
                return false;
        }

        [HttpGet]
        public IActionResult GerenciarRamais()
        {
            // if (!VerAcesso())
            //   return View("AcessoNegado");
            var ramal = new FiltroRamais();
            ramal.RamaisLista = new RamaisServicos().ListaRamais().OrderBy(a => a.Setor).ToList();

            return View(ramal);
        }

        [HttpPost]
        public IActionResult CadRamais([FromForm] Tb_Ramais ramal)
        {
            var ret = false;
            if (ramal.Id.ToString() == "00000000-0000-0000-0000-000000000000")
                ret = new RamaisServicos().CadastrarRamais(ramal);
            else
                ret = new RamaisServicos().AlterarRamais(ramal);

            var filtroRamal = new FiltroRamais();
            filtroRamal.RamaisLista = new RamaisServicos().ListaRamais().OrderBy(a => a.Setor).ToList();
            TempData["Messagem"] = ret ? "Ramal salvo com sucesso!" : "Erro ao salvar a Página!";
            return View("GerenciarRamais", filtroRamal);
        }

        [HttpGet]
        public IActionResult BuscarCadRamais(Guid id)
        {
            var ret = new RamaisServicos().Obter(id);
            var filtroRamal = new FiltroRamais
            {
                Id = id,
                Setor = ret.Setor,
                Telefone = ret.Telefone,
                RamaisLista = new RamaisServicos().ListaRamais().OrderBy(a => a.Setor).ToList()
            };
            return View("GerenciarRamais", filtroRamal);
        }

        

        [HttpGet]
        public IActionResult GerenciarConteudo()
        {
            // if (!VerAcesso())
            //   return View("AcessoNegado");

            var conteudo = new FiltroConteudo();
            conteudo.ConteudoLista = new ConteudoServicos().ListaConteudo().OrderBy(a => a.Titulo).ToList();

            return View(conteudo);
        }

        [HttpPost]
        public IActionResult CadConteudo([FromForm] Tb_Conteudo conteudos)
        {
            var ret = false;
            if (conteudos.Id.ToString() == "00000000-0000-0000-0000-000000000000")
                ret = new ConteudoServicos().CadastrarConteudo(conteudos);
            else
                ret = new ConteudoServicos().AlterarConteudo(conteudos);

            var filtroConteudo = new FiltroConteudo();
            filtroConteudo.ConteudoLista = new ConteudoServicos().ListaConteudo().OrderBy(a => a.Titulo).ToList();
            TempData["Messagem"] = ret ? "Conteúdo salvo com sucesso!" : "Erro ao salvar Conteúdo!";
            return View("GerenciarConteudo", filtroConteudo);
        }

        [HttpGet]
        public IActionResult BuscarCadConteudo(Guid id)
        {
            var ret = new ConteudoServicos().Obter(id);
            var filtroConteudo = new FiltroConteudo
            {
                Id = id,
                Titulo = ret.Titulo,
                Introducao = ret.Introducao,
                Conteudo = ret.Conteudo,
                ConteudoLista = new ConteudoServicos().ListaConteudo().OrderBy(a => a.Titulo).ToList()
            };
            return View("GerenciarConteudo", filtroConteudo);
        }

        public IActionResult GerenciarManuais()
        {
            // if (!VerAcesso())
            //   return View("AcessoNegado");

            return View();
        }

        
    }
}