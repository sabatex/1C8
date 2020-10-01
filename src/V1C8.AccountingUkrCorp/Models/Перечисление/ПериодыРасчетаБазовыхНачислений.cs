using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ПериодыРасчетаБазовыхНачислений", Comment = "", Synonym = "Периоды расчета базовых начислений")]
    public enum ПериодыРасчетаБазовыхНачислений
    {
        [Description1C8(Name = "ТекущийМесяц", Comment = "", Synonym = "Текущий месяц")]
        ТекущийМесяц,
        [Description1C8(Name = "ПредыдущийМесяц", Comment = "", Synonym = "Предыдущий месяц")]
        ПредыдущийМесяц,
        [Description1C8(Name = "ТекущийКвартал", Comment = "", Synonym = "Текущий квартал")]
        ТекущийКвартал,
        [Description1C8(Name = "ПредыдущийКвартал", Comment = "", Synonym = "Предыдущий квартал")]
        ПредыдущийКвартал,
        [Description1C8(Name = "ТекущийГод", Comment = "", Synonym = "Текущий год")]
        ТекущийГод,
        [Description1C8(Name = "ПредыдущийГод", Comment = "", Synonym = "Предыдущий год")]
        ПредыдущийГод,
        [Description1C8(Name = "НесколькоПредыдущихМесяцев", Comment = "", Synonym = "Несколько предыдущих месяцев")]
        НесколькоПредыдущихМесяцев
    }
}
