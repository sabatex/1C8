using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыСобытийОС:EnumBase
    {
        public ВидыСобытийОС(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ВводВЭксплуатацию => GetProperty<EnumItem>("ВводВЭксплуатацию");
        public EnumItem НачислениеАмортизации => GetProperty<EnumItem>("НачислениеАмортизации");
        public EnumItem ВнутреннееПеремещение => GetProperty<EnumItem>("ВнутреннееПеремещение");
        public EnumItem ЧастичнаяЛиквидация => GetProperty<EnumItem>("ЧастичнаяЛиквидация");
        public EnumItem Модернизация => GetProperty<EnumItem>("Модернизация");
        public EnumItem ПодготовкаКПередаче => GetProperty<EnumItem>("ПодготовкаКПередаче");
        public EnumItem Передача => GetProperty<EnumItem>("Передача");
        public EnumItem Списание => GetProperty<EnumItem>("Списание");
        public EnumItem Прочее => GetProperty<EnumItem>("Прочее");
        public EnumItem Ремонт => GetProperty<EnumItem>("Ремонт");
    }
}
