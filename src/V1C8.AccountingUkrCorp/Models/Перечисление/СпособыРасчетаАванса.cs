using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыРасчетаАванса", Comment = "", Synonym = "Способы расчета аванса")]
    public enum СпособыРасчетаАванса
    {
        [Description1C8(Name = "ФиксированнойСуммой", Comment = "", Synonym = "Фиксированной суммой")]
        ФиксированнойСуммой,
        [Description1C8(Name = "ПроцентомОтТарифа", Comment = "", Synonym = "Процентом от тарифа")]
        ПроцентомОтТарифа,
        [Description1C8(Name = "РасчетомЗаПервуюПоловинуМесяца", Comment = "", Synonym = "Расчетом за первую половину месяца")]
        РасчетомЗаПервуюПоловинуМесяца
    }
}
