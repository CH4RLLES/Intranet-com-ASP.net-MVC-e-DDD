using IntranetCPT.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IntranetCPT.Models.Filtros
{
    public class FiltroRamais
    {
        public Guid Id { get; set; }
        public string Setor { get; set; }
        public string Telefone { get; set; }

        public List<Tb_Ramais> RamaisLista { get; set; }

        public FiltroRamais()
        {
            RamaisLista = new List<Tb_Ramais>();
        }
    }
}
