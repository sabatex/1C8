using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыРасчетаДоплатыЗаСовмещение:V1C8COMObject
    {
        public СпособыРасчетаДоплатыЗаСовмещение(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПроцентФОТ => GetProperty<EnumItemBase>("ПроцентФОТ");
        public EnumItemBase РазницаФОТ => GetProperty<EnumItemBase>("РазницаФОТ");
    }
}
