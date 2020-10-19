using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыРасчетаВзносов:EnumBase
    {
        public СпособыРасчетаВзносов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Взносы => GetProperty<EnumItem>("Взносы");
        public EnumItem ВзносыФОТ => GetProperty<EnumItem>("ВзносыФОТ");
    }
}
