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
    [Table("OsnovnyeSredstva")]
    [Description1C8(Name = "ОсновныеСредства", Comment = "", Synonym = "Основные средства")]
    public class ОсновныеСредства:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "НаименованиеПолное", Comment = "(Общ)", Synonym = "Полное наименование")]
        [StringLength(1000)]
        public string НаименованиеПолное {get; set;}
        [Description1C8(Name = "Изготовитель", Comment = "(Общ) Организация-изготовитель", Synonym = "Изготовитель")]
        [StringLength(250)]
        public string Изготовитель {get; set;}
        [Description1C8(Name = "ЗаводскойНомер", Comment = "(Общ)", Synonym = "Заводской номер")]
        [StringLength(100)]
        public string ЗаводскойНомер {get; set;}
        [Description1C8(Name = "НомерПаспорта", Comment = "(Общ)", Synonym = "Номер паспорта (регистрационный)")]
        [StringLength(100)]
        public string НомерПаспорта {get; set;}
        [Description1C8(Name = "ДатаВыпуска", Comment = "(Общ)", Synonym = "Дата выпуска (постройки)")]
        public DateTime ДатаВыпуска {get; set;}
        [Description1C8(Name = "Автотранспорт", Comment = "(Общ)", Synonym = "Признак автотранспорта")]
        public bool Автотранспорт {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "(Общ)", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "Модель", Comment = "(Регл)", Synonym = "Модель, тип, марка")]
        public string Модель {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ДополнительныеРеквизиты", Comment = "", Synonym = "Дополнительные реквизиты")]
        public List<ОсновныеСредства_ДополнительныеРеквизиты> ОсновныеСредстваДополнительныеРеквизиты {get;set;}
        [Description1C8(Name = "КонтактнаяИнформация", Comment = "", Synonym = "Контактная информация")]
        public List<ОсновныеСредства_КонтактнаяИнформация> ОсновныеСредстваКонтактнаяИнформация {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ДополнительныеРеквизиты", Comment = "", Synonym = "Дополнительные реквизиты")]
    [Table("OsnovnyeSredstva_DopolnytelnyeRekvyzyty")]
    public class ОсновныеСредства_ДополнительныеРеквизиты
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
    [Table("OsnovnyeSredstva_KontaktnaiaYnformatsyia")]
    public class ОсновныеСредства_КонтактнаяИнформация
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
