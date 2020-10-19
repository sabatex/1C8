using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class РасчетыВозврат:EnumBase
    {
        public РасчетыВозврат(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Расчеты => GetProperty<EnumItem>("Расчеты");
        public EnumItem Возврат => GetProperty<EnumItem>("Возврат");
    }
}
