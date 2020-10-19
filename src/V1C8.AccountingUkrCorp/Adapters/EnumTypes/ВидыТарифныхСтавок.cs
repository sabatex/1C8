using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыТарифныхСтавок:V1C8COMObject
    {
        public ВидыТарифныхСтавок(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase МесячнаяТарифнаяСтавка => GetProperty<EnumItemBase>("МесячнаяТарифнаяСтавка");
        public EnumItemBase ЧасоваяТарифнаяСтавка => GetProperty<EnumItemBase>("ЧасоваяТарифнаяСтавка");
        public EnumItemBase ДневнаяТарифнаяСтавка => GetProperty<EnumItemBase>("ДневнаяТарифнаяСтавка");
    }
}
