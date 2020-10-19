using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВариантыАлгоритмовРасчетНДФЛ17:EnumBase
    {
        public ВариантыАлгоритмовРасчетНДФЛ17(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ДоначислениеНаСуммуПревышения => GetProperty<EnumItem>("ДоначислениеНаСуммуПревышения");
        public EnumItem ОтдельныйРасчетБазы => GetProperty<EnumItem>("ОтдельныйРасчетБазы");
    }
}
