using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class УдалитьВидыТекстовЭлектронныхПисем:V1C8COMObject
    {
        public УдалитьВидыТекстовЭлектронныхПисем(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase HTML => GetProperty<EnumItemBase>();
        public EnumItemBase Текст => GetProperty<EnumItemBase>();
        public EnumItemBase Прочее => GetProperty<EnumItemBase>();
        public EnumItemBase HTMLСКартинками => GetProperty<EnumItemBase>();
    }
}
