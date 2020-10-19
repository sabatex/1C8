using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыНалоговыхГруппНА:V1C8COMObject
    {
        public ВидыНалоговыхГруппНА(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ДоНКУ => GetProperty<EnumItemBase>();
        public EnumItemBase ОС => GetProperty<EnumItemBase>();
        public EnumItemBase НМА => GetProperty<EnumItemBase>();
    }
}
