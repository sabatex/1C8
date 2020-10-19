using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ТипыТекстовЭлектронныхПисем:V1C8COMObject
    {
        public ТипыТекстовЭлектронныхПисем(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase HTML => GetProperty<EnumItemBase>();
        public EnumItemBase ПростойТекст => GetProperty<EnumItemBase>();
        public EnumItemBase РазмеченныйТекст => GetProperty<EnumItemBase>();
        public EnumItemBase HTMLСКартинками => GetProperty<EnumItemBase>();
    }
}
