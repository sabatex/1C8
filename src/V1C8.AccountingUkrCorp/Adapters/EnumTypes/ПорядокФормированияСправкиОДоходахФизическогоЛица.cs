using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ПорядокФормированияСправкиОДоходахФизическогоЛица:EnumBase
    {
        public ПорядокФормированияСправкиОДоходахФизическогоЛица(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Сводно => GetProperty<EnumItem>("Сводно");
        public EnumItem ВРазрезеКодовОКАТО => GetProperty<EnumItem>("ВРазрезеКодовОКАТО");
    }
}
