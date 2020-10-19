using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыВзаиморасчетовССотрудниками:V1C8COMObject
    {
        public ВидыВзаиморасчетовССотрудниками(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ВыплатаАванса => GetProperty<EnumItemBase>("ВыплатаАванса");
        public EnumItemBase ВыплатаЗарплаты => GetProperty<EnumItemBase>("ВыплатаЗарплаты");
        public EnumItemBase ВыплатаВМежрасчетныйПериод => GetProperty<EnumItemBase>("ВыплатаВМежрасчетныйПериод");
        public EnumItemBase ПогашениеЗадолженностиПоЗарплате => GetProperty<EnumItemBase>("ПогашениеЗадолженностиПоЗарплате");
        public EnumItemBase ВнеочередноеПогашениеЗайма => GetProperty<EnumItemBase>("ВнеочередноеПогашениеЗайма");
        public EnumItemBase ПереносЗадолженности => GetProperty<EnumItemBase>("ПереносЗадолженности");
        public EnumItemBase НачальнаяЗадолженность => GetProperty<EnumItemBase>("НачальнаяЗадолженность");
    }
}
