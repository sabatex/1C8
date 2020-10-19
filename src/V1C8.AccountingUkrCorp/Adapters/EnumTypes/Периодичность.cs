using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class Периодичность:EnumBase
    {
        public Периодичность(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem День => GetProperty<EnumItem>("День");
        public EnumItem Неделя => GetProperty<EnumItem>("Неделя");
        public EnumItem Месяц => GetProperty<EnumItem>("Месяц");
        public EnumItem Квартал => GetProperty<EnumItem>("Квартал");
        public EnumItem Год => GetProperty<EnumItem>("Год");
        public EnumItem Декада => GetProperty<EnumItem>("Декада");
        public EnumItem Полугодие => GetProperty<EnumItem>("Полугодие");
    }
}
