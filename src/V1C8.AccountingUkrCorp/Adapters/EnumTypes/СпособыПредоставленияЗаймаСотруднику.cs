using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыПредоставленияЗаймаСотруднику:V1C8COMObject
    {
        public СпособыПредоставленияЗаймаСотруднику(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Единовременно => GetProperty<EnumItemBase>("Единовременно");
        public EnumItemBase Траншами => GetProperty<EnumItemBase>("Траншами");
    }
}
