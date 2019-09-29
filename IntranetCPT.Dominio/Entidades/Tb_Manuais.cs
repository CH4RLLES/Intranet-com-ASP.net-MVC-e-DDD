using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace IntranetCPT.Dominio.Entidades
{
    public class Tb_Manuais : EntidadeBase
    {
        [Required]
        [Display(Name = "Título")]
        public string Titulo { get; set; }
        [Required]
        public byte[] Arquivo { get; set; }
    }
}
