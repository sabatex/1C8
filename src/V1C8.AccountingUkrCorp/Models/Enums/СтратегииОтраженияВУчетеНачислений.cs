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
    [Table("StratehyyOtrazhenyiaVUcheteNachyslenyi")]
    [Description1C8(Name = "СтратегииОтраженияВУчетеНачислений", Comment = "", Synonym = "Стратегии отражения в учете начислений")]
    public class СтратегииОтраженияВУчетеНачислений:EnumItem
    {
        public static readonly СтратегииОтраженияВУчетеНачислений ПоБазовымРасчетам = new СтратегииОтраженияВУчетеНачислений{Name= "ПоБазовымРасчетам",Synonym="По базовым расчетам",Comment=""};
        public static readonly СтратегииОтраженияВУчетеНачислений ПоДаннымОСотрудникеИЕгоПлановыхНачислениях = new СтратегииОтраженияВУчетеНачислений{Name= "ПоДаннымОСотрудникеИЕгоПлановыхНачислениях",Synonym="По данным о сотруднике и его плановых начислениях",Comment=""};
        public static readonly СтратегииОтраженияВУчетеНачислений КакЗаданоВидуРасчета = new СтратегииОтраженияВУчетеНачислений{Name= "КакЗаданоВидуРасчета",Synonym="Как задано виду расчета",Comment=""};
    }
}
