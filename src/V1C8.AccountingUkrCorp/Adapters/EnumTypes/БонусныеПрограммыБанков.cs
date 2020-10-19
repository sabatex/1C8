using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class БонусныеПрограммыБанков:V1C8COMObject
    {
        public БонусныеПрограммыБанков(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase AE => GetProperty<EnumItemBase>("AE");
        public EnumItemBase GM => GetProperty<EnumItemBase>("GM");
        public EnumItemBase PG => GetProperty<EnumItemBase>("PG");
    }
}
