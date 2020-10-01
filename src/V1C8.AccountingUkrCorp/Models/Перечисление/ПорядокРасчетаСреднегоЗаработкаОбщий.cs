using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ПорядокРасчетаСреднегоЗаработкаОбщий", Comment = "", Synonym = "Порядок расчета среднего заработка общий")]
    public enum ПорядокРасчетаСреднегоЗаработкаОбщий
    {
        [Description1C8(Name = "Постановление2010", Comment = "", Synonym = "Постановление 100 (для прочих)")]
        Постановление2010,
        [Description1C8(Name = "Постановление100Отпускные", Comment = "", Synonym = "Постановление 100 (для отпускных)")]
        Постановление100Отпускные
    }
}
