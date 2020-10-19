using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыРасчетаАванса:V1C8COMObject
    {
        public СпособыРасчетаАванса(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ФиксированнойСуммой => GetProperty<EnumItemBase>("ФиксированнойСуммой");
        public EnumItemBase ПроцентомОтТарифа => GetProperty<EnumItemBase>("ПроцентомОтТарифа");
        public EnumItemBase РасчетомЗаПервуюПоловинуМесяца => GetProperty<EnumItemBase>("РасчетомЗаПервуюПоловинуМесяца");
    }
}
