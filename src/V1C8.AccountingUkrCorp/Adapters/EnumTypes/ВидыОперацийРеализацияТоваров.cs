using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОперацийРеализацияТоваров:V1C8COMObject
    {
        public ВидыОперацийРеализацияТоваров(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПродажаКомиссия => GetProperty<EnumItemBase>("ПродажаКомиссия");
        public EnumItemBase Оборудование => GetProperty<EnumItemBase>("Оборудование");
    }
}
