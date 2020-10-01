using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ПолФизическогоЛица", Comment = "", Synonym = "Пол физического лица")]
    public enum ПолФизическогоЛица
    {
        [Description1C8(Name = "Мужской", Comment = "", Synonym = "Мужской")]
        Мужской,
        [Description1C8(Name = "Женский", Comment = "", Synonym = "Женский")]
        Женский
    }
}
