using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыРедактированияЭлектронныхПисем:V1C8COMObject
    {
        public СпособыРедактированияЭлектронныхПисем(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОбычныйТекст => GetProperty<EnumItemBase>("ОбычныйТекст");
        public EnumItemBase HTML => GetProperty<EnumItemBase>("HTML");
    }
}
