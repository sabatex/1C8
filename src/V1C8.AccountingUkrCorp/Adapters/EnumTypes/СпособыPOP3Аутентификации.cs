using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыPOP3Аутентификации:EnumBase
    {
        public СпособыPOP3Аутентификации(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem APOP => GetProperty<EnumItem>("APOP");
        public EnumItem CramMD5 => GetProperty<EnumItem>("CramMD5");
        public EnumItem Обычная => GetProperty<EnumItem>("Обычная");
    }
}
