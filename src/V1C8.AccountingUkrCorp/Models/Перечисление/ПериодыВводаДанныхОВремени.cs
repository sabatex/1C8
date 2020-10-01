using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ПериодыВводаДанныхОВремени", Comment = "", Synonym = "Периоды ввода данных о времени")]
    public enum ПериодыВводаДанныхОВремени
    {
        [Description1C8(Name = "ТекущийМесяц", Comment = "", Synonym = "Текущий месяц")]
        ТекущийМесяц,
        [Description1C8(Name = "ПерваяПоловинаТекущегоМесяца", Comment = "", Synonym = "Первая половина  месяца")]
        ПерваяПоловинаТекущегоМесяца,
        [Description1C8(Name = "ВтораяПоловинаТекущегоМесяца", Comment = "", Synonym = "Вторая половина  месяца")]
        ВтораяПоловинаТекущегоМесяца,
        [Description1C8(Name = "ПрошлыйПериод", Comment = "", Synonym = "Произвольный период")]
        ПрошлыйПериод
    }
}
