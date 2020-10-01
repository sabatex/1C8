using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ИсточникиДанныхДляРасчетаСреднегоЗаработка", Comment = "", Synonym = "Источники данных для расчета среднего заработка")]
    public enum ИсточникиДанныхДляРасчетаСреднегоЗаработка
    {
        [Description1C8(Name = "ПереносДанных", Comment = "", Synonym = "Перенос данных")]
        ПереносДанных,
        [Description1C8(Name = "СведенияДоНачалаЭксплуатации", Comment = "", Synonym = "Сведения до начала эксплуатации")]
        СведенияДоНачалаЭксплуатации,
        [Description1C8(Name = "Начисления", Comment = "", Synonym = "Начисления")]
        Начисления,
        [Description1C8(Name = "Исправления", Comment = "", Synonym = "Исправления")]
        Исправления
    }
}
