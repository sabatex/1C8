using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыСобытийОС:V1C8COMObject
    {
        public ВидыСобытийОС(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ВводВЭксплуатацию => GetProperty<EnumItemBase>("ВводВЭксплуатацию");
        public EnumItemBase НачислениеАмортизации => GetProperty<EnumItemBase>("НачислениеАмортизации");
        public EnumItemBase ВнутреннееПеремещение => GetProperty<EnumItemBase>("ВнутреннееПеремещение");
        public EnumItemBase ЧастичнаяЛиквидация => GetProperty<EnumItemBase>("ЧастичнаяЛиквидация");
        public EnumItemBase Модернизация => GetProperty<EnumItemBase>("Модернизация");
        public EnumItemBase ПодготовкаКПередаче => GetProperty<EnumItemBase>("ПодготовкаКПередаче");
        public EnumItemBase Передача => GetProperty<EnumItemBase>("Передача");
        public EnumItemBase Списание => GetProperty<EnumItemBase>("Списание");
        public EnumItemBase Прочее => GetProperty<EnumItemBase>("Прочее");
        public EnumItemBase Ремонт => GetProperty<EnumItemBase>("Ремонт");
    }
}
