using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СтратегииОтраженияВУчетеНачисленийУдержаний", Comment = "", Synonym = "Стратегии отражения в учете начислений удержаний")]
    public enum СтратегииОтраженияВУчетеНачисленийУдержаний
    {
        [Description1C8(Name = "ПоБазовымРасчетам", Comment = "", Synonym = "По базовым расчетам")]
        ПоБазовымРасчетам,
        [Description1C8(Name = "ПоДаннымОСотрудникеИЕгоПлановыхНачислениях", Comment = "", Synonym = "По данным о сотруднике и его плановых начислениях")]
        ПоДаннымОСотрудникеИЕгоПлановыхНачислениях,
        [Description1C8(Name = "КакЗаданоВидуРасчета", Comment = "", Synonym = "Как задано виду расчета")]
        КакЗаданоВидуРасчета
    }
}
