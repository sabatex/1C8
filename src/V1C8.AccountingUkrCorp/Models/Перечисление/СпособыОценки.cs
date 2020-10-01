using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыОценки", Comment = "(Регл)", Synonym = "Способы оценки")]
    public enum СпособыОценки
    {
        [Description1C8(Name = "ПоСредней", Comment = "", Synonym = "По средней")]
        ПоСредней,
        [Description1C8(Name = "ФИФО", Comment = "First input, first output (первым пришел, первым обработан)", Synonym = "ФИФО")]
        ФИФО,
        [Description1C8(Name = "ЛИФО", Comment = "Last input, first output (последним пришел, первым обработан)", Synonym = "ЛИФО")]
        ЛИФО
    }
}
