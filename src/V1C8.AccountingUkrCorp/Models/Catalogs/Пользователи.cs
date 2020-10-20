using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Catalogs
{
    [Table("Polzovately")]
    [Description1C8(Name = "Пользователи", Comment = "", Synonym = "Пользователи")]
    public class Пользователи:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Недействителен", Comment = "", Synonym = "Недействителен")]
        public bool Недействителен {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "Служебный", Comment = "", Synonym = "Служебный")]
        public bool Служебный {get; set;}
        [Description1C8(Name = "Подготовлен", Comment = "", Synonym = "Подготовлен")]
        public bool Подготовлен {get; set;}
        [Description1C8(Name = "ИдентификаторПользователяИБ", Comment = "", Synonym = "Идентификатор пользователя ИБ")]
        public Guid ИдентификаторПользователяИБ {get; set;}
        [Description1C8(Name = "ИдентификаторПользователяСервиса", Comment = "", Synonym = "Идентификатор пользователя сервиса")]
        public Guid ИдентификаторПользователяСервиса {get; set;}
        [Description1C8(Name = "СвойстваПользователяИБ", Comment = "", Synonym = "Свойства пользователя ИБ")]
        // Сховище значень
        public byte[] СвойстваПользователяИБ {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ДополнительныеРеквизиты", Comment = "", Synonym = "Дополнительные реквизиты")]
        public List<Пользователи_ДополнительныеРеквизиты> ПользователиДополнительныеРеквизиты {get;set;}
        [Description1C8(Name = "КонтактнаяИнформация", Comment = "", Synonym = "Контактная информация")]
        public List<Пользователи_КонтактнаяИнформация> ПользователиКонтактнаяИнформация {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ДополнительныеРеквизиты", Comment = "", Synonym = "Дополнительные реквизиты")]
    [Table("Polzovately_DopolnytelnyeRekvyzyty")]
    public class Пользователи_ДополнительныеРеквизиты
    {
    public long Id {get;set;}
    public Guid Owner {get;set;}
        [Description1C8(Name = "Свойство", Comment = "", Synonym = "Свойство")]
        public ПланВидовХарактеристик.ДополнительныеРеквизитыИСведения Свойство {get; set;}
        [Description1C8(Name = "Значение", Comment = "", Synonym = "Значение")]
        public Catalogs.Склады Значение {get; set;}
        [Description1C8(Name = "ТекстоваяСтрока", Comment = "", Synonym = "Текстовая строка")]
        public string ТекстоваяСтрока {get; set;}
    }
    [Description1C8(Name = "КонтактнаяИнформация", Comment = "", Synonym = "Контактная информация")]
    [Table("Polzovately_KontaktnaiaYnformatsyia")]
    public class Пользователи_КонтактнаяИнформация
    {
    public long Id {get;set;}
    public Guid Owner {get;set;}
        [Description1C8(Name = "Тип", Comment = "", Synonym = "Тип")]
        public Enums.ТипыКонтактнойИнформации Тип {get; set;}
        [Description1C8(Name = "Вид", Comment = "", Synonym = "Вид")]
        public Catalogs.ВидыКонтактнойИнформации Вид {get; set;}
        [Description1C8(Name = "Представление", Comment = "", Synonym = "Представление")]
        [StringLength(500)]
        public string Представление {get; set;}
        [Description1C8(Name = "ЗначенияПолей", Comment = "", Synonym = "Значения полей")]
        public string ЗначенияПолей {get; set;}
        [Description1C8(Name = "Страна", Comment = "", Synonym = "Страна")]
        [StringLength(100)]
        public string Страна {get; set;}
        [Description1C8(Name = "Регион", Comment = "", Synonym = "Область")]
        [StringLength(50)]
        public string Регион {get; set;}
        [Description1C8(Name = "Город", Comment = "", Synonym = "Город")]
        [StringLength(50)]
        public string Город {get; set;}
        [Description1C8(Name = "АдресЭП", Comment = "", Synonym = "Адрес ЭП")]
        [StringLength(100)]
        public string АдресЭП {get; set;}
        [Description1C8(Name = "ДоменноеИмяСервера", Comment = "", Synonym = "Доменное имя сервера")]
        [StringLength(100)]
        public string ДоменноеИмяСервера {get; set;}
        [Description1C8(Name = "НомерТелефона", Comment = "", Synonym = "Номер телефона")]
        [StringLength(20)]
        public string НомерТелефона {get; set;}
        [Description1C8(Name = "НомерТелефонаБезКодов", Comment = "", Synonym = "Номер телефона без кодов")]
        [StringLength(20)]
        public string НомерТелефонаБезКодов {get; set;}
        [Description1C8(Name = "ВидДляСписка", Comment = "", Synonym = "Вид для списка")]
        public Catalogs.ВидыКонтактнойИнформации ВидДляСписка {get; set;}
        [Description1C8(Name = "Значение", Comment = "", Synonym = "Значение")]
        public string Значение {get; set;}
    }
}
