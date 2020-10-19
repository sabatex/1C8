using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ПрофилиОфицеров:EnumBase
    {
        public ПрофилиОфицеров(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Командный => GetProperty<EnumItem>("Командный");
        public EnumItem Инженерный => GetProperty<EnumItem>("Инженерный");
        public EnumItem Технический => GetProperty<EnumItem>("Технический");
        public EnumItem Юридический => GetProperty<EnumItem>("Юридический");
        public EnumItem Медицинский => GetProperty<EnumItem>("Медицинский");
        public EnumItem Ветеринарный => GetProperty<EnumItem>("Ветеринарный");
        public EnumItem Оперативный => GetProperty<EnumItem>("Оперативный");
        public EnumItem Административный => GetProperty<EnumItem>("Административный");
        public EnumItem ОперативноТехнический => GetProperty<EnumItem>("ОперативноТехнический");
    }
}
