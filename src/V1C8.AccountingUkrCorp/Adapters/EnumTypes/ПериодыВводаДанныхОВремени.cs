using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ПериодыВводаДанныхОВремени:EnumBase
    {
        public ПериодыВводаДанныхОВремени(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ТекущийМесяц => GetProperty<EnumItem>("ТекущийМесяц");
        public EnumItem ПерваяПоловинаТекущегоМесяца => GetProperty<EnumItem>("ПерваяПоловинаТекущегоМесяца");
        public EnumItem ВтораяПоловинаТекущегоМесяца => GetProperty<EnumItem>("ВтораяПоловинаТекущегоМесяца");
        public EnumItem ПрошлыйПериод => GetProperty<EnumItem>("ПрошлыйПериод");
    }
}
