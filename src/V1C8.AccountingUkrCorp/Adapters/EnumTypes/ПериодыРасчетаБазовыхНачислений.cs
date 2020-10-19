using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ПериодыРасчетаБазовыхНачислений:EnumBase
    {
        public ПериодыРасчетаБазовыхНачислений(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ТекущийМесяц => GetProperty<EnumItem>("ТекущийМесяц");
        public EnumItem ПредыдущийМесяц => GetProperty<EnumItem>("ПредыдущийМесяц");
        public EnumItem ТекущийКвартал => GetProperty<EnumItem>("ТекущийКвартал");
        public EnumItem ПредыдущийКвартал => GetProperty<EnumItem>("ПредыдущийКвартал");
        public EnumItem ТекущийГод => GetProperty<EnumItem>("ТекущийГод");
        public EnumItem ПредыдущийГод => GetProperty<EnumItem>("ПредыдущийГод");
        public EnumItem НесколькоПредыдущихМесяцев => GetProperty<EnumItem>("НесколькоПредыдущихМесяцев");
    }
}
