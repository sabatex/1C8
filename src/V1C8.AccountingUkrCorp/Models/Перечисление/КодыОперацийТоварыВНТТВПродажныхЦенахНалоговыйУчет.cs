using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "КодыОперацийТоварыВНТТВПродажныхЦенахНалоговыйУчет", Comment = "", Synonym = "Коды операций регистра 'Товары в НТТ в продажных ценах (налоговый учет)'")]
    public enum КодыОперацийТоварыВНТТВПродажныхЦенахНалоговыйУчет
    {
        [Description1C8(Name = "Поступление", Comment = "", Synonym = "Поступление")]
        Поступление,
        [Description1C8(Name = "Возврат", Comment = "", Synonym = "Возврат")]
        Возврат,
        [Description1C8(Name = "Реализация", Comment = "", Synonym = "Реализация")]
        Реализация
    }
}
