using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class РолиСотрудников:V1C8COMObject
    {
        public РолиСотрудников(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Работник => GetProperty<EnumItemBase>("Работник");
        public EnumItemBase Договорник => GetProperty<EnumItemBase>("Договорник");
    }
}
