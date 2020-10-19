using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ПорядокФормированияСправкиОДоходахФизическогоЛица:V1C8COMObject
    {
        public ПорядокФормированияСправкиОДоходахФизическогоЛица(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Сводно => GetProperty<EnumItemBase>("Сводно");
        public EnumItemBase ВРазрезеКодовОКАТО => GetProperty<EnumItemBase>("ВРазрезеКодовОКАТО");
    }
}
