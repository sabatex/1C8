using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ПорядокФормированияИндивидуальныхСведенийУчетаВремени:V1C8COMObject
    {
        public ПорядокФормированияИндивидуальныхСведенийУчетаВремени(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase НеФормировать => GetProperty<EnumItemBase>("НеФормировать");
        public EnumItemBase ФормироватьПоЗарегистрированнымВидамВремени => GetProperty<EnumItemBase>("ФормироватьПоЗарегистрированнымВидамВремени");
        public EnumItemBase ФормироватьПолностью => GetProperty<EnumItemBase>("ФормироватьПолностью");
    }
}
