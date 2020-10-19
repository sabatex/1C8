using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ФормыОбучения:EnumBase
    {
        public ФормыОбучения(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Очная => GetProperty<EnumItem>("Очная");
        public EnumItem Заочная => GetProperty<EnumItem>("Заочная");
        public EnumItem Вечерняя => GetProperty<EnumItem>("Вечерняя");
        public EnumItem Экстернат => GetProperty<EnumItem>("Экстернат");
        public EnumItem Прочее => GetProperty<EnumItem>("Прочее");
    }
}
