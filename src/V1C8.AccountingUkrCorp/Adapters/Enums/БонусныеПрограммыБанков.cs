using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class БонусныеПрограммыБанков:V1C8COMObject
    {
        public БонусныеПрограммыБанков(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase AE => GetProperty<EnumItemBase>();
        public EnumItemBase GM => GetProperty<EnumItemBase>();
        public EnumItemBase PG => GetProperty<EnumItemBase>();
    }
}
