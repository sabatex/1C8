using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class БонусныеПрограммыБанков:EnumBase
    {
        public БонусныеПрограммыБанков(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem AE => GetProperty<EnumItem>("AE");
        public EnumItem GM => GetProperty<EnumItem>("GM");
        public EnumItem PG => GetProperty<EnumItem>("PG");
    }
}
