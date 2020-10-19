using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class РазделыУчета:V1C8COMObject
    {
        public РазделыУчета(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОценкаМПЗ => GetProperty<EnumItemBase>("ОценкаМПЗ");
        public EnumItemBase РасчетыСКонтрагентами => GetProperty<EnumItemBase>("РасчетыСКонтрагентами");
    }
}
