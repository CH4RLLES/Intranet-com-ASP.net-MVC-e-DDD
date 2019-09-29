using IntranetCPT.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntranetCPT.Models.Filtros
{
    public class FiltroConteudo
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string Introducao { get; set; }
        public string Conteudo { get; set; }

        public List<Tb_Conteudo> ConteudoLista { get; set; }

        public FiltroConteudo()
        {
            ConteudoLista = new List<Tb_Conteudo>();
        }
    }
}
