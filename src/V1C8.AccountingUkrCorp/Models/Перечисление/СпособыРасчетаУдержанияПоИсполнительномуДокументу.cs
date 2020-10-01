using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыРасчетаУдержанияПоИсполнительномуДокументу", Comment = "", Synonym = "Способы расчета удержания по исполнительному документу")]
    public enum СпособыРасчетаУдержанияПоИсполнительномуДокументу
    {
        [Description1C8(Name = "Процентом", Comment = "", Synonym = "Процентом")]
        Процентом,
        [Description1C8(Name = "Долей", Comment = "", Synonym = "Долей")]
        Долей,
        [Description1C8(Name = "ФиксированнойСуммой", Comment = "", Synonym = "Фиксированной суммой")]
        ФиксированнойСуммой
    }
}
