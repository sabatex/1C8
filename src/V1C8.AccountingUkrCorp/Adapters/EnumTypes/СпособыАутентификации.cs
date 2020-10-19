using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыАутентификации:V1C8COMObject
    {
        public СпособыАутентификации(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Анонимный => GetProperty<EnumItemBase>("Анонимный");
        public EnumItemBase ОбычнаяПроверка => GetProperty<EnumItemBase>("ОбычнаяПроверка");
    }
}
