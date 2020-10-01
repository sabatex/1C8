using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СтратегияРедактированияНомеровОбъектов", Comment = "", Synonym = "Стратегия редактирования номеров объектов")]
    public enum СтратегияРедактированияНомеровОбъектов
    {
        [Description1C8(Name = "НеДоступно", Comment = "", Synonym = "Недоступно")]
        НеДоступно,
        [Description1C8(Name = "Доступно", Comment = "", Synonym = "Доступно")]
        Доступно
    }
}
