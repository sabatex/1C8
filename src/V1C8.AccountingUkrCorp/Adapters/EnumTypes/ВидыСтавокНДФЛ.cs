using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыСтавокНДФЛ:EnumBase
    {
        public ВидыСтавокНДФЛ(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Уменьшенная => GetProperty<EnumItem>("Уменьшенная");
        public EnumItem Основная => GetProperty<EnumItem>("Основная");
        public EnumItem Двойная => GetProperty<EnumItem>("Двойная");
        public EnumItem НеОблагается => GetProperty<EnumItem>("НеОблагается");
        public EnumItem СтавкаШахтеров => GetProperty<EnumItem>("СтавкаШахтеров");
        public EnumItem Увеличенная => GetProperty<EnumItem>("Увеличенная");
        public EnumItem ВоенныйСбор => GetProperty<EnumItem>("ВоенныйСбор");
    }
}
