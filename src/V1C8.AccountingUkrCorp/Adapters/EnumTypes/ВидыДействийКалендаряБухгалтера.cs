using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыДействийКалендаряБухгалтера:EnumBase
    {
        public ВидыДействийКалендаряБухгалтера(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Отчет => GetProperty<EnumItem>("Отчет");
        public EnumItem УплатаНалога => GetProperty<EnumItem>("УплатаНалога");
    }
}
