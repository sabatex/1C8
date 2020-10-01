using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ПорядокРасчетаСтоимостиЕдиницыВремениОплатыТруда", Comment = "", Synonym = "Порядок расчета стоимости часа (дня) оплаты труда сотрудников")]
    public enum ПорядокРасчетаСтоимостиЕдиницыВремениОплатыТруда
    {
        [Description1C8(Name = "ПоНормеВремениГрафикаСотрудника", Comment = "", Synonym = "По норме времени графика сотрудника")]
        ПоНормеВремениГрафикаСотрудника,
        [Description1C8(Name = "ПоНормеВремениПроизводственногоКалендаря", Comment = "", Synonym = "По норме времени производственного календаря")]
        ПоНормеВремениПроизводственногоКалендаря,
        [Description1C8(Name = "ПоСреднегодовомуЗначению", Comment = "", Synonym = "По среднемесячному количеству часов (дней)")]
        ПоСреднегодовомуЗначению
    }
}
