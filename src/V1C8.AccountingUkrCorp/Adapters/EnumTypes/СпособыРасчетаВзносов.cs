using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыРасчетаВзносов:V1C8COMObject
    {
        public СпособыРасчетаВзносов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Взносы => GetProperty<EnumItemBase>("Взносы");
        public EnumItemBase ВзносыФОТ => GetProperty<EnumItemBase>("ВзносыФОТ");
    }
}
