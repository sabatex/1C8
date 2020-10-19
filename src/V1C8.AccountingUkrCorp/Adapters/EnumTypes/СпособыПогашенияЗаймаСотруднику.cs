using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыПогашенияЗаймаСотруднику:EnumBase
    {
        public СпособыПогашенияЗаймаСотруднику(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ВТечениеСрока => GetProperty<EnumItem>("ВТечениеСрока");
        public EnumItem ПоОкончанииСрока => GetProperty<EnumItem>("ПоОкончанииСрока");
    }
}
