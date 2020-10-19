using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class УчетНачисленийВСреднемЗаработкеФСС:EnumBase
    {
        public УчетНачисленийВСреднемЗаработкеФСС(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Включать => GetProperty<EnumItem>("Включать");
        public EnumItem НеВключать => GetProperty<EnumItem>("НеВключать");
    }
}
