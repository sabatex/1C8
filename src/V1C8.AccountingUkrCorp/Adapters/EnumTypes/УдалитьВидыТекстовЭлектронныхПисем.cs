using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class УдалитьВидыТекстовЭлектронныхПисем:EnumBase
    {
        public УдалитьВидыТекстовЭлектронныхПисем(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem HTML => GetProperty<EnumItem>("HTML");
        public EnumItem Текст => GetProperty<EnumItem>("Текст");
        public EnumItem Прочее => GetProperty<EnumItem>("Прочее");
        public EnumItem HTMLСКартинками => GetProperty<EnumItem>("HTMLСКартинками");
    }
}
