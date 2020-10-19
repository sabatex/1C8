using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class КодыОперацийТоварыВНТТВПродажныхЦенахНалоговыйУчет:V1C8COMObject
    {
        public КодыОперацийТоварыВНТТВПродажныхЦенахНалоговыйУчет(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Поступление => GetProperty<EnumItemBase>();
        public EnumItemBase Возврат => GetProperty<EnumItemBase>();
        public EnumItemBase Реализация => GetProperty<EnumItemBase>();
    }
}
