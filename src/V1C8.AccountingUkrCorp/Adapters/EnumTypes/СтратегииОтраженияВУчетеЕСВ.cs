using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СтратегииОтраженияВУчетеЕСВ:EnumBase
    {
        public СтратегииОтраженияВУчетеЕСВ(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem КакНачисление => GetProperty<EnumItem>("КакНачисление");
        public EnumItem КакОсновноеНачислениеСотрудника => GetProperty<EnumItem>("КакОсновноеНачислениеСотрудника");
        public EnumItem ОсобымСпособом => GetProperty<EnumItem>("ОсобымСпособом");
    }
}
