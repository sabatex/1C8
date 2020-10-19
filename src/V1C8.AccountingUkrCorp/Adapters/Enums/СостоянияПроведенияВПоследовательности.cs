using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СостоянияПроведенияВПоследовательности:V1C8COMObject
    {
        public СостоянияПроведенияВПоследовательности(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПроведенВПоследовательности => GetProperty<EnumItemBase>();
        public EnumItemBase ПроведенСНарушениемПоследовательности => GetProperty<EnumItemBase>();
        public EnumItemBase ИсключенИзПоследовательности => GetProperty<EnumItemBase>();
    }
}
