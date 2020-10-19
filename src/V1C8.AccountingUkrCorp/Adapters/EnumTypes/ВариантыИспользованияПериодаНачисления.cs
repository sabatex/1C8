using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВариантыИспользованияПериодаНачисления:EnumBase
    {
        public ВариантыИспользованияПериодаНачисления(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ПериодДействия => GetProperty<EnumItem>("ПериодДействия");
        public EnumItem БазовыйПериод => GetProperty<EnumItem>("БазовыйПериод");
        public EnumItem НеИспользовать => GetProperty<EnumItem>("НеИспользовать");
    }
}
