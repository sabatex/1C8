using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "КатегорииСтатистическогоНаблюдения", Comment = "", Synonym = "Категории статистического наблюдения")]
    public class КатегорииСтатистическогоНаблюдения:EnumItem
    {
        public static readonly КатегорииСтатистическогоНаблюдения ВыплатаСоциальногоХарактера = new КатегорииСтатистическогоНаблюдения{Name= "ВыплатаСоциальногоХарактера",Synonim="Выплата социального характера",Comment=""};
        public static readonly КатегорииСтатистическогоНаблюдения ЗаработнаяПлатаРаботников = new КатегорииСтатистическогоНаблюдения{Name= "ЗаработнаяПлатаРаботников",Synonim="Заработная плата работников",Comment=""};
    }
}
