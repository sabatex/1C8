using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыСостоянийНМА:V1C8COMObject
    {
        public ВидыСостоянийНМА(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Поступил => GetProperty<EnumItemBase>();
        public EnumItemBase ПринятКУчету => GetProperty<EnumItemBase>();
        public EnumItemBase Списан => GetProperty<EnumItemBase>();
    }
}
