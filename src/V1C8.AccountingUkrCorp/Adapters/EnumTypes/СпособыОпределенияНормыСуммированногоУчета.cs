using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыОпределенияНормыСуммированногоУчета:V1C8COMObject
    {
        public СпособыОпределенияНормыСуммированногоУчета(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПоПроизводственномуКалендарю => GetProperty<EnumItemBase>("ПоПроизводственномуКалендарю");
        public EnumItemBase ПоДаннымЭтогоГрафика => GetProperty<EnumItemBase>("ПоДаннымЭтогоГрафика");
        public EnumItemBase ПоДаннымДругогоГрафика => GetProperty<EnumItemBase>("ПоДаннымДругогоГрафика");
    }
}
