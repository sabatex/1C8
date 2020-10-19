using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СпособыРаспределенияДопРасходов:V1C8COMObject
    {
        public СпособыРаспределенияДопРасходов(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПоСумме => GetProperty<EnumItemBase>();
        public EnumItemBase ПоКоличеству => GetProperty<EnumItemBase>();
    }
}
