using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СтратегииОтраженияВУчетеНачисленийУдержаний", Comment = "", Synonym = "Стратегии отражения в учете начислений удержаний")]
    public class СтратегииОтраженияВУчетеНачисленийУдержаний:EnumItem
    {
        public static readonly СтратегииОтраженияВУчетеНачисленийУдержаний ПоБазовымРасчетам = new СтратегииОтраженияВУчетеНачисленийУдержаний{Name= "ПоБазовымРасчетам",Synonim="По базовым расчетам",Comment=""};
        public static readonly СтратегииОтраженияВУчетеНачисленийУдержаний ПоДаннымОСотрудникеИЕгоПлановыхНачислениях = new СтратегииОтраженияВУчетеНачисленийУдержаний{Name= "ПоДаннымОСотрудникеИЕгоПлановыхНачислениях",Synonim="По данным о сотруднике и его плановых начислениях",Comment=""};
        public static readonly СтратегииОтраженияВУчетеНачисленийУдержаний КакЗаданоВидуРасчета = new СтратегииОтраженияВУчетеНачисленийУдержаний{Name= "КакЗаданоВидуРасчета",Synonim="Как задано виду расчета",Comment=""};
    }
}
