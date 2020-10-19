using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыСобытийОС:V1C8COMObject
    {
        public ВидыСобытийОС(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ВводВЭксплуатацию => GetProperty<EnumItemBase>();
        public EnumItemBase НачислениеАмортизации => GetProperty<EnumItemBase>();
        public EnumItemBase ВнутреннееПеремещение => GetProperty<EnumItemBase>();
        public EnumItemBase ЧастичнаяЛиквидация => GetProperty<EnumItemBase>();
        public EnumItemBase Модернизация => GetProperty<EnumItemBase>();
        public EnumItemBase ПодготовкаКПередаче => GetProperty<EnumItemBase>();
        public EnumItemBase Передача => GetProperty<EnumItemBase>();
        public EnumItemBase Списание => GetProperty<EnumItemBase>();
        public EnumItemBase Прочее => GetProperty<EnumItemBase>();
        public EnumItemBase Ремонт => GetProperty<EnumItemBase>();
    }
}
