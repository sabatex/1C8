using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОперацийКорректировкаДолга:EnumBase
    {
        public ВидыОперацийКорректировкаДолга(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ПереносЗадолженности => GetProperty<EnumItem>("ПереносЗадолженности");
        public EnumItem СписаниеЗадолженности => GetProperty<EnumItem>("СписаниеЗадолженности");
        public EnumItem ИзменениеЗадолженности => GetProperty<EnumItem>("ИзменениеЗадолженности");
        public EnumItem ПроведениеВзаимозачета => GetProperty<EnumItem>("ПроведениеВзаимозачета");
        public EnumItem ВводНачальныхОстатков => GetProperty<EnumItem>("ВводНачальныхОстатков");
    }
}
