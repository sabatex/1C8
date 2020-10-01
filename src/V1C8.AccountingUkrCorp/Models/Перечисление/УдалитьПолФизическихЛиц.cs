using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "УдалитьПолФизическихЛиц", Comment = "", Synonym = "(не используется) Пол физических Лиц")]
    public enum УдалитьПолФизическихЛиц
    {
        [Description1C8(Name = "Мужской", Comment = "(Общ)", Synonym = "Мужской")]
        Мужской,
        [Description1C8(Name = "Женский", Comment = "(Общ)", Synonym = "Женский")]
        Женский
    }
}
