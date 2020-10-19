using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СтратегииОтраженияВУчетеНачислений:V1C8COMObject
    {
        public СтратегииОтраженияВУчетеНачислений(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПоБазовымРасчетам => GetProperty<EnumItemBase>();
        public EnumItemBase ПоДаннымОСотрудникеИЕгоПлановыхНачислениях => GetProperty<EnumItemBase>();
        public EnumItemBase КакЗаданоВидуРасчета => GetProperty<EnumItemBase>();
    }
}
