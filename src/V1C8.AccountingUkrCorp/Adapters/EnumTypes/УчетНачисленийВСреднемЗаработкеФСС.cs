using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class УчетНачисленийВСреднемЗаработкеФСС:V1C8COMObject
    {
        public УчетНачисленийВСреднемЗаработкеФСС(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Включать => GetProperty<EnumItemBase>("Включать");
        public EnumItemBase НеВключать => GetProperty<EnumItemBase>("НеВключать");
    }
}
