using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыТарифныхСеток:V1C8COMObject
    {
        public ВидыТарифныхСеток(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Тариф => GetProperty<EnumItemBase>("Тариф");
        public EnumItemBase Надбавка => GetProperty<EnumItemBase>("Надбавка");
    }
}
