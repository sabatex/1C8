using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВариантыАлгоритмовРасчетНДФЛ17:V1C8COMObject
    {
        public ВариантыАлгоритмовРасчетНДФЛ17(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ДоначислениеНаСуммуПревышения => GetProperty<EnumItemBase>("ДоначислениеНаСуммуПревышения");
        public EnumItemBase ОтдельныйРасчетБазы => GetProperty<EnumItemBase>("ОтдельныйРасчетБазы");
    }
}
