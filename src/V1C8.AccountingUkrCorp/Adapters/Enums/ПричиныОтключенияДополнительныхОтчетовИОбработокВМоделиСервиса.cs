using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ПричиныОтключенияДополнительныхОтчетовИОбработокВМоделиСервиса:V1C8COMObject
    {
        public ПричиныОтключенияДополнительныхОтчетовИОбработокВМоделиСервиса(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase БлокировкаАдминистраторомСервиса => GetProperty<EnumItemBase>();
        public EnumItemBase БлокировкаВладельцем => GetProperty<EnumItemBase>();
        public EnumItemBase ОбновлениеВерсииКонфигурации => GetProperty<EnumItemBase>();
    }
}
