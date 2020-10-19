using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыРаспределенияДопРасходов:V1C8COMObject
    {
        public СпособыРаспределенияДопРасходов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПоСумме => GetProperty<EnumItemBase>("ПоСумме");
        public EnumItemBase ПоКоличеству => GetProperty<EnumItemBase>("ПоКоличеству");
    }
}
