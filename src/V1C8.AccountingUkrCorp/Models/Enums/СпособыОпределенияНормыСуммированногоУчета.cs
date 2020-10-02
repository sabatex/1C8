using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыОпределенияНормыСуммированногоУчета", Comment = "", Synonym = "Способы определения нормы суммированного учета")]
    public class СпособыОпределенияНормыСуммированногоУчета:EnumItem
    {
        public static readonly СпособыОпределенияНормыСуммированногоУчета ПоПроизводственномуКалендарю = new СпособыОпределенияНормыСуммированногоУчета{Name= "ПоПроизводственномуКалендарю",Synonim="По производственному календарю",Comment=""};
        public static readonly СпособыОпределенияНормыСуммированногоУчета ПоДаннымЭтогоГрафика = new СпособыОпределенияНормыСуммированногоУчета{Name= "ПоДаннымЭтогоГрафика",Synonim="По данным этого графика",Comment=""};
        public static readonly СпособыОпределенияНормыСуммированногоУчета ПоДаннымДругогоГрафика = new СпособыОпределенияНормыСуммированногоУчета{Name= "ПоДаннымДругогоГрафика",Synonim="По данным другого графика",Comment=""};
    }
}
