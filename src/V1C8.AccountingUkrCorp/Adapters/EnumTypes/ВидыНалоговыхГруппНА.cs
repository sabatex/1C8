using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыНалоговыхГруппНА:V1C8COMObject
    {
        public ВидыНалоговыхГруппНА(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ДоНКУ => GetProperty<EnumItemBase>("ДоНКУ");
        public EnumItemBase ОС => GetProperty<EnumItemBase>("ОС");
        public EnumItemBase НМА => GetProperty<EnumItemBase>("НМА");
    }
}
