using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СтатусыКонтрагентов:V1C8COMObject
    {
        public СтатусыКонтрагентов(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Покупатель => GetProperty<EnumItemBase>();
        public EnumItemBase Поставщик => GetProperty<EnumItemBase>();
        public EnumItemBase Прочее => GetProperty<EnumItemBase>();
    }
}
