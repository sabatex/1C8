using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыКонтактныхЛиц:V1C8COMObject
    {
        public ВидыКонтактныхЛиц(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase КонтактноеЛицоКонтрагента => GetProperty<EnumItemBase>();
        public EnumItemBase ПрочееКонтактноеЛицо => GetProperty<EnumItemBase>();
        public EnumItemBase ЛичныйКонтакт => GetProperty<EnumItemBase>();
    }
}
