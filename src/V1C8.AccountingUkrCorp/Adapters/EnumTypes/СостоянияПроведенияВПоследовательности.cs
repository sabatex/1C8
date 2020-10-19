using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СостоянияПроведенияВПоследовательности:EnumBase
    {
        public СостоянияПроведенияВПоследовательности(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ПроведенВПоследовательности => GetProperty<EnumItem>("ПроведенВПоследовательности");
        public EnumItem ПроведенСНарушениемПоследовательности => GetProperty<EnumItem>("ПроведенСНарушениемПоследовательности");
        public EnumItem ИсключенИзПоследовательности => GetProperty<EnumItem>("ИсключенИзПоследовательности");
    }
}
