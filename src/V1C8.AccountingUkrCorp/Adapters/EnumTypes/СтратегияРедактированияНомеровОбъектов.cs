using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СтратегияРедактированияНомеровОбъектов:EnumBase
    {
        public СтратегияРедактированияНомеровОбъектов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem НеДоступно => GetProperty<EnumItem>("НеДоступно");
        public EnumItem Доступно => GetProperty<EnumItem>("Доступно");
    }
}
