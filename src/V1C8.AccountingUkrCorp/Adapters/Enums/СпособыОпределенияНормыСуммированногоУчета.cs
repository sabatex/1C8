using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СпособыОпределенияНормыСуммированногоУчета:V1C8COMObject
    {
        public СпособыОпределенияНормыСуммированногоУчета(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПоПроизводственномуКалендарю => GetProperty<EnumItemBase>();
        public EnumItemBase ПоДаннымЭтогоГрафика => GetProperty<EnumItemBase>();
        public EnumItemBase ПоДаннымДругогоГрафика => GetProperty<EnumItemBase>();
    }
}
