using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВариантыSMTPАутентификации:V1C8COMObject
    {
        public ВариантыSMTPАутентификации(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase АналогичноPOP3 => GetProperty<EnumItemBase>();
        public EnumItemBase ЗадаетсяПараметрами => GetProperty<EnumItemBase>();
        public EnumItemBase POP3ПередSMTP => GetProperty<EnumItemBase>();
        public EnumItemBase НеЗадано => GetProperty<EnumItemBase>();
    }
}
