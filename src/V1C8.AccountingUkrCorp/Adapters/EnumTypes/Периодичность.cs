using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class Периодичность:V1C8COMObject
    {
        public Периодичность(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase День => GetProperty<EnumItemBase>("День");
        public EnumItemBase Неделя => GetProperty<EnumItemBase>("Неделя");
        public EnumItemBase Месяц => GetProperty<EnumItemBase>("Месяц");
        public EnumItemBase Квартал => GetProperty<EnumItemBase>("Квартал");
        public EnumItemBase Год => GetProperty<EnumItemBase>("Год");
        public EnumItemBase Декада => GetProperty<EnumItemBase>("Декада");
        public EnumItemBase Полугодие => GetProperty<EnumItemBase>("Полугодие");
    }
}
