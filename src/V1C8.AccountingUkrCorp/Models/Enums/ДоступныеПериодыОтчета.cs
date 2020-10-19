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
    [Table("DostupnyePeryodyOtcheta")]
    [Description1C8(Name = "ДоступныеПериодыОтчета", Comment = "", Synonym = "Доступные периоды отчета")]
    public class ДоступныеПериодыОтчета:EnumItem
    {
        public static readonly ДоступныеПериодыОтчета День = new ДоступныеПериодыОтчета{Name= "День",Synonym="День",Comment=""};
        public static readonly ДоступныеПериодыОтчета Неделя = new ДоступныеПериодыОтчета{Name= "Неделя",Synonym="Неделя",Comment=""};
        public static readonly ДоступныеПериодыОтчета Декада = new ДоступныеПериодыОтчета{Name= "Декада",Synonym="Декада",Comment=""};
        public static readonly ДоступныеПериодыОтчета Месяц = new ДоступныеПериодыОтчета{Name= "Месяц",Synonym="Месяц",Comment=""};
        public static readonly ДоступныеПериодыОтчета Квартал = new ДоступныеПериодыОтчета{Name= "Квартал",Synonym="Квартал",Comment=""};
        public static readonly ДоступныеПериодыОтчета Полугодие = new ДоступныеПериодыОтчета{Name= "Полугодие",Synonym="Полугодие",Comment=""};
        public static readonly ДоступныеПериодыОтчета Год = new ДоступныеПериодыОтчета{Name= "Год",Synonym="Год",Comment=""};
        public static readonly ДоступныеПериодыОтчета ПроизвольныйПериод = new ДоступныеПериодыОтчета{Name= "ПроизвольныйПериод",Synonym="Произвольный",Comment=""};
    }
}
