using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class РежимыИспользованияИнформационнойБазы:V1C8COMObject
    {
        public РежимыИспользованияИнформационнойБазы(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Рабочий => GetProperty<EnumItemBase>("Рабочий");
        public EnumItemBase Демонстрационный => GetProperty<EnumItemBase>("Демонстрационный");
    }
}
