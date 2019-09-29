using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace IntranetCPT.Dominio.Entidades
{
    public class Tb_Ramais : EntidadeBase
    {
        [Required]
        public string Setor { get; set; }
        [Required]
        public string Telefone { get; set; }
    }
}
