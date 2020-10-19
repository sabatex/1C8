using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыСообщений:V1C8COMObject
    {
        public ВидыСообщений(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Раздел => GetProperty<EnumItemBase>();
        public EnumItemBase Информация => GetProperty<EnumItemBase>();
        public EnumItemBase ВажнаяИнформация => GetProperty<EnumItemBase>();
        public EnumItemBase Ошибка => GetProperty<EnumItemBase>();
    }
}
