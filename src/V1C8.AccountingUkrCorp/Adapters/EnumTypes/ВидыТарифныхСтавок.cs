using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыТарифныхСтавок:EnumBase
    {
        public ВидыТарифныхСтавок(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem МесячнаяТарифнаяСтавка => GetProperty<EnumItem>("МесячнаяТарифнаяСтавка");
        public EnumItem ЧасоваяТарифнаяСтавка => GetProperty<EnumItem>("ЧасоваяТарифнаяСтавка");
        public EnumItem ДневнаяТарифнаяСтавка => GetProperty<EnumItem>("ДневнаяТарифнаяСтавка");
    }
}
