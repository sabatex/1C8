using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыСтавокНДФЛ:V1C8COMObject
    {
        public ВидыСтавокНДФЛ(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Уменьшенная => GetProperty<EnumItemBase>();
        public EnumItemBase Основная => GetProperty<EnumItemBase>();
        public EnumItemBase Двойная => GetProperty<EnumItemBase>();
        public EnumItemBase НеОблагается => GetProperty<EnumItemBase>();
        public EnumItemBase СтавкаШахтеров => GetProperty<EnumItemBase>();
        public EnumItemBase Увеличенная => GetProperty<EnumItemBase>();
        public EnumItemBase ВоенныйСбор => GetProperty<EnumItemBase>();
    }
}
