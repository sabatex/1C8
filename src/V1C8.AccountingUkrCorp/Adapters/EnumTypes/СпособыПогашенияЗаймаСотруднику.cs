using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыПогашенияЗаймаСотруднику:V1C8COMObject
    {
        public СпособыПогашенияЗаймаСотруднику(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ВТечениеСрока => GetProperty<EnumItemBase>("ВТечениеСрока");
        public EnumItemBase ПоОкончанииСрока => GetProperty<EnumItemBase>("ПоОкончанииСрока");
    }
}
