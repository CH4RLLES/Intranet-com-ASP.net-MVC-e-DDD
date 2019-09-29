using IntranetCPT.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntranetCPT.Models.Colaborador
{
    public class DadosPessoaisDTO
    {
        public Guid Id { get; set; }
        public string NomeMae { get; set; }
        public string NomePai { get; set; }
        public DateTime DataNascimento { get; set; }
        public EnumEstadoCivil EstadoCivil { get; set; }
    }
}
