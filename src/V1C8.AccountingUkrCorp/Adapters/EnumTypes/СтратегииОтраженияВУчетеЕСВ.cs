using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СтратегииОтраженияВУчетеЕСВ:V1C8COMObject
    {
        public СтратегииОтраженияВУчетеЕСВ(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase КакНачисление => GetProperty<EnumItemBase>("КакНачисление");
        public EnumItemBase КакОсновноеНачислениеСотрудника => GetProperty<EnumItemBase>("КакОсновноеНачислениеСотрудника");
        public EnumItemBase ОсобымСпособом => GetProperty<EnumItemBase>("ОсобымСпособом");
    }
}
