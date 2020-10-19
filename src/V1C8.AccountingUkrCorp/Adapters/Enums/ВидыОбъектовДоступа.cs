using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыОбъектовДоступа:V1C8COMObject
    {
        public ВидыОбъектовДоступа(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Организации => GetProperty<EnumItemBase>();
        public EnumItemBase ВнешниеОбработки => GetProperty<EnumItemBase>();
    }
}
