using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыРедактированияЭлектронныхПисем", Comment = "", Synonym = "Способы редактирования электронных писем")]
    public enum СпособыРедактированияЭлектронныхПисем
    {
        [Description1C8(Name = "ОбычныйТекст", Comment = "", Synonym = "Обычный текст")]
        ОбычныйТекст,
        [Description1C8(Name = "HTML", Comment = "", Synonym = "HTML")]
        HTML
    }
}
