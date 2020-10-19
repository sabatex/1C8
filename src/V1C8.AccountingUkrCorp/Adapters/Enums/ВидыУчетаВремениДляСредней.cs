using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыУчетаВремениДляСредней:V1C8COMObject
    {
        public ВидыУчетаВремениДляСредней(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПоРабочимДням => GetProperty<EnumItemBase>();
        public EnumItemBase ПоРабочимЧасам => GetProperty<EnumItemBase>();
    }
}
