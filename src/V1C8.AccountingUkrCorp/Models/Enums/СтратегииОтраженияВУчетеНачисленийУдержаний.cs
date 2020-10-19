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
    [Table("StratehyyOtrazhenyiaVUcheteNachyslenyiUderzhanyi")]
    [Description1C8(Name = "СтратегииОтраженияВУчетеНачисленийУдержаний", Comment = "", Synonym = "Стратегии отражения в учете начислений удержаний")]
    public class СтратегииОтраженияВУчетеНачисленийУдержаний:EnumItem
    {
        public static readonly СтратегииОтраженияВУчетеНачисленийУдержаний ПоБазовымРасчетам = new СтратегииОтраженияВУчетеНачисленийУдержаний{Name= "ПоБазовымРасчетам",Synonym="По базовым расчетам",Comment=""};
        public static readonly СтратегииОтраженияВУчетеНачисленийУдержаний ПоДаннымОСотрудникеИЕгоПлановыхНачислениях = new СтратегииОтраженияВУчетеНачисленийУдержаний{Name= "ПоДаннымОСотрудникеИЕгоПлановыхНачислениях",Synonym="По данным о сотруднике и его плановых начислениях",Comment=""};
        public static readonly СтратегииОтраженияВУчетеНачисленийУдержаний КакЗаданоВидуРасчета = new СтратегииОтраженияВУчетеНачисленийУдержаний{Name= "КакЗаданоВидуРасчета",Synonym="Как задано виду расчета",Comment=""};
    }
}
