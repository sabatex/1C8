using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ПредставлениеТарифовИНадбавок:V1C8COMObject
    {
        public ПредставлениеТарифовИНадбавок(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase МесячныйРазмерВГривнах => GetProperty<EnumItemBase>();
        public EnumItemBase ТарифыКоэффициенты => GetProperty<EnumItemBase>();
        public EnumItemBase МесячныйРазмерВГривнахИТарифыКоэффициенты => GetProperty<EnumItemBase>();
    }
}
