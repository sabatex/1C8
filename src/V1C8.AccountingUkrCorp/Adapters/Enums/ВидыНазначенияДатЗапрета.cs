using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыНазначенияДатЗапрета:V1C8COMObject
    {
        public ВидыНазначенияДатЗапрета(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ДляВсехПользователей => GetProperty<EnumItemBase>();
        public EnumItemBase ДляВсехИнформационныхБаз => GetProperty<EnumItemBase>();
    }
}
