using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыРасчетаПоШкале", Comment = "", Synonym = "Способы расчета по шкале")]
    public enum СпособыРасчетаПоШкале
    {
        [Description1C8(Name = "ПоШкале", Comment = "", Synonym = "По шкале")]
        ПоШкале,
        [Description1C8(Name = "Прогрессивный", Comment = "", Synonym = "Прогрессивный")]
        Прогрессивный,
        [Description1C8(Name = "СДекретных", Comment = "", Synonym = "С декретных")]
        СДекретных
    }
}
