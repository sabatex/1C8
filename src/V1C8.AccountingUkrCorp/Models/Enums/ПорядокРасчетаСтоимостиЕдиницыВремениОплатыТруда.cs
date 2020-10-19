using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Table("PoriadokRaschetaStoymostyEdynytsyVremenyOplatyTruda")]
    [Description1C8(Name = "ПорядокРасчетаСтоимостиЕдиницыВремениОплатыТруда", Comment = "", Synonym = "Порядок расчета стоимости часа (дня) оплаты труда сотрудников")]
    public class ПорядокРасчетаСтоимостиЕдиницыВремениОплатыТруда:EnumItem
    {
        public static readonly ПорядокРасчетаСтоимостиЕдиницыВремениОплатыТруда ПоНормеВремениГрафикаСотрудника = new ПорядокРасчетаСтоимостиЕдиницыВремениОплатыТруда{Name= "ПоНормеВремениГрафикаСотрудника",Synonym="По норме времени графика сотрудника",Comment=""};
        public static readonly ПорядокРасчетаСтоимостиЕдиницыВремениОплатыТруда ПоНормеВремениПроизводственногоКалендаря = new ПорядокРасчетаСтоимостиЕдиницыВремениОплатыТруда{Name= "ПоНормеВремениПроизводственногоКалендаря",Synonym="По норме времени производственного календаря",Comment=""};
        public static readonly ПорядокРасчетаСтоимостиЕдиницыВремениОплатыТруда ПоСреднегодовомуЗначению = new ПорядокРасчетаСтоимостиЕдиницыВремениОплатыТруда{Name= "ПоСреднегодовомуЗначению",Synonym="По среднемесячному количеству часов (дней)",Comment=""};
    }
}
