using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыSMTPАутентификации:EnumBase
    {
        public СпособыSMTPАутентификации(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem CramMD5 => GetProperty<EnumItem>("CramMD5");
        public EnumItem Login => GetProperty<EnumItem>("Login");
        public EnumItem Plain => GetProperty<EnumItem>("Plain");
        public EnumItem БезАутентификации => GetProperty<EnumItem>("БезАутентификации");
        public EnumItem ПоУмолчанию => GetProperty<EnumItem>("ПоУмолчанию");
    }
}
