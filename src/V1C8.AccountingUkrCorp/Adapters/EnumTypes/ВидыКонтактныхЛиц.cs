using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыКонтактныхЛиц:EnumBase
    {
        public ВидыКонтактныхЛиц(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem КонтактноеЛицоКонтрагента => GetProperty<EnumItem>("КонтактноеЛицоКонтрагента");
        public EnumItem ПрочееКонтактноеЛицо => GetProperty<EnumItem>("ПрочееКонтактноеЛицо");
        public EnumItem ЛичныйКонтакт => GetProperty<EnumItem>("ЛичныйКонтакт");
    }
}
