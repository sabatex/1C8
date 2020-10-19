using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class РежимыИспользованияИнформационнойБазы:V1C8COMObject
    {
        public РежимыИспользованияИнформационнойБазы(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Рабочий => GetProperty<EnumItemBase>();
        public EnumItemBase Демонстрационный => GetProperty<EnumItemBase>();
    }
}
