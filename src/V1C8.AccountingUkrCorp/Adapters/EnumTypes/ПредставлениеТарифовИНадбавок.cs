using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ПредставлениеТарифовИНадбавок:EnumBase
    {
        public ПредставлениеТарифовИНадбавок(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem МесячныйРазмерВГривнах => GetProperty<EnumItem>("МесячныйРазмерВГривнах");
        public EnumItem ТарифыКоэффициенты => GetProperty<EnumItem>("ТарифыКоэффициенты");
        public EnumItem МесячныйРазмерВГривнахИТарифыКоэффициенты => GetProperty<EnumItem>("МесячныйРазмерВГривнахИТарифыКоэффициенты");
    }
}
