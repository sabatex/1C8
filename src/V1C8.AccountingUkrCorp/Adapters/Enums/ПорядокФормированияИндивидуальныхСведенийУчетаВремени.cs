using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ПорядокФормированияИндивидуальныхСведенийУчетаВремени:V1C8COMObject
    {
        public ПорядокФормированияИндивидуальныхСведенийУчетаВремени(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase НеФормировать => GetProperty<EnumItemBase>();
        public EnumItemBase ФормироватьПоЗарегистрированнымВидамВремени => GetProperty<EnumItemBase>();
        public EnumItemBase ФормироватьПолностью => GetProperty<EnumItemBase>();
    }
}
