using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ТипыОтчетов", Comment = "", Synonym = "Типы отчетов")]
    public enum ТипыОтчетов
    {
        [Description1C8(Name = "Внутренний", Comment = "", Synonym = "Внутренний")]
        Внутренний,
        [Description1C8(Name = "Дополнительный", Comment = "", Synonym = "Дополнительный")]
        Дополнительный,
        [Description1C8(Name = "Расширение", Comment = "", Synonym = "Расширение")]
        Расширение,
        [Description1C8(Name = "Внешний", Comment = "", Synonym = "Внешний")]
        Внешний,
        [Description1C8(Name = "УдалитьОтчет", Comment = "", Synonym = "(не используется) Отчет")]
        УдалитьОтчет,
        [Description1C8(Name = "УдалитьПользовательский", Comment = "", Synonym = "(не используется) Пользовательский")]
        УдалитьПользовательский
    }
}
