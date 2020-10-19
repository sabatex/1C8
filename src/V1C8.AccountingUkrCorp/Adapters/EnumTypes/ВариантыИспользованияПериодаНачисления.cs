using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВариантыИспользованияПериодаНачисления:V1C8COMObject
    {
        public ВариантыИспользованияПериодаНачисления(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПериодДействия => GetProperty<EnumItemBase>("ПериодДействия");
        public EnumItemBase БазовыйПериод => GetProperty<EnumItemBase>("БазовыйПериод");
        public EnumItemBase НеИспользовать => GetProperty<EnumItemBase>("НеИспользовать");
    }
}
