using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыУчетаВремениДляСредней:V1C8COMObject
    {
        public ВидыУчетаВремениДляСредней(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПоРабочимДням => GetProperty<EnumItemBase>("ПоРабочимДням");
        public EnumItemBase ПоРабочимЧасам => GetProperty<EnumItemBase>("ПоРабочимЧасам");
    }
}
