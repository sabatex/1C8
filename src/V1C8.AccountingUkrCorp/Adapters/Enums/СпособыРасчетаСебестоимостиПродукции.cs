using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СпособыРасчетаСебестоимостиПродукции:V1C8COMObject
    {
        public СпособыРасчетаСебестоимостиПродукции(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПоПеределам => GetProperty<EnumItemBase>();
        public EnumItemBase ПоПодразделениям => GetProperty<EnumItemBase>();
    }
}
