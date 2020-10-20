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
    [Table("KontaktnyeLytsa")]
    [Description1C8(Name = "КонтактныеЛица", Comment = "", Synonym = "Контактные лица")]
    public class КонтактныеЛица:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Фамилия", Comment = "", Synonym = "Фамилия")]
        [StringLength(50)]
        public string Фамилия {get; set;}
        [Description1C8(Name = "Имя", Comment = "", Synonym = "Имя")]
        [StringLength(50)]
        public string Имя {get; set;}
        [Description1C8(Name = "Отчество", Comment = "", Synonym = "Отчество")]
        [StringLength(50)]
        public string Отчество {get; set;}
        [Description1C8(Name = "ДатаРождения", Comment = "", Synonym = "Дата рождения")]
        public DateTime ДатаРождения {get; set;}
        [Description1C8(Name = "Роль", Comment = "", Synonym = "Роль")]
        public Catalogs.РолиКонтактныхЛиц Роль {get; set;}
        [Description1C8(Name = "Должность", Comment = "", Synonym = "Должность")]
        [StringLength(100)]
        public string Должность {get; set;}
        [Description1C8(Name = "Описание", Comment = "", Synonym = "Описание")]
        public string Описание {get; set;}
        [Description1C8(Name = "ОбъектВладелец", Comment = "", Synonym = "Объект владелец")]
        public Catalogs.Контрагенты ОбъектВладелец {get; set;}
        [Description1C8(Name = "ВидКонтактногоЛица", Comment = "", Synonym = "Вид контактного лица")]
        public Enums.ВидыКонтактныхЛиц ВидКонтактногоЛица {get; set;}
        [Description1C8(Name = "ПользовательЛичногоКонтакта", Comment = "", Synonym = "Пользователь личного контакта")]
        public Catalogs.Пользователи ПользовательЛичногоКонтакта {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "КонтактнаяИнформация", Comment = "", Synonym = "Контактная информация")]
        public List<КонтактныеЛица_КонтактнаяИнформация> КонтактныеЛицаКонтактнаяИнформация {get;set;}
        [Description1C8(Name = "ДополнительныеРеквизиты", Comment = "", Synonym = "Дополнительные реквизиты")]
        public List<КонтактныеЛица_ДополнительныеРеквизиты> КонтактныеЛицаДополнительныеРеквизиты {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "КонтактнаяИнформация", Comment = "", Synonym = "Контактная информация")]
    [Table("KontaktnyeLytsa_KontaktnaiaYnformatsyia")]
    public class КонтактныеЛица_КонтактнаяИнформация
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
    [Description1C8(Name = "ДополнительныеРеквизиты", Comment = "", Synonym = "Дополнительные реквизиты")]
    [Table("KontaktnyeLytsa_DopolnytelnyeRekvyzyty")]
    public class КонтактныеЛица_ДополнительныеРеквизиты
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
}
