using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыРасчетаСебестоимостиПродукции:EnumBase
    {
        public СпособыРасчетаСебестоимостиПродукции(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ПоПеределам => GetProperty<EnumItem>("ПоПеределам");
        public EnumItem ПоПодразделениям => GetProperty<EnumItem>("ПоПодразделениям");
    }
}
