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
    [Table("Sotrudnyky")]
    [Description1C8(Name = "Сотрудники", Comment = "", Synonym = "Сотрудники")]
    public class Сотрудники:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "Актуальность", Comment = "", Synonym = "Актуальность")]
        public bool Актуальность {get; set;}
        [Description1C8(Name = "ГоловнаяОрганизация", Comment = "", Synonym = "Головная организация")]
        public Catalogs.Организации ГоловнаяОрганизация {get; set;}
        [Description1C8(Name = "УдалитьВидЗанятости", Comment = "", Synonym = "(не используется) Вид занятости")]
        public Enums.УстарелоВидыЗанятости УдалитьВидЗанятости {get; set;}
        [Description1C8(Name = "ВАрхиве", Comment = "", Synonym = "В архиве")]
        public bool ВАрхиве {get; set;}
        [Description1C8(Name = "ОсновноеНазначение", Comment = "", Synonym = "Основное назначение")]
        public Catalogs.Сотрудники ОсновноеНазначение {get; set;}
        [Description1C8(Name = "ПоНаправлениюОргановЗанятости", Comment = "", Synonym = "По направлению органов занятости")]
        public bool ПоНаправлениюОргановЗанятости {get; set;}
        [Description1C8(Name = "УточнениеНаименования", Comment = "", Synonym = "Уточнение наименования")]
        [StringLength(40)]
        public string УточнениеНаименования {get; set;}
        [Description1C8(Name = "ГоловнойСотрудник", Comment = "", Synonym = "Основной сотрудник")]
        public Catalogs.Сотрудники ГоловнойСотрудник {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ДополнительныеРеквизиты", Comment = "", Synonym = "Дополнительные реквизиты")]
        public List<Сотрудники_ДополнительныеРеквизиты> СотрудникиДополнительныеРеквизиты {get;set;}
        [Description1C8(Name = "НаборыЗначенийДоступа", Comment = "", Synonym = "Наборы значений доступа")]
        public List<Сотрудники_НаборыЗначенийДоступа> СотрудникиНаборыЗначенийДоступа {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ДополнительныеРеквизиты", Comment = "", Synonym = "Дополнительные реквизиты")]
    [Table("Sotrudnyky_DopolnytelnyeRekvyzyty")]
    public class Сотрудники_ДополнительныеРеквизиты
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
    [Description1C8(Name = "НаборыЗначенийДоступа", Comment = "", Synonym = "Наборы значений доступа")]
    [Table("Sotrudnyky_NaboryZnachenyiDostupa")]
    public class Сотрудники_НаборыЗначенийДоступа
    {
    public long Id {get;set;}
    public Guid Owner {get;set;}
        [Description1C8(Name = "НомерНабора", Comment = "", Synonym = "Номер набора")]
        // Format 10.0
        public long НомерНабора {get; set;}
        [Description1C8(Name = "НеИспользуетсяВидДоступа", Comment = "Незаполненные значения нужно допустить, чтобы избежать ошибок при записи проверяемых объектов", Synonym = "Не используется вид доступа")]
        public ПланВидовХарактеристик.УдалитьВидыДоступа НеИспользуетсяВидДоступа {get; set;}
        [Description1C8(Name = "ЗначениеДоступа", Comment = "Незаполненные значения нужно допустить, чтобы избежать ошибок при записи проверяемых объектов", Synonym = "Значение доступа")]
        public Catalogs.ПапкиФайлов ЗначениеДоступа {get; set;}
        [Description1C8(Name = "Чтение", Comment = "", Synonym = "Чтение использует номер набора")]
        public bool Чтение {get; set;}
        [Description1C8(Name = "Добавление", Comment = "", Synonym = "Добавление использует номер набора")]
        public bool Добавление {get; set;}
        [Description1C8(Name = "Изменение", Comment = "", Synonym = "Изменение использует номер набора")]
        public bool Изменение {get; set;}
        [Description1C8(Name = "Удаление", Comment = "", Synonym = "Удаление использует номер набора")]
        public bool Удаление {get; set;}
        [Description1C8(Name = "Уточнение", Comment = "", Synonym = "Уточнение")]
        public Catalogs.ИдентификаторыОбъектовМетаданных Уточнение {get; set;}
    }
}
