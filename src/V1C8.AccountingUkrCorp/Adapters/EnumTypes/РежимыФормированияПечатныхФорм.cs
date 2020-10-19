using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class РежимыФормированияПечатныхФорм:V1C8COMObject
    {
        public РежимыФормированияПечатныхФорм(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase НаЯзыкеИнформационнойБазы => GetProperty<EnumItemBase>("НаЯзыкеИнформационнойБазы");
        public EnumItemBase НаЯзыкеИнтерфейсаПользователя => GetProperty<EnumItemBase>("НаЯзыкеИнтерфейсаПользователя");
        public EnumItemBase НаРусскомЯзыке => GetProperty<EnumItemBase>("НаРусскомЯзыке");
        public EnumItemBase НаУкраинскомЯзыке => GetProperty<EnumItemBase>("НаУкраинскомЯзыке");
    }
}
