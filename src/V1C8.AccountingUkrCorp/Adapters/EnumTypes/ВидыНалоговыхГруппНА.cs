using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыНалоговыхГруппНА:EnumBase
    {
        public ВидыНалоговыхГруппНА(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ДоНКУ => GetProperty<EnumItem>("ДоНКУ");
        public EnumItem ОС => GetProperty<EnumItem>("ОС");
        public EnumItem НМА => GetProperty<EnumItem>("НМА");
    }
}
