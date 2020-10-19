using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыТарифныхСеток:EnumBase
    {
        public ВидыТарифныхСеток(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Тариф => GetProperty<EnumItem>("Тариф");
        public EnumItem Надбавка => GetProperty<EnumItem>("Надбавка");
    }
}
