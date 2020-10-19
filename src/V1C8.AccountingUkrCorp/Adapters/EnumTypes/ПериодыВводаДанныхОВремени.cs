using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ПериодыВводаДанныхОВремени:V1C8COMObject
    {
        public ПериодыВводаДанныхОВремени(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ТекущийМесяц => GetProperty<EnumItemBase>("ТекущийМесяц");
        public EnumItemBase ПерваяПоловинаТекущегоМесяца => GetProperty<EnumItemBase>("ПерваяПоловинаТекущегоМесяца");
        public EnumItemBase ВтораяПоловинаТекущегоМесяца => GetProperty<EnumItemBase>("ВтораяПоловинаТекущегоМесяца");
        public EnumItemBase ПрошлыйПериод => GetProperty<EnumItemBase>("ПрошлыйПериод");
    }
}
