using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class РежимыСовместимостиРазрешенийДополнительныхОтчетовИОбработок:EnumBase
    {
        public РежимыСовместимостиРазрешенийДополнительныхОтчетовИОбработок(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Версия_2_1_3 => GetProperty<EnumItem>("Версия_2_1_3");
        public EnumItem Версия_2_2_2 => GetProperty<EnumItem>("Версия_2_2_2");
    }
}
