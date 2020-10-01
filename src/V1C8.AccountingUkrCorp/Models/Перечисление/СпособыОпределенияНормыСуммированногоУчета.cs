using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыОпределенияНормыСуммированногоУчета", Comment = "", Synonym = "Способы определения нормы суммированного учета")]
    public enum СпособыОпределенияНормыСуммированногоУчета
    {
        [Description1C8(Name = "ПоПроизводственномуКалендарю", Comment = "", Synonym = "По производственному календарю")]
        ПоПроизводственномуКалендарю,
        [Description1C8(Name = "ПоДаннымЭтогоГрафика", Comment = "", Synonym = "По данным этого графика")]
        ПоДаннымЭтогоГрафика,
        [Description1C8(Name = "ПоДаннымДругогоГрафика", Comment = "", Synonym = "По данным другого графика")]
        ПоДаннымДругогоГрафика
    }
}
