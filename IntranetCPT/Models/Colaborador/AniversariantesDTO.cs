using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntranetCPT.Models.Colaborador
{
    public class AniversariantesDTO
    {
        public int id { get; set; }
        public string title { get; set; }
        public DateTime start { get; set; }
        public Boolean allDay { get; set; }
        public string className { get; set; }

    }
}
