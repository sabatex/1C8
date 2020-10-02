using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ПериодыВводаДанныхОВремени", Comment = "", Synonym = "Периоды ввода данных о времени")]
    public class ПериодыВводаДанныхОВремени:EnumItem
    {
        public static readonly ПериодыВводаДанныхОВремени ТекущийМесяц = new ПериодыВводаДанныхОВремени{Name= "ТекущийМесяц",Synonim="Текущий месяц",Comment=""};
        public static readonly ПериодыВводаДанныхОВремени ПерваяПоловинаТекущегоМесяца = new ПериодыВводаДанныхОВремени{Name= "ПерваяПоловинаТекущегоМесяца",Synonim="Первая половина  месяца",Comment=""};
        public static readonly ПериодыВводаДанныхОВремени ВтораяПоловинаТекущегоМесяца = new ПериодыВводаДанныхОВремени{Name= "ВтораяПоловинаТекущегоМесяца",Synonim="Вторая половина  месяца",Comment=""};
        public static readonly ПериодыВводаДанныхОВремени ПрошлыйПериод = new ПериодыВводаДанныхОВремени{Name= "ПрошлыйПериод",Synonim="Произвольный период",Comment=""};
    }
}
