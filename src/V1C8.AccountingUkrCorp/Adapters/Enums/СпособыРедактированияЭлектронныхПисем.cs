using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СпособыРедактированияЭлектронныхПисем:V1C8COMObject
    {
        public СпособыРедактированияЭлектронныхПисем(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОбычныйТекст => GetProperty<EnumItemBase>();
        public EnumItemBase HTML => GetProperty<EnumItemBase>();
    }
}
