using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СпособыПредоставленияЗаймаСотруднику:V1C8COMObject
    {
        public СпособыПредоставленияЗаймаСотруднику(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Единовременно => GetProperty<EnumItemBase>();
        public EnumItemBase Траншами => GetProperty<EnumItemBase>();
    }
}
