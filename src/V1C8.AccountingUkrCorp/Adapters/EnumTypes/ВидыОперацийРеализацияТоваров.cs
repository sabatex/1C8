using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОперацийРеализацияТоваров:EnumBase
    {
        public ВидыОперацийРеализацияТоваров(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ПродажаКомиссия => GetProperty<EnumItem>("ПродажаКомиссия");
        public EnumItem Оборудование => GetProperty<EnumItem>("Оборудование");
    }
}
