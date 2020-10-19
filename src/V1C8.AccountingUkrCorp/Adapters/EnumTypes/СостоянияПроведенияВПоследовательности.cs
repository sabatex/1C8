using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СостоянияПроведенияВПоследовательности:V1C8COMObject
    {
        public СостоянияПроведенияВПоследовательности(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПроведенВПоследовательности => GetProperty<EnumItemBase>("ПроведенВПоследовательности");
        public EnumItemBase ПроведенСНарушениемПоследовательности => GetProperty<EnumItemBase>("ПроведенСНарушениемПоследовательности");
        public EnumItemBase ИсключенИзПоследовательности => GetProperty<EnumItemBase>("ИсключенИзПоследовательности");
    }
}
