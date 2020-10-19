using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыОпределенияНормыСуммированногоУчета:EnumBase
    {
        public СпособыОпределенияНормыСуммированногоУчета(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ПоПроизводственномуКалендарю => GetProperty<EnumItem>("ПоПроизводственномуКалендарю");
        public EnumItem ПоДаннымЭтогоГрафика => GetProperty<EnumItem>("ПоДаннымЭтогоГрафика");
        public EnumItem ПоДаннымДругогоГрафика => GetProperty<EnumItem>("ПоДаннымДругогоГрафика");
    }
}
