using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СпособыРасчетаАванса:V1C8COMObject
    {
        public СпособыРасчетаАванса(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ФиксированнойСуммой => GetProperty<EnumItemBase>();
        public EnumItemBase ПроцентомОтТарифа => GetProperty<EnumItemBase>();
        public EnumItemBase РасчетомЗаПервуюПоловинуМесяца => GetProperty<EnumItemBase>();
    }
}
