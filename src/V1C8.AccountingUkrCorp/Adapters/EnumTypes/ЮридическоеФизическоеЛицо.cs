using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ЮридическоеФизическоеЛицо:EnumBase
    {
        public ЮридическоеФизическоеЛицо(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ЮридическоеЛицо => GetProperty<EnumItem>("ЮридическоеЛицо");
        public EnumItem ФизическоеЛицо => GetProperty<EnumItem>("ФизическоеЛицо");
    }
}
