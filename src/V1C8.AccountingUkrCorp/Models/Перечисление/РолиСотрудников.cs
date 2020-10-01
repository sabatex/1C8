using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "РолиСотрудников", Comment = "", Synonym = "Роли сотрудников")]
    public enum РолиСотрудников
    {
        [Description1C8(Name = "Работник", Comment = "", Synonym = "Работник")]
        Работник,
        [Description1C8(Name = "Договорник", Comment = "", Synonym = "Договорник")]
        Договорник
    }
}
