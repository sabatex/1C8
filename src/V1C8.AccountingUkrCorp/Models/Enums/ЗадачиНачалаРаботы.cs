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
        public static readonly ЗадачиНачалаРаботы ДоступКОрганизациям = new ЗадачиНачалаРаботы{Name= "ДоступКОрганизациям",Synonym="Доступных организаций нет. Обратитесь к администратору.",Comment=""};
        public static readonly ЗадачиНачалаРаботы РеквизитыОрганизации = new ЗадачиНачалаРаботы{Name= "РеквизитыОрганизации",Synonym="Заполнить реквизиты организации",Comment=""};
        public static readonly ЗадачиНачалаРаботы ПараметрыУчета = new ЗадачиНачалаРаботы{Name= "ПараметрыУчета",Synonym="Проверить параметры учета",Comment=""};
        public static readonly ЗадачиНачалаРаботы УчетнаяПолитика = new ЗадачиНачалаРаботы{Name= "УчетнаяПолитика",Synonym="Проверить настройки учетной политики",Comment=""};
        public static readonly ЗадачиНачалаРаботы НачальныеОстатки = new ЗадачиНачалаРаботы{Name= "НачальныеОстатки",Synonym="Ввести начальные остатки",Comment=""};
    }
}
