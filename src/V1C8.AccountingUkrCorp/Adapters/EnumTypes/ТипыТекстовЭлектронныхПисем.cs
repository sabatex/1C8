using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ТипыТекстовЭлектронныхПисем:V1C8COMObject
    {
        public ТипыТекстовЭлектронныхПисем(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase HTML => GetProperty<EnumItemBase>("HTML");
        public EnumItemBase ПростойТекст => GetProperty<EnumItemBase>("ПростойТекст");
        public EnumItemBase РазмеченныйТекст => GetProperty<EnumItemBase>("РазмеченныйТекст");
        public EnumItemBase HTMLСКартинками => GetProperty<EnumItemBase>("HTMLСКартинками");
    }
}
