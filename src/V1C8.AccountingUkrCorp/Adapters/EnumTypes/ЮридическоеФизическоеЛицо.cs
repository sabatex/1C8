using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ЮридическоеФизическоеЛицо:V1C8COMObject
    {
        public ЮридическоеФизическоеЛицо(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ЮридическоеЛицо => GetProperty<EnumItemBase>("ЮридическоеЛицо");
        public EnumItemBase ФизическоеЛицо => GetProperty<EnumItemBase>("ФизическоеЛицо");
    }
}
