using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыНазначенияДатЗапрета:V1C8COMObject
    {
        public ВидыНазначенияДатЗапрета(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ДляВсехПользователей => GetProperty<EnumItemBase>("ДляВсехПользователей");
        public EnumItemBase ДляВсехИнформационныхБаз => GetProperty<EnumItemBase>("ДляВсехИнформационныхБаз");
    }
}
