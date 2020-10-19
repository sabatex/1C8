using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыPOP3Аутентификации:V1C8COMObject
    {
        public СпособыPOP3Аутентификации(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase APOP => GetProperty<EnumItemBase>("APOP");
        public EnumItemBase CramMD5 => GetProperty<EnumItemBase>("CramMD5");
        public EnumItemBase Обычная => GetProperty<EnumItemBase>("Обычная");
    }
}
