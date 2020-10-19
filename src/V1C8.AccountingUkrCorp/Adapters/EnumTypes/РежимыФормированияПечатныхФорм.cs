using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class РежимыФормированияПечатныхФорм:EnumBase
    {
        public РежимыФормированияПечатныхФорм(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem НаЯзыкеИнформационнойБазы => GetProperty<EnumItem>("НаЯзыкеИнформационнойБазы");
        public EnumItem НаЯзыкеИнтерфейсаПользователя => GetProperty<EnumItem>("НаЯзыкеИнтерфейсаПользователя");
        public EnumItem НаРусскомЯзыке => GetProperty<EnumItem>("НаРусскомЯзыке");
        public EnumItem НаУкраинскомЯзыке => GetProperty<EnumItem>("НаУкраинскомЯзыке");
    }
}
