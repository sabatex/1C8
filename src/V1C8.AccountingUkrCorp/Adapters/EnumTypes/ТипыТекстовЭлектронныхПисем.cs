using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ТипыТекстовЭлектронныхПисем:EnumBase
    {
        public ТипыТекстовЭлектронныхПисем(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem HTML => GetProperty<EnumItem>("HTML");
        public EnumItem ПростойТекст => GetProperty<EnumItem>("ПростойТекст");
        public EnumItem РазмеченныйТекст => GetProperty<EnumItem>("РазмеченныйТекст");
        public EnumItem HTMLСКартинками => GetProperty<EnumItem>("HTMLСКартинками");
    }
}
