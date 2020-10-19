using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыКонтактныхЛиц:V1C8COMObject
    {
        public ВидыКонтактныхЛиц(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase КонтактноеЛицоКонтрагента => GetProperty<EnumItemBase>("КонтактноеЛицоКонтрагента");
        public EnumItemBase ПрочееКонтактноеЛицо => GetProperty<EnumItemBase>("ПрочееКонтактноеЛицо");
        public EnumItemBase ЛичныйКонтакт => GetProperty<EnumItemBase>("ЛичныйКонтакт");
    }
}
