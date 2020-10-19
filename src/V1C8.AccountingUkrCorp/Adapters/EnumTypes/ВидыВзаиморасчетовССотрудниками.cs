using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыВзаиморасчетовССотрудниками:EnumBase
    {
        public ВидыВзаиморасчетовССотрудниками(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ВыплатаАванса => GetProperty<EnumItem>("ВыплатаАванса");
        public EnumItem ВыплатаЗарплаты => GetProperty<EnumItem>("ВыплатаЗарплаты");
        public EnumItem ВыплатаВМежрасчетныйПериод => GetProperty<EnumItem>("ВыплатаВМежрасчетныйПериод");
        public EnumItem ПогашениеЗадолженностиПоЗарплате => GetProperty<EnumItem>("ПогашениеЗадолженностиПоЗарплате");
        public EnumItem ВнеочередноеПогашениеЗайма => GetProperty<EnumItem>("ВнеочередноеПогашениеЗайма");
        public EnumItem ПереносЗадолженности => GetProperty<EnumItem>("ПереносЗадолженности");
        public EnumItem НачальнаяЗадолженность => GetProperty<EnumItem>("НачальнаяЗадолженность");
    }
}
