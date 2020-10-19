using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СпособыАутентификации:V1C8COMObject
    {
        public СпособыАутентификации(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Анонимный => GetProperty<EnumItemBase>();
        public EnumItemBase ОбычнаяПроверка => GetProperty<EnumItemBase>();
    }
}
