using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СпособыSMTPАутентификации:V1C8COMObject
    {
        public СпособыSMTPАутентификации(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase CramMD5 => GetProperty<EnumItemBase>();
        public EnumItemBase Login => GetProperty<EnumItemBase>();
        public EnumItemBase Plain => GetProperty<EnumItemBase>();
        public EnumItemBase БезАутентификации => GetProperty<EnumItemBase>();
        public EnumItemBase ПоУмолчанию => GetProperty<EnumItemBase>();
    }
}
