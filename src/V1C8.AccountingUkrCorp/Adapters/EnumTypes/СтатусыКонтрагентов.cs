using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СтатусыКонтрагентов:V1C8COMObject
    {
        public СтатусыКонтрагентов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Покупатель => GetProperty<EnumItemBase>("Покупатель");
        public EnumItemBase Поставщик => GetProperty<EnumItemBase>("Поставщик");
        public EnumItemBase Прочее => GetProperty<EnumItemBase>("Прочее");
    }
}
