using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыРаботСДосрочнойПенсией", Comment = "", Synonym = "Виды работ с досрочной пенсией")]
    public class ВидыРаботСДосрочнойПенсией:EnumItem
    {
        public static readonly ВидыРаботСДосрочнойПенсией ПодземныеИВредныеРаботы = new ВидыРаботСДосрочнойПенсией{Name= "ПодземныеИВредныеРаботы",Synonim="Работы с вредными условиями труда, подпункт 1 пункта 1 статьи 27 закона «О трудовых пенсиях в РФ»",Comment=""};
        public static readonly ВидыРаботСДосрочнойПенсией ТяжелыеИПрочиеРаботы = new ВидыРаботСДосрочнойПенсией{Name= "ТяжелыеИПрочиеРаботы",Synonim="Работы с тяжелыми условиями труда, подпункты 2 - 18 пункта 1 статьи 27 закона «О трудовых пенсиях в РФ»",Comment=""};
    }
}
