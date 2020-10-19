using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыСтоимости:EnumBase
    {
        public ВидыСтоимости(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Фактическая => GetProperty<EnumItem>("Фактическая");
        public EnumItem Плановая => GetProperty<EnumItem>("Плановая");
        public EnumItem Отклонение => GetProperty<EnumItem>("Отклонение");
    }
}
