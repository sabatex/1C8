using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыРасчетаСебестоимостиПродукции", Comment = "(Общ)", Synonym = "Способы расчета себестоимости продукции")]
    public enum СпособыРасчетаСебестоимостиПродукции
    {
        [Description1C8(Name = "ПоПеределам", Comment = "(Общ)", Synonym = "По переделам")]
        ПоПеределам,
        [Description1C8(Name = "ПоПодразделениям", Comment = "(Общ)", Synonym = "По подразделениям")]
        ПоПодразделениям
    }
}
