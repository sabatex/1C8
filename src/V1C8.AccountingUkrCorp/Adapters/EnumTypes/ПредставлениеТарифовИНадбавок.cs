using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ПредставлениеТарифовИНадбавок:V1C8COMObject
    {
        public ПредставлениеТарифовИНадбавок(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase МесячныйРазмерВГривнах => GetProperty<EnumItemBase>("МесячныйРазмерВГривнах");
        public EnumItemBase ТарифыКоэффициенты => GetProperty<EnumItemBase>("ТарифыКоэффициенты");
        public EnumItemBase МесячныйРазмерВГривнахИТарифыКоэффициенты => GetProperty<EnumItemBase>("МесячныйРазмерВГривнахИТарифыКоэффициенты");
    }
}
