using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ПрофилиОфицеров:V1C8COMObject
    {
        public ПрофилиОфицеров(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Командный => GetProperty<EnumItemBase>("Командный");
        public EnumItemBase Инженерный => GetProperty<EnumItemBase>("Инженерный");
        public EnumItemBase Технический => GetProperty<EnumItemBase>("Технический");
        public EnumItemBase Юридический => GetProperty<EnumItemBase>("Юридический");
        public EnumItemBase Медицинский => GetProperty<EnumItemBase>("Медицинский");
        public EnumItemBase Ветеринарный => GetProperty<EnumItemBase>("Ветеринарный");
        public EnumItemBase Оперативный => GetProperty<EnumItemBase>("Оперативный");
        public EnumItemBase Административный => GetProperty<EnumItemBase>("Административный");
        public EnumItemBase ОперативноТехнический => GetProperty<EnumItemBase>("ОперативноТехнический");
    }
}
