using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ПричиныСовмещения:V1C8COMObject
    {
        public ПричиныСовмещения(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase СовмещениеПрофессийДолжностей => GetProperty<EnumItemBase>();
        public EnumItemBase УвеличениеОбъемаРабот => GetProperty<EnumItemBase>();
        public EnumItemBase ИсполнениеОбязанностей => GetProperty<EnumItemBase>();
    }
}
