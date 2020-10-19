using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ФормыОбучения:V1C8COMObject
    {
        public ФормыОбучения(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Очная => GetProperty<EnumItemBase>();
        public EnumItemBase Заочная => GetProperty<EnumItemBase>();
        public EnumItemBase Вечерняя => GetProperty<EnumItemBase>();
        public EnumItemBase Экстернат => GetProperty<EnumItemBase>();
        public EnumItemBase Прочее => GetProperty<EnumItemBase>();
    }
}
