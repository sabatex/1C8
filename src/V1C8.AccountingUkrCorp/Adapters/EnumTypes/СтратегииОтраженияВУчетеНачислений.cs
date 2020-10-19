using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СтратегииОтраженияВУчетеНачислений:V1C8COMObject
    {
        public СтратегииОтраженияВУчетеНачислений(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПоБазовымРасчетам => GetProperty<EnumItemBase>("ПоБазовымРасчетам");
        public EnumItemBase ПоДаннымОСотрудникеИЕгоПлановыхНачислениях => GetProperty<EnumItemBase>("ПоДаннымОСотрудникеИЕгоПлановыхНачислениях");
        public EnumItemBase КакЗаданоВидуРасчета => GetProperty<EnumItemBase>("КакЗаданоВидуРасчета");
    }
}
