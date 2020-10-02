using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ДоступныеПериодыОтчета", Comment = "", Synonym = "Доступные периоды отчета")]
    public class ДоступныеПериодыОтчета:EnumItem
    {
        public static readonly ДоступныеПериодыОтчета День = new ДоступныеПериодыОтчета{Name= "День",Synonim="День",Comment=""};
        public static readonly ДоступныеПериодыОтчета Неделя = new ДоступныеПериодыОтчета{Name= "Неделя",Synonim="Неделя",Comment=""};
        public static readonly ДоступныеПериодыОтчета Декада = new ДоступныеПериодыОтчета{Name= "Декада",Synonim="Декада",Comment=""};
        public static readonly ДоступныеПериодыОтчета Месяц = new ДоступныеПериодыОтчета{Name= "Месяц",Synonim="Месяц",Comment=""};
        public static readonly ДоступныеПериодыОтчета Квартал = new ДоступныеПериодыОтчета{Name= "Квартал",Synonim="Квартал",Comment=""};
        public static readonly ДоступныеПериодыОтчета Полугодие = new ДоступныеПериодыОтчета{Name= "Полугодие",Synonim="Полугодие",Comment=""};
        public static readonly ДоступныеПериодыОтчета Год = new ДоступныеПериодыОтчета{Name= "Год",Synonim="Год",Comment=""};
        public static readonly ДоступныеПериодыОтчета ПроизвольныйПериод = new ДоступныеПериодыОтчета{Name= "ПроизвольныйПериод",Synonim="Произвольный",Comment=""};
    }
}
