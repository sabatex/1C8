using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыРаботСДосрочнойПенсией:EnumBase
    {
        public ВидыРаботСДосрочнойПенсией(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ПодземныеИВредныеРаботы => GetProperty<EnumItem>("ПодземныеИВредныеРаботы");
        public EnumItem ТяжелыеИПрочиеРаботы => GetProperty<EnumItem>("ТяжелыеИПрочиеРаботы");
    }
}
