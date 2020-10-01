using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ЗадачиНачалаРаботы", Comment = "", Synonym = "Задачи начала работы")]
    public enum ЗадачиНачалаРаботы
    {
        [Description1C8(Name = "ДоступКОрганизациям", Comment = "", Synonym = "Доступных организаций нет. Обратитесь к администратору.")]
        ДоступКОрганизациям,
        [Description1C8(Name = "РеквизитыОрганизации", Comment = "", Synonym = "Заполнить реквизиты организации")]
        РеквизитыОрганизации,
        [Description1C8(Name = "ПараметрыУчета", Comment = "", Synonym = "Проверить параметры учета")]
        ПараметрыУчета,
        [Description1C8(Name = "УчетнаяПолитика", Comment = "", Synonym = "Проверить настройки учетной политики")]
        УчетнаяПолитика,
        [Description1C8(Name = "НачальныеОстатки", Comment = "", Synonym = "Ввести начальные остатки")]
        НачальныеОстатки
    }
}
