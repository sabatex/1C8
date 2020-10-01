using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ПорядокФормированияСправкиОДоходахФизическогоЛица", Comment = "", Synonym = "Порядок формирования справки о доходах физического лица")]
    public enum ПорядокФормированияСправкиОДоходахФизическогоЛица
    {
        [Description1C8(Name = "Сводно", Comment = "", Synonym = "Сводно")]
        Сводно,
        [Description1C8(Name = "ВРазрезеКодовОКАТО", Comment = "", Synonym = "В разрезе кодов ОКАТО/КПП и ставок налога")]
        ВРазрезеКодовОКАТО
    }
}
