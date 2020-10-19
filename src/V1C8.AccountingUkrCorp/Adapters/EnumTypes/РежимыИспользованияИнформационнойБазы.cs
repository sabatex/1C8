using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class РежимыИспользованияИнформационнойБазы:EnumBase
    {
        public РежимыИспользованияИнформационнойБазы(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Рабочий => GetProperty<EnumItem>("Рабочий");
        public EnumItem Демонстрационный => GetProperty<EnumItem>("Демонстрационный");
    }
}
