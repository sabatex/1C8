using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыТарифныхСтавок:V1C8COMObject
    {
        public ВидыТарифныхСтавок(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase МесячнаяТарифнаяСтавка => GetProperty<EnumItemBase>();
        public EnumItemBase ЧасоваяТарифнаяСтавка => GetProperty<EnumItemBase>();
        public EnumItemBase ДневнаяТарифнаяСтавка => GetProperty<EnumItemBase>();
    }
}
