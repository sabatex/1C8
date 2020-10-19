using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыРаботСДосрочнойПенсией:V1C8COMObject
    {
        public ВидыРаботСДосрочнойПенсией(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПодземныеИВредныеРаботы => GetProperty<EnumItemBase>("ПодземныеИВредныеРаботы");
        public EnumItemBase ТяжелыеИПрочиеРаботы => GetProperty<EnumItemBase>("ТяжелыеИПрочиеРаботы");
    }
}
