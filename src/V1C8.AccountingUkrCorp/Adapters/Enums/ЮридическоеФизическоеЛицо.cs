using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ЮридическоеФизическоеЛицо:V1C8COMObject
    {
        public ЮридическоеФизическоеЛицо(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ЮридическоеЛицо => GetProperty<EnumItemBase>();
        public EnumItemBase ФизическоеЛицо => GetProperty<EnumItemBase>();
    }
}
