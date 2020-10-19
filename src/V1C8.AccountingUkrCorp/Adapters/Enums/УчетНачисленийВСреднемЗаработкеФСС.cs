using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class УчетНачисленийВСреднемЗаработкеФСС:V1C8COMObject
    {
        public УчетНачисленийВСреднемЗаработкеФСС(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Включать => GetProperty<EnumItemBase>();
        public EnumItemBase НеВключать => GetProperty<EnumItemBase>();
    }
}
