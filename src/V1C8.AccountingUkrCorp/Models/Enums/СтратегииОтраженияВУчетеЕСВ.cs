using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Table("StratehyyOtrazhenyiaVUcheteESV")]
    [Description1C8(Name = "СтратегииОтраженияВУчетеЕСВ", Comment = "", Synonym = "Стратегии отражения в учете ЕСВ")]
    public class СтратегииОтраженияВУчетеЕСВ:EnumItem
    {
        public static readonly СтратегииОтраженияВУчетеЕСВ КакНачисление = new СтратегииОтраженияВУчетеЕСВ{Name= "КакНачисление",Synonym="Как начисление",Comment=""};
        public static readonly СтратегииОтраженияВУчетеЕСВ КакОсновноеНачислениеСотрудника = new СтратегииОтраженияВУчетеЕСВ{Name= "КакОсновноеНачислениеСотрудника",Synonym="Как основное начисление сотрудника",Comment=""};
        public static readonly СтратегииОтраженияВУчетеЕСВ ОсобымСпособом = new СтратегииОтраженияВУчетеЕСВ{Name= "ОсобымСпособом",Synonym="Особым способом",Comment=""};
    }
}
