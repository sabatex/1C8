using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ПричиныОтключенияДополнительныхОтчетовИОбработокВМоделиСервиса:EnumBase
    {
        public ПричиныОтключенияДополнительныхОтчетовИОбработокВМоделиСервиса(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem БлокировкаАдминистраторомСервиса => GetProperty<EnumItem>("БлокировкаАдминистраторомСервиса");
        public EnumItem БлокировкаВладельцем => GetProperty<EnumItem>("БлокировкаВладельцем");
        public EnumItem ОбновлениеВерсииКонфигурации => GetProperty<EnumItem>("ОбновлениеВерсииКонфигурации");
    }
}
