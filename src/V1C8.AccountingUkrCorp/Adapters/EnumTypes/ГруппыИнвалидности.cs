using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ГруппыИнвалидности:V1C8COMObject
    {
        public ГруппыИнвалидности(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПерваяГруппа => GetProperty<EnumItemBase>("ПерваяГруппа");
        public EnumItemBase ВтораяГруппа => GetProperty<EnumItemBase>("ВтораяГруппа");
        public EnumItemBase ТретьяГруппа => GetProperty<EnumItemBase>("ТретьяГруппа");
    }
}
