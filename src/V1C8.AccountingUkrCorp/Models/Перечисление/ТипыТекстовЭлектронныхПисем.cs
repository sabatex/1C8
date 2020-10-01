using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ТипыТекстовЭлектронныхПисем", Comment = "", Synonym = "Типы текстов электронных писем")]
    public enum ТипыТекстовЭлектронныхПисем
    {
        [Description1C8(Name = "HTML", Comment = "", Synonym = "HTML")]
        HTML,
        [Description1C8(Name = "ПростойТекст", Comment = "", Synonym = "Простой текст")]
        ПростойТекст,
        [Description1C8(Name = "РазмеченныйТекст", Comment = "", Synonym = "Размеченный текст")]
        РазмеченныйТекст,
        [Description1C8(Name = "HTMLСКартинками", Comment = "", Synonym = "HTML с картинками")]
        HTMLСКартинками
    }
}
