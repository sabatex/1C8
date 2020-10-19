using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ПрофилиОфицеров:V1C8COMObject
    {
        public ПрофилиОфицеров(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Командный => GetProperty<EnumItemBase>();
        public EnumItemBase Инженерный => GetProperty<EnumItemBase>();
        public EnumItemBase Технический => GetProperty<EnumItemBase>();
        public EnumItemBase Юридический => GetProperty<EnumItemBase>();
        public EnumItemBase Медицинский => GetProperty<EnumItemBase>();
        public EnumItemBase Ветеринарный => GetProperty<EnumItemBase>();
        public EnumItemBase Оперативный => GetProperty<EnumItemBase>();
        public EnumItemBase Административный => GetProperty<EnumItemBase>();
        public EnumItemBase ОперативноТехнический => GetProperty<EnumItemBase>();
    }
}
