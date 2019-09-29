using IntranetCPT.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntranetCPT.Models.Colaborador
{
    public class UnidadeDTO
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public string InscricaoEstadual { get; set; }
        public string Observacoes { get; set; }
        public string Telefone { get; set; }
        public EnderecoDTO Endereco { get; set; }
        public EnumFusoHorario FusoHorario { get; set; }
        public UfDTO Estado { get; set; }
    }
}
