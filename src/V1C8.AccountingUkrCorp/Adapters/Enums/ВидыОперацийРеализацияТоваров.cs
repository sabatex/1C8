using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыОперацийРеализацияТоваров:V1C8COMObject
    {
        public ВидыОперацийРеализацияТоваров(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПродажаКомиссия => GetProperty<EnumItemBase>();
        public EnumItemBase Оборудование => GetProperty<EnumItemBase>();
    }
}
