using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class БазаРаспределенияВнутреннихУслуг:V1C8COMObject
    {
        public БазаРаспределенияВнутреннихУслуг(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПлановаяСебестоимость => GetProperty<EnumItemBase>("ПлановаяСебестоимость");
        public EnumItemBase НатуральныеПоказатели => GetProperty<EnumItemBase>("НатуральныеПоказатели");
    }
}
