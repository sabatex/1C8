using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ПорядокРасчетаСтоимостиЕдиницыВремениОплатыТруда", Comment = "", Synonym = "Порядок расчета стоимости часа (дня) оплаты труда сотрудников")]
    public class ПорядокРасчетаСтоимостиЕдиницыВремениОплатыТруда:EnumItem
    {
        public static readonly ПорядокРасчетаСтоимостиЕдиницыВремениОплатыТруда ПоНормеВремениГрафикаСотрудника = new ПорядокРасчетаСтоимостиЕдиницыВремениОплатыТруда{Name= "ПоНормеВремениГрафикаСотрудника",Synonim="По норме времени графика сотрудника",Comment=""};
        public static readonly ПорядокРасчетаСтоимостиЕдиницыВремениОплатыТруда ПоНормеВремениПроизводственногоКалендаря = new ПорядокРасчетаСтоимостиЕдиницыВремениОплатыТруда{Name= "ПоНормеВремениПроизводственногоКалендаря",Synonim="По норме времени производственного календаря",Comment=""};
        public static readonly ПорядокРасчетаСтоимостиЕдиницыВремениОплатыТруда ПоСреднегодовомуЗначению = new ПорядокРасчетаСтоимостиЕдиницыВремениОплатыТруда{Name= "ПоСреднегодовомуЗначению",Synonim="По среднемесячному количеству часов (дней)",Comment=""};
    }
}
