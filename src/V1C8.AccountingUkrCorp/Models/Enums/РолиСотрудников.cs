using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Table("RolySotrudnykov")]
    [Description1C8(Name = "РолиСотрудников", Comment = "", Synonym = "Роли сотрудников")]
    public class РолиСотрудников:EnumItem
    {
        public static readonly РолиСотрудников Работник = new РолиСотрудников{Name= "Работник",Synonym="Работник",Comment=""};
        public static readonly РолиСотрудников Договорник = new РолиСотрудников{Name= "Договорник",Synonym="Договорник",Comment=""};
    }
}
