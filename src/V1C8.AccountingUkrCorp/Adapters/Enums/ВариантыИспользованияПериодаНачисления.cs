using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВариантыИспользованияПериодаНачисления:V1C8COMObject
    {
        public ВариантыИспользованияПериодаНачисления(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПериодДействия => GetProperty<EnumItemBase>();
        public EnumItemBase БазовыйПериод => GetProperty<EnumItemBase>();
        public EnumItemBase НеИспользовать => GetProperty<EnumItemBase>();
    }
}
