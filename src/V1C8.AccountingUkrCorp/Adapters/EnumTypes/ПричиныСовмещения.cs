using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ПричиныСовмещения:V1C8COMObject
    {
        public ПричиныСовмещения(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase СовмещениеПрофессийДолжностей => GetProperty<EnumItemBase>("СовмещениеПрофессийДолжностей");
        public EnumItemBase УвеличениеОбъемаРабот => GetProperty<EnumItemBase>("УвеличениеОбъемаРабот");
        public EnumItemBase ИсполнениеОбязанностей => GetProperty<EnumItemBase>("ИсполнениеОбязанностей");
    }
}
