using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class РежимыСовместимостиРазрешенийДополнительныхОтчетовИОбработок:V1C8COMObject
    {
        public РежимыСовместимостиРазрешенийДополнительныхОтчетовИОбработок(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Версия_2_1_3 => GetProperty<EnumItemBase>();
        public EnumItemBase Версия_2_2_2 => GetProperty<EnumItemBase>();
    }
}
