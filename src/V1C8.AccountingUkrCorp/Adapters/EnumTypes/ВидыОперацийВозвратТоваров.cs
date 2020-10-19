using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОперацийВозвратТоваров:V1C8COMObject
    {
        public ВидыОперацийВозвратТоваров(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ИзПереработки => GetProperty<EnumItemBase>("ИзПереработки");
        public EnumItemBase ОтЗаказчика => GetProperty<EnumItemBase>("ОтЗаказчика");
    }
}
