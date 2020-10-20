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
    [Table("ZarplatnyeProekty")]
    [Description1C8(Name = "ЗарплатныеПроекты", Comment = "", Synonym = "Зарплатные проекты")]
    public class ЗарплатныеПроекты:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Банк", Comment = "", Synonym = "Банк")]
        public Catalogs.Банки Банк {get; set;}
        [Description1C8(Name = "Валюта", Comment = "", Synonym = "Валюта")]
        public Catalogs.Валюты Валюта {get; set;}
        [Description1C8(Name = "ДатаДоговора", Comment = "", Synonym = "Дата договора")]
        public DateTime ДатаДоговора {get; set;}
        [Description1C8(Name = "ИспользоватьЭлектронныйДокументооборотСБанком", Comment = "При использовании, факт оплаты банком платежных ведомостей регистрируется в системе при загрузке файла подтверждения из банка", Synonym = "Использовать электронный документооборот с банком")]
        public bool ИспользоватьЭлектронныйДокументооборотСБанком {get; set;}
        [Description1C8(Name = "КодировкаФайла", Comment = "", Synonym = "Кодировка файла")]
        public Enums.КодировкаФайловОбменаПоЗарплатномуПроекту КодировкаФайла {get; set;}
        [Description1C8(Name = "НомерДоговора", Comment = "", Synonym = "Номер договора")]
        [StringLength(8)]
        public string НомерДоговора {get; set;}
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "ОтделениеБанка", Comment = "", Synonym = "Отделение банка")]
        [StringLength(4)]
        public string ОтделениеБанка {get; set;}
        [Description1C8(Name = "РасчетныйСчет", Comment = "", Synonym = "Расчетный счет")]
        [StringLength(20)]
        public string РасчетныйСчет {get; set;}
        [Description1C8(Name = "ФилиалОтделенияБанка", Comment = "", Synonym = "Филиал отделения банка")]
        [StringLength(4)]
        public string ФилиалОтделенияБанка {get; set;}
        [Description1C8(Name = "ФорматФайла", Comment = "", Synonym = "Формат файла")]
        public Enums.ФорматыФайловОбменаПоЗарплатномуПроекту ФорматФайла {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ДополнительныеРеквизиты", Comment = "", Synonym = "Дополнительные реквизиты")]
        public List<ЗарплатныеПроекты_ДополнительныеРеквизиты> ЗарплатныеПроектыДополнительныеРеквизиты {get;set;}
        [Description1C8(Name = "СистемыРасчетовПоБанковскимКартам", Comment = "", Synonym = "Системы расчетов по банковским картам")]
        public List<ЗарплатныеПроекты_СистемыРасчетовПоБанковскимКартам> ЗарплатныеПроектыСистемыРасчетовПоБанковскимКартам {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ДополнительныеРеквизиты", Comment = "", Synonym = "Дополнительные реквизиты")]
    [Table("ZarplatnyeProekty_DopolnytelnyeRekvyzyty")]
    public class ЗарплатныеПроекты_ДополнительныеРеквизиты
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
    [Description1C8(Name = "СистемыРасчетовПоБанковскимКартам", Comment = "", Synonym = "Системы расчетов по банковским картам")]
    [Table("ZarplatnyeProekty_SystemyRaschetovPoBankovskymKartam")]
    public class ЗарплатныеПроекты_СистемыРасчетовПоБанковскимКартам
    {
    public long Id {get;set;}
    public Guid Owner {get;set;}
        [Description1C8(Name = "СистемаРасчетовПоБанковскимКартам", Comment = "", Synonym = "Система расчетов")]
        public string СистемаРасчетовПоБанковскимКартам {get; set;}
    }
}
