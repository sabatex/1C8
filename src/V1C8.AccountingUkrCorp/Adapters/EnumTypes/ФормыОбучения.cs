using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ФормыОбучения:V1C8COMObject
    {
        public ФормыОбучения(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Очная => GetProperty<EnumItemBase>("Очная");
        public EnumItemBase Заочная => GetProperty<EnumItemBase>("Заочная");
        public EnumItemBase Вечерняя => GetProperty<EnumItemBase>("Вечерняя");
        public EnumItemBase Экстернат => GetProperty<EnumItemBase>("Экстернат");
        public EnumItemBase Прочее => GetProperty<EnumItemBase>("Прочее");
    }
}
