using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "УдалитьВидыТекстовЭлектронныхПисем", Comment = "", Synonym = "(не используется) Виды текстов электронных писем")]
    public enum УдалитьВидыТекстовЭлектронныхПисем
    {
        [Description1C8(Name = "HTML", Comment = "", Synonym = "HTML")]
        HTML,
        [Description1C8(Name = "Текст", Comment = "", Synonym = "Простой текст")]
        Текст,
        [Description1C8(Name = "Прочее", Comment = "", Synonym = "Прочее")]
        Прочее,
        [Description1C8(Name = "HTMLСКартинками", Comment = "", Synonym = "HTML с картинками")]
        HTMLСКартинками
    }
}
