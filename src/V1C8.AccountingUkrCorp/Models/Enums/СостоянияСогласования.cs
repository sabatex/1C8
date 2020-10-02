using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СостоянияСогласования", Comment = "", Synonym = "Состояния согласования")]
    public class СостоянияСогласования:EnumItem
    {
        public static readonly СостоянияСогласования Отклонено = new СостоянияСогласования{Name= "Отклонено",Synonym="Отклонено",Comment=""};
        public static readonly СостоянияСогласования Рассматривается = new СостоянияСогласования{Name= "Рассматривается",Synonym="Рассматривается",Comment=""};
        public static readonly СостоянияСогласования Согласовано = new СостоянияСогласования{Name= "Согласовано",Synonym="Согласовано",Comment=""};
    }
}
