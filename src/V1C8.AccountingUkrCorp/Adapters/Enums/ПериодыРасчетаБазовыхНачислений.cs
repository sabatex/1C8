using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ПериодыРасчетаБазовыхНачислений:V1C8COMObject
    {
        public ПериодыРасчетаБазовыхНачислений(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ТекущийМесяц => GetProperty<EnumItemBase>();
        public EnumItemBase ПредыдущийМесяц => GetProperty<EnumItemBase>();
        public EnumItemBase ТекущийКвартал => GetProperty<EnumItemBase>();
        public EnumItemBase ПредыдущийКвартал => GetProperty<EnumItemBase>();
        public EnumItemBase ТекущийГод => GetProperty<EnumItemBase>();
        public EnumItemBase ПредыдущийГод => GetProperty<EnumItemBase>();
        public EnumItemBase НесколькоПредыдущихМесяцев => GetProperty<EnumItemBase>();
    }
}
