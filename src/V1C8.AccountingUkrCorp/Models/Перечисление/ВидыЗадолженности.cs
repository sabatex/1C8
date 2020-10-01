using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыЗадолженности", Comment = "Виды задолженности: дебиторская, кредиторская", Synonym = "Виды задолженности")]
    public enum ВидыЗадолженности
    {
        [Description1C8(Name = "Дебиторская", Comment = "Дебиторская", Synonym = "Дебиторская")]
        Дебиторская,
        [Description1C8(Name = "Кредиторская", Comment = "Кредиторская", Synonym = "Кредиторская")]
        Кредиторская
    }
}
