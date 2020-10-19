using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class БазаРаспределенияВнутреннихУслуг:V1C8COMObject
    {
        public БазаРаспределенияВнутреннихУслуг(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПлановаяСебестоимость => GetProperty<EnumItemBase>();
        public EnumItemBase НатуральныеПоказатели => GetProperty<EnumItemBase>();
    }
}
