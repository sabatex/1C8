using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ПричиныОтключенияРасширенийВМоделиСервиса:V1C8COMObject
    {
        public ПричиныОтключенияРасширенийВМоделиСервиса(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase БлокировкаАдминистраторомСервиса => GetProperty<EnumItemBase>("БлокировкаАдминистраторомСервиса");
        public EnumItemBase БлокировкаВладельцем => GetProperty<EnumItemBase>("БлокировкаВладельцем");
        public EnumItemBase ОбновлениеВерсииКонфигурации => GetProperty<EnumItemBase>("ОбновлениеВерсииКонфигурации");
    }
}
