using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВариантыАлгоритмовРасчетНДФЛ17", Comment = "", Synonym = "Варианты алгоритмов расчет НДФЛ 17%")]
    public enum ВариантыАлгоритмовРасчетНДФЛ17
    {
        [Description1C8(Name = "ДоначислениеНаСуммуПревышения", Comment = "", Synonym = "Доначисление на сумму превышения")]
        ДоначислениеНаСуммуПревышения,
        [Description1C8(Name = "ОтдельныйРасчетБазы", Comment = "", Synonym = "Устарело - Отдельный расчет базы для 17%")]
        ОтдельныйРасчетБазы
    }
}
