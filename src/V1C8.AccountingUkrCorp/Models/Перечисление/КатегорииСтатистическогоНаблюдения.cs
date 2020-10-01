using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "КатегорииСтатистическогоНаблюдения", Comment = "", Synonym = "Категории статистического наблюдения")]
    public enum КатегорииСтатистическогоНаблюдения
    {
        [Description1C8(Name = "ВыплатаСоциальногоХарактера", Comment = "", Synonym = "Выплата социального характера")]
        ВыплатаСоциальногоХарактера,
        [Description1C8(Name = "ЗаработнаяПлатаРаботников", Comment = "", Synonym = "Заработная плата работников")]
        ЗаработнаяПлатаРаботников
    }
}
