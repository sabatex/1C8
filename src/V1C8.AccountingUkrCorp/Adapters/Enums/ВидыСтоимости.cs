using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыСтоимости:V1C8COMObject
    {
        public ВидыСтоимости(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Фактическая => GetProperty<EnumItemBase>();
        public EnumItemBase Плановая => GetProperty<EnumItemBase>();
        public EnumItemBase Отклонение => GetProperty<EnumItemBase>();
    }
}
