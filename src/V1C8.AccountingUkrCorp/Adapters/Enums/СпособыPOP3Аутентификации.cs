using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СпособыPOP3Аутентификации:V1C8COMObject
    {
        public СпособыPOP3Аутентификации(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase APOP => GetProperty<EnumItemBase>();
        public EnumItemBase CramMD5 => GetProperty<EnumItemBase>();
        public EnumItemBase Обычная => GetProperty<EnumItemBase>();
    }
}
