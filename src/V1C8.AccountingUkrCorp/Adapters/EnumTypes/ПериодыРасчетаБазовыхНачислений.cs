using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ПериодыРасчетаБазовыхНачислений:V1C8COMObject
    {
        public ПериодыРасчетаБазовыхНачислений(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ТекущийМесяц => GetProperty<EnumItemBase>("ТекущийМесяц");
        public EnumItemBase ПредыдущийМесяц => GetProperty<EnumItemBase>("ПредыдущийМесяц");
        public EnumItemBase ТекущийКвартал => GetProperty<EnumItemBase>("ТекущийКвартал");
        public EnumItemBase ПредыдущийКвартал => GetProperty<EnumItemBase>("ПредыдущийКвартал");
        public EnumItemBase ТекущийГод => GetProperty<EnumItemBase>("ТекущийГод");
        public EnumItemBase ПредыдущийГод => GetProperty<EnumItemBase>("ПредыдущийГод");
        public EnumItemBase НесколькоПредыдущихМесяцев => GetProperty<EnumItemBase>("НесколькоПредыдущихМесяцев");
    }
}
