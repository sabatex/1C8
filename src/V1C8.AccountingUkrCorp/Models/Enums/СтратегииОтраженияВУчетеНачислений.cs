using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СтратегииОтраженияВУчетеНачислений", Comment = "", Synonym = "Стратегии отражения в учете начислений")]
    public class СтратегииОтраженияВУчетеНачислений:EnumItem
    {
        public static readonly СтратегииОтраженияВУчетеНачислений ПоБазовымРасчетам = new СтратегииОтраженияВУчетеНачислений{Name= "ПоБазовымРасчетам",Synonim="По базовым расчетам",Comment=""};
        public static readonly СтратегииОтраженияВУчетеНачислений ПоДаннымОСотрудникеИЕгоПлановыхНачислениях = new СтратегииОтраженияВУчетеНачислений{Name= "ПоДаннымОСотрудникеИЕгоПлановыхНачислениях",Synonim="По данным о сотруднике и его плановых начислениях",Comment=""};
        public static readonly СтратегииОтраженияВУчетеНачислений КакЗаданоВидуРасчета = new СтратегииОтраженияВУчетеНачислений{Name= "КакЗаданоВидуРасчета",Synonim="Как задано виду расчета",Comment=""};
    }
}
