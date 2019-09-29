using System;
using System.Collections.Generic;
using System.Text;

namespace IntranetCPT.Models.Colaborador
{
    public class UfDTO
    {
        public Guid Id { get; set; }
        public int Codigo { get; set; }
        public string Sigla { get; set; }
        public string Descricao { get; set; }
    }
}
