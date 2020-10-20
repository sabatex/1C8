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
    [Table("ZaiavkaNaZakrytyeLytsevykhSchetovSotrudnykov")]
    [Description1C8(Name = "ЗаявкаНаЗакрытиеЛицевыхСчетовСотрудников", Comment = "", Synonym = "Заявка на закрытие лицевых счетов")]
    public class ЗаявкаНаЗакрытиеЛицевыхСчетовСотрудников:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "ЗарплатныйПроект", Comment = "", Synonym = "Зарплатный проект")]
        public Catalogs.ЗарплатныеПроекты ЗарплатныйПроект {get; set;}
        [Description1C8(Name = "НомерРеестра", Comment = "", Synonym = "Номер реестра")]
        // Format 10.0
        public long НомерРеестра {get; set;}
        [Description1C8(Name = "КраткийСоставДокумента", Comment = "", Synonym = "Сотрудники")]
        [StringLength(100)]
        public string КраткийСоставДокумента {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Сотрудники", Comment = "", Synonym = "Сотрудники")]
        public List<ЗаявкаНаЗакрытиеЛицевыхСчетовСотрудников_Сотрудники> ЗаявкаНаЗакрытиеЛицевыхСчетовСотрудниковСотрудники {get;set;}
        [Description1C8(Name = "ФиксацияИзменений", Comment = "", Synonym = "Фиксация изменений")]
        public List<ЗаявкаНаЗакрытиеЛицевыхСчетовСотрудников_ФиксацияИзменений> ЗаявкаНаЗакрытиеЛицевыхСчетовСотрудниковФиксацияИзменений {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Сотрудники", Comment = "", Synonym = "Сотрудники")]
    [Table("ZaiavkaNaZakrytyeLytsevykhSchetovSotrudnykov_Sotrudnyky")]
    public class ЗаявкаНаЗакрытиеЛицевыхСчетовСотрудников_Сотрудники
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "ДатаЗакрытия", Comment = "", Synonym = "Дата закрытия")]
        public DateTime ДатаЗакрытия {get; set;}
        [Description1C8(Name = "ЛицевойСчет", Comment = "", Synonym = "Лицевой счет")]
        [StringLength(20)]
        public string ЛицевойСчет {get; set;}
        [Description1C8(Name = "ИдентификаторСтрокиФикс", Comment = "", Synonym = "Идентификатор строки фикс")]
        // Format 5.0
        public long ИдентификаторСтрокиФикс {get; set;}
    }
    [Description1C8(Name = "ФиксацияИзменений", Comment = "", Synonym = "Фиксация изменений")]
    [Table("ZaiavkaNaZakrytyeLytsevykhSchetovSotrudnykov_FyksatsyiaYzmenenyi")]
    public class ЗаявкаНаЗакрытиеЛицевыхСчетовСотрудников_ФиксацияИзменений
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ИмяРеквизита", Comment = "", Synonym = "Имя реквизита")]
        public string ИмяРеквизита {get; set;}
        [Description1C8(Name = "Путь", Comment = "", Synonym = "Путь")]
        public string Путь {get; set;}
        [Description1C8(Name = "ИдентификаторСтроки", Comment = "", Synonym = "Идентификатор строки")]
        // Format 5.0
        public long ИдентификаторСтроки {get; set;}
    }
}
