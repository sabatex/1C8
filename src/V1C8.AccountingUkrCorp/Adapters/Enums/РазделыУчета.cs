using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class РазделыУчета:V1C8COMObject
    {
        public РазделыУчета(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОценкаМПЗ => GetProperty<EnumItemBase>();
        public EnumItemBase РасчетыСКонтрагентами => GetProperty<EnumItemBase>();
    }
}
