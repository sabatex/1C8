using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОбъектовДоступа:V1C8COMObject
    {
        public ВидыОбъектовДоступа(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Организации => GetProperty<EnumItemBase>("Организации");
        public EnumItemBase ВнешниеОбработки => GetProperty<EnumItemBase>("ВнешниеОбработки");
    }
}
