using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыОперацийКорректировкаДолга:V1C8COMObject
    {
        public ВидыОперацийКорректировкаДолга(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПереносЗадолженности => GetProperty<EnumItemBase>();
        public EnumItemBase СписаниеЗадолженности => GetProperty<EnumItemBase>();
        public EnumItemBase ИзменениеЗадолженности => GetProperty<EnumItemBase>();
        public EnumItemBase ПроведениеВзаимозачета => GetProperty<EnumItemBase>();
        public EnumItemBase ВводНачальныхОстатков => GetProperty<EnumItemBase>();
    }
}
