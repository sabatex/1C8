using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ПричиныСовмещения:EnumBase
    {
        public ПричиныСовмещения(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem СовмещениеПрофессийДолжностей => GetProperty<EnumItem>("СовмещениеПрофессийДолжностей");
        public EnumItem УвеличениеОбъемаРабот => GetProperty<EnumItem>("УвеличениеОбъемаРабот");
        public EnumItem ИсполнениеОбязанностей => GetProperty<EnumItem>("ИсполнениеОбязанностей");
    }
}
