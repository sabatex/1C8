using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыПределовДоходовНДФЛ:V1C8COMObject
    {
        public ВидыПределовДоходовНДФЛ(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Годовой => GetProperty<EnumItemBase>("Годовой");
        public EnumItemBase Разовый => GetProperty<EnumItemBase>("Разовый");
    }
}
