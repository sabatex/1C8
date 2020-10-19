using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыSMTPАутентификации:V1C8COMObject
    {
        public СпособыSMTPАутентификации(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase CramMD5 => GetProperty<EnumItemBase>("CramMD5");
        public EnumItemBase Login => GetProperty<EnumItemBase>("Login");
        public EnumItemBase Plain => GetProperty<EnumItemBase>("Plain");
        public EnumItemBase БезАутентификации => GetProperty<EnumItemBase>("БезАутентификации");
        public EnumItemBase ПоУмолчанию => GetProperty<EnumItemBase>("ПоУмолчанию");
    }
}
