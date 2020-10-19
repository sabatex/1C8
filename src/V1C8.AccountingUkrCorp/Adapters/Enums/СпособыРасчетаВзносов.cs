using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СпособыРасчетаВзносов:V1C8COMObject
    {
        public СпособыРасчетаВзносов(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Взносы => GetProperty<EnumItemBase>();
        public EnumItemBase ВзносыФОТ => GetProperty<EnumItemBase>();
    }
}
