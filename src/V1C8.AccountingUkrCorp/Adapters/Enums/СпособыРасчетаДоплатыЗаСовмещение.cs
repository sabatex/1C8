using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СпособыРасчетаДоплатыЗаСовмещение:V1C8COMObject
    {
        public СпособыРасчетаДоплатыЗаСовмещение(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПроцентФОТ => GetProperty<EnumItemBase>();
        public EnumItemBase РазницаФОТ => GetProperty<EnumItemBase>();
    }
}
