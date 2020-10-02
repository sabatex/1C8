using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ПериодыРасчетаБазовыхНачислений", Comment = "", Synonym = "Периоды расчета базовых начислений")]
    public class ПериодыРасчетаБазовыхНачислений:EnumItem
    {
        public static readonly ПериодыРасчетаБазовыхНачислений ТекущийМесяц = new ПериодыРасчетаБазовыхНачислений{Name= "ТекущийМесяц",Synonim="Текущий месяц",Comment=""};
        public static readonly ПериодыРасчетаБазовыхНачислений ПредыдущийМесяц = new ПериодыРасчетаБазовыхНачислений{Name= "ПредыдущийМесяц",Synonim="Предыдущий месяц",Comment=""};
        public static readonly ПериодыРасчетаБазовыхНачислений ТекущийКвартал = new ПериодыРасчетаБазовыхНачислений{Name= "ТекущийКвартал",Synonim="Текущий квартал",Comment=""};
        public static readonly ПериодыРасчетаБазовыхНачислений ПредыдущийКвартал = new ПериодыРасчетаБазовыхНачислений{Name= "ПредыдущийКвартал",Synonim="Предыдущий квартал",Comment=""};
        public static readonly ПериодыРасчетаБазовыхНачислений ТекущийГод = new ПериодыРасчетаБазовыхНачислений{Name= "ТекущийГод",Synonim="Текущий год",Comment=""};
        public static readonly ПериодыРасчетаБазовыхНачислений ПредыдущийГод = new ПериодыРасчетаБазовыхНачислений{Name= "ПредыдущийГод",Synonim="Предыдущий год",Comment=""};
        public static readonly ПериодыРасчетаБазовыхНачислений НесколькоПредыдущихМесяцев = new ПериодыРасчетаБазовыхНачислений{Name= "НесколькоПредыдущихМесяцев",Synonim="Несколько предыдущих месяцев",Comment=""};
    }
}
