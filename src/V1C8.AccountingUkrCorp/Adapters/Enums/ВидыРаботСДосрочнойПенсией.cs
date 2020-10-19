using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыРаботСДосрочнойПенсией:V1C8COMObject
    {
        public ВидыРаботСДосрочнойПенсией(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПодземныеИВредныеРаботы => GetProperty<EnumItemBase>();
        public EnumItemBase ТяжелыеИПрочиеРаботы => GetProperty<EnumItemBase>();
    }
}
