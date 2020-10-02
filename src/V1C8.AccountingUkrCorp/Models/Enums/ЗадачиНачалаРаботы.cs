using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ЗадачиНачалаРаботы", Comment = "", Synonym = "Задачи начала работы")]
    public class ЗадачиНачалаРаботы:EnumItem
    {
        public static readonly ЗадачиНачалаРаботы ДоступКОрганизациям = new ЗадачиНачалаРаботы{Name= "ДоступКОрганизациям",Synonim="Доступных организаций нет. Обратитесь к администратору.",Comment=""};
        public static readonly ЗадачиНачалаРаботы РеквизитыОрганизации = new ЗадачиНачалаРаботы{Name= "РеквизитыОрганизации",Synonim="Заполнить реквизиты организации",Comment=""};
        public static readonly ЗадачиНачалаРаботы ПараметрыУчета = new ЗадачиНачалаРаботы{Name= "ПараметрыУчета",Synonim="Проверить параметры учета",Comment=""};
        public static readonly ЗадачиНачалаРаботы УчетнаяПолитика = new ЗадачиНачалаРаботы{Name= "УчетнаяПолитика",Synonim="Проверить настройки учетной политики",Comment=""};
        public static readonly ЗадачиНачалаРаботы НачальныеОстатки = new ЗадачиНачалаРаботы{Name= "НачальныеОстатки",Synonim="Ввести начальные остатки",Comment=""};
    }
}
