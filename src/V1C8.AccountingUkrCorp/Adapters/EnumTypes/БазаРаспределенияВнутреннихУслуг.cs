using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class БазаРаспределенияВнутреннихУслуг:EnumBase
    {
        public БазаРаспределенияВнутреннихУслуг(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ПлановаяСебестоимость => GetProperty<EnumItem>("ПлановаяСебестоимость");
        public EnumItem НатуральныеПоказатели => GetProperty<EnumItem>("НатуральныеПоказатели");
    }
}
