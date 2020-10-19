using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СтратегииОтраженияВУчетеЕСВ:V1C8COMObject
    {
        public СтратегииОтраженияВУчетеЕСВ(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase КакНачисление => GetProperty<EnumItemBase>();
        public EnumItemBase КакОсновноеНачислениеСотрудника => GetProperty<EnumItemBase>();
        public EnumItemBase ОсобымСпособом => GetProperty<EnumItemBase>();
    }
}
