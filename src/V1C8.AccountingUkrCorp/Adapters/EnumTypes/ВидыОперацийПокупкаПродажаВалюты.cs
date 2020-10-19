using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОперацийПокупкаПродажаВалюты:V1C8COMObject
    {
        public ВидыОперацийПокупкаПродажаВалюты(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПокупкаВалюты => GetProperty<EnumItemBase>("ПокупкаВалюты");
        public EnumItemBase ПродажаВалюты => GetProperty<EnumItemBase>("ПродажаВалюты");
    }
}
