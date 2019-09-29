using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace IntranetCPT.Models.Enums
{
    public enum EnumControleAcesso
    {
        [Description("Administrador")]
        Administrador = 1,
        [Description("Colaborador")]
        Colaborador = 2,
        [Description("RH")]
        RH
    }
}
