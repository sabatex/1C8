using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ПериодыВводаДанныхОВремени:V1C8COMObject
    {
        public ПериодыВводаДанныхОВремени(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ТекущийМесяц => GetProperty<EnumItemBase>();
        public EnumItemBase ПерваяПоловинаТекущегоМесяца => GetProperty<EnumItemBase>();
        public EnumItemBase ВтораяПоловинаТекущегоМесяца => GetProperty<EnumItemBase>();
        public EnumItemBase ПрошлыйПериод => GetProperty<EnumItemBase>();
    }
}
