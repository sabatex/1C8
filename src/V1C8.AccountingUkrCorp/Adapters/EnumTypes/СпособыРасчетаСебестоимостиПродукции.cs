using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыРасчетаСебестоимостиПродукции:V1C8COMObject
    {
        public СпособыРасчетаСебестоимостиПродукции(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПоПеределам => GetProperty<EnumItemBase>("ПоПеределам");
        public EnumItemBase ПоПодразделениям => GetProperty<EnumItemBase>("ПоПодразделениям");
    }
}
