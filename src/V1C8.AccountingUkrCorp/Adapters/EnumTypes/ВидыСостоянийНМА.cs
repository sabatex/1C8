using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыСостоянийНМА:V1C8COMObject
    {
        public ВидыСостоянийНМА(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Поступил => GetProperty<EnumItemBase>("Поступил");
        public EnumItemBase ПринятКУчету => GetProperty<EnumItemBase>("ПринятКУчету");
        public EnumItemBase Списан => GetProperty<EnumItemBase>("Списан");
    }
}
