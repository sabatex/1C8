using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class УдалитьВидыТекстовЭлектронныхПисем:V1C8COMObject
    {
        public УдалитьВидыТекстовЭлектронныхПисем(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase HTML => GetProperty<EnumItemBase>("HTML");
        public EnumItemBase Текст => GetProperty<EnumItemBase>("Текст");
        public EnumItemBase Прочее => GetProperty<EnumItemBase>("Прочее");
        public EnumItemBase HTMLСКартинками => GetProperty<EnumItemBase>("HTMLСКартинками");
    }
}
