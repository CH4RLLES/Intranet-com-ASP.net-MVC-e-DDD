using IntranetCPT.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace IntranetCPT.Models
{
    public class LoginDTO 
    {
        public Guid Id { get; set; }
        public string Cpf { get; set; }
        [DataType(DataType.Password)]
        public string Senha { get; set; }
        public EnumStatusAcesso Status { get; set; }
        public Guid IdColaborador { get; set; }
    }
}
