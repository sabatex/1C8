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
    [Table("PeryodyRaschetaBazovykhNachyslenyi")]
    [Description1C8(Name = "ПериодыРасчетаБазовыхНачислений", Comment = "", Synonym = "Периоды расчета базовых начислений")]
    public class ПериодыРасчетаБазовыхНачислений:EnumItem
    {
        public static readonly ПериодыРасчетаБазовыхНачислений ТекущийМесяц = new ПериодыРасчетаБазовыхНачислений{Name= "ТекущийМесяц",Synonym="Текущий месяц",Comment=""};
        public static readonly ПериодыРасчетаБазовыхНачислений ПредыдущийМесяц = new ПериодыРасчетаБазовыхНачислений{Name= "ПредыдущийМесяц",Synonym="Предыдущий месяц",Comment=""};
        public static readonly ПериодыРасчетаБазовыхНачислений ТекущийКвартал = new ПериодыРасчетаБазовыхНачислений{Name= "ТекущийКвартал",Synonym="Текущий квартал",Comment=""};
        public static readonly ПериодыРасчетаБазовыхНачислений ПредыдущийКвартал = new ПериодыРасчетаБазовыхНачислений{Name= "ПредыдущийКвартал",Synonym="Предыдущий квартал",Comment=""};
        public static readonly ПериодыРасчетаБазовыхНачислений ТекущийГод = new ПериодыРасчетаБазовыхНачислений{Name= "ТекущийГод",Synonym="Текущий год",Comment=""};
        public static readonly ПериодыРасчетаБазовыхНачислений ПредыдущийГод = new ПериодыРасчетаБазовыхНачислений{Name= "ПредыдущийГод",Synonym="Предыдущий год",Comment=""};
        public static readonly ПериодыРасчетаБазовыхНачислений НесколькоПредыдущихМесяцев = new ПериодыРасчетаБазовыхНачислений{Name= "НесколькоПредыдущихМесяцев",Synonym="Несколько предыдущих месяцев",Comment=""};
    }
}
