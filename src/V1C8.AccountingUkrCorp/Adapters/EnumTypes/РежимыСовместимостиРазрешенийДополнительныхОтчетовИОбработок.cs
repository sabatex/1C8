using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class РежимыСовместимостиРазрешенийДополнительныхОтчетовИОбработок:V1C8COMObject
    {
        public РежимыСовместимостиРазрешенийДополнительныхОтчетовИОбработок(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Версия_2_1_3 => GetProperty<EnumItemBase>("Версия_2_1_3");
        public EnumItemBase Версия_2_2_2 => GetProperty<EnumItemBase>("Версия_2_2_2");
    }
}
