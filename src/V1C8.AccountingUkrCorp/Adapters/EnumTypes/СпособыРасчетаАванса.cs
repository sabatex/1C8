using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыРасчетаАванса:EnumBase
    {
        public СпособыРасчетаАванса(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ФиксированнойСуммой => GetProperty<EnumItem>("ФиксированнойСуммой");
        public EnumItem ПроцентомОтТарифа => GetProperty<EnumItem>("ПроцентомОтТарифа");
        public EnumItem РасчетомЗаПервуюПоловинуМесяца => GetProperty<EnumItem>("РасчетомЗаПервуюПоловинуМесяца");
    }
}
