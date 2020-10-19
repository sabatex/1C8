using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВариантыSMTPАутентификации:V1C8COMObject
    {
        public ВариантыSMTPАутентификации(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase АналогичноPOP3 => GetProperty<EnumItemBase>("АналогичноPOP3");
        public EnumItemBase ЗадаетсяПараметрами => GetProperty<EnumItemBase>("ЗадаетсяПараметрами");
        public EnumItemBase POP3ПередSMTP => GetProperty<EnumItemBase>("POP3ПередSMTP");
        public EnumItemBase НеЗадано => GetProperty<EnumItemBase>("НеЗадано");
    }
}
