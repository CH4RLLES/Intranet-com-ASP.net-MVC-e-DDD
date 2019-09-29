using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace IntranetCPT.Dominio.Entidades
{
    public class Tb_Conteudo : EntidadeBase
    {
        [Required]
        [Display(Name = "Título")]
        public string Titulo { get; set; }
        [Required]
        [Display(Name = "Introdução")]
        public string Introducao { get; set; }
        [Required]
        [Display(Name = "Conteúdo")]
        public string Conteudo { get; set; }
    }
}
