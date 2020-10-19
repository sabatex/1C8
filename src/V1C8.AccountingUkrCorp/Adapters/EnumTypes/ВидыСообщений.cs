using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыСообщений:V1C8COMObject
    {
        public ВидыСообщений(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Раздел => GetProperty<EnumItemBase>("Раздел");
        public EnumItemBase Информация => GetProperty<EnumItemBase>("Информация");
        public EnumItemBase ВажнаяИнформация => GetProperty<EnumItemBase>("ВажнаяИнформация");
        public EnumItemBase Ошибка => GetProperty<EnumItemBase>("Ошибка");
    }
}
