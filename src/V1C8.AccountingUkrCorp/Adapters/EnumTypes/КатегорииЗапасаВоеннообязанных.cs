using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class КатегорииЗапасаВоеннообязанных:V1C8COMObject
    {
        public КатегорииЗапасаВоеннообязанных(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПерваяКатегория => GetProperty<EnumItemBase>("ПерваяКатегория");
        public EnumItemBase ВтораяКатегория => GetProperty<EnumItemBase>("ВтораяКатегория");
    }
}
