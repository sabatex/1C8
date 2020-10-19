using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыПредоставленияЗаймаСотруднику:EnumBase
    {
        public СпособыПредоставленияЗаймаСотруднику(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Единовременно => GetProperty<EnumItem>("Единовременно");
        public EnumItem Траншами => GetProperty<EnumItem>("Траншами");
    }
}
