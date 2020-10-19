using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыСтавокНДФЛ:V1C8COMObject
    {
        public ВидыСтавокНДФЛ(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Уменьшенная => GetProperty<EnumItemBase>("Уменьшенная");
        public EnumItemBase Основная => GetProperty<EnumItemBase>("Основная");
        public EnumItemBase Двойная => GetProperty<EnumItemBase>("Двойная");
        public EnumItemBase НеОблагается => GetProperty<EnumItemBase>("НеОблагается");
        public EnumItemBase СтавкаШахтеров => GetProperty<EnumItemBase>("СтавкаШахтеров");
        public EnumItemBase Увеличенная => GetProperty<EnumItemBase>("Увеличенная");
        public EnumItemBase ВоенныйСбор => GetProperty<EnumItemBase>("ВоенныйСбор");
    }
}
