using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыСообщений:EnumBase
    {
        public ВидыСообщений(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Раздел => GetProperty<EnumItem>("Раздел");
        public EnumItem Информация => GetProperty<EnumItem>("Информация");
        public EnumItem ВажнаяИнформация => GetProperty<EnumItem>("ВажнаяИнформация");
        public EnumItem Ошибка => GetProperty<EnumItem>("Ошибка");
    }
}
