using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВариантыSMTPАутентификации:EnumBase
    {
        public ВариантыSMTPАутентификации(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem АналогичноPOP3 => GetProperty<EnumItem>("АналогичноPOP3");
        public EnumItem ЗадаетсяПараметрами => GetProperty<EnumItem>("ЗадаетсяПараметрами");
        public EnumItem POP3ПередSMTP => GetProperty<EnumItem>("POP3ПередSMTP");
        public EnumItem НеЗадано => GetProperty<EnumItem>("НеЗадано");
    }
}
