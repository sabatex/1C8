using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class РежимыФормированияПечатныхФорм:V1C8COMObject
    {
        public РежимыФормированияПечатныхФорм(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase НаЯзыкеИнформационнойБазы => GetProperty<EnumItemBase>();
        public EnumItemBase НаЯзыкеИнтерфейсаПользователя => GetProperty<EnumItemBase>();
        public EnumItemBase НаРусскомЯзыке => GetProperty<EnumItemBase>();
        public EnumItemBase НаУкраинскомЯзыке => GetProperty<EnumItemBase>();
    }
}
