using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыОперацийПокупкаПродажаВалюты:V1C8COMObject
    {
        public ВидыОперацийПокупкаПродажаВалюты(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПокупкаВалюты => GetProperty<EnumItemBase>();
        public EnumItemBase ПродажаВалюты => GetProperty<EnumItemBase>();
    }
}
