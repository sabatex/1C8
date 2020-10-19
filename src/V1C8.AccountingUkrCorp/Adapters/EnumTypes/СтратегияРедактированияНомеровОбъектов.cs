using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СтратегияРедактированияНомеровОбъектов:V1C8COMObject
    {
        public СтратегияРедактированияНомеровОбъектов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase НеДоступно => GetProperty<EnumItemBase>("НеДоступно");
        public EnumItemBase Доступно => GetProperty<EnumItemBase>("Доступно");
    }
}
