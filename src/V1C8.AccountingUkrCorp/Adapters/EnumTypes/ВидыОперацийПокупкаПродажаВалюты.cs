using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОперацийПокупкаПродажаВалюты:EnumBase
    {
        public ВидыОперацийПокупкаПродажаВалюты(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ПокупкаВалюты => GetProperty<EnumItem>("ПокупкаВалюты");
        public EnumItem ПродажаВалюты => GetProperty<EnumItem>("ПродажаВалюты");
    }
}
