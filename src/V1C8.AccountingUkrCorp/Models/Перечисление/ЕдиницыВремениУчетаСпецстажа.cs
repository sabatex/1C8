using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ЕдиницыВремениУчетаСпецстажа", Comment = "", Synonym = "Единицы времени учета спецстажа")]
    public enum ЕдиницыВремениУчетаСпецстажа
    {
        [Description1C8(Name = "КалендарныеДни", Comment = "", Synonym = "Календарные дни")]
        КалендарныеДни,
        [Description1C8(Name = "Смены", Comment = "", Synonym = "Смены")]
        Смены,
        [Description1C8(Name = "Часы", Comment = "", Synonym = "Часы")]
        Часы
    }
}
