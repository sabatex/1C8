using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыСостоянийНМА:EnumBase
    {
        public ВидыСостоянийНМА(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Поступил => GetProperty<EnumItem>("Поступил");
        public EnumItem ПринятКУчету => GetProperty<EnumItem>("ПринятКУчету");
        public EnumItem Списан => GetProperty<EnumItem>("Списан");
    }
}
