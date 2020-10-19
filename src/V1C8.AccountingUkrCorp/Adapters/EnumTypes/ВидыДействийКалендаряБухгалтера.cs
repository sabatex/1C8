using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыДействийКалендаряБухгалтера:V1C8COMObject
    {
        public ВидыДействийКалендаряБухгалтера(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Отчет => GetProperty<EnumItemBase>("Отчет");
        public EnumItemBase УплатаНалога => GetProperty<EnumItemBase>("УплатаНалога");
    }
}
