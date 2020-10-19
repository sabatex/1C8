using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class РолиСотрудников:V1C8COMObject
    {
        public РолиСотрудников(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Работник => GetProperty<EnumItemBase>();
        public EnumItemBase Договорник => GetProperty<EnumItemBase>();
    }
}
