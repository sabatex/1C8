using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВариантыАлгоритмовРасчетНДФЛ17:V1C8COMObject
    {
        public ВариантыАлгоритмовРасчетНДФЛ17(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ДоначислениеНаСуммуПревышения => GetProperty<EnumItemBase>();
        public EnumItemBase ОтдельныйРасчетБазы => GetProperty<EnumItemBase>();
    }
}
