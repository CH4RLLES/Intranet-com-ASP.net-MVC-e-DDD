using System;
using System.ComponentModel.DataAnnotations;

namespace IntranetCPT.Dominio
{
    public class EntidadeBase
    {
        [Key]
        public Guid Id { get; set; }
    }
}
