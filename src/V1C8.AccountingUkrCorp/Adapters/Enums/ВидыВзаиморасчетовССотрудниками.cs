using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыВзаиморасчетовССотрудниками:V1C8COMObject
    {
        public ВидыВзаиморасчетовССотрудниками(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ВыплатаАванса => GetProperty<EnumItemBase>();
        public EnumItemBase ВыплатаЗарплаты => GetProperty<EnumItemBase>();
        public EnumItemBase ВыплатаВМежрасчетныйПериод => GetProperty<EnumItemBase>();
        public EnumItemBase ПогашениеЗадолженностиПоЗарплате => GetProperty<EnumItemBase>();
        public EnumItemBase ВнеочередноеПогашениеЗайма => GetProperty<EnumItemBase>();
        public EnumItemBase ПереносЗадолженности => GetProperty<EnumItemBase>();
        public EnumItemBase НачальнаяЗадолженность => GetProperty<EnumItemBase>();
    }
}
