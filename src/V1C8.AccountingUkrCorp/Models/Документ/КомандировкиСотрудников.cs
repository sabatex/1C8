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
    [Table("KomandyrovkySotrudnykov")]
    [Description1C8(Name = "КомандировкиСотрудников", Comment = "", Synonym = "Командировка группы")]
    public class КомандировкиСотрудников:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "КраткийСоставДокумента", Comment = "", Synonym = "Сотрудники")]
        [StringLength(100)]
        public string КраткийСоставДокумента {get; set;}
        [Description1C8(Name = "ДатаСобытия", Comment = "", Synonym = "Дата события")]
        public DateTime ДатаСобытия {get; set;}
        [Description1C8(Name = "Основание", Comment = "", Synonym = "Основание")]
        public string Основание {get; set;}
        [Description1C8(Name = "Руководитель", Comment = "", Synonym = "Руководитель")]
        public Catalogs.ФизическиеЛица Руководитель {get; set;}
        [Description1C8(Name = "ДолжностьРуководителя", Comment = "", Synonym = "Должность")]
        public Catalogs.Должности ДолжностьРуководителя {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "УдалитьДокументОснование", Comment = "", Synonym = "(не используется) документ основание")]
        [StringLength(10)]
        public string УдалитьДокументОснование {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Сотрудники", Comment = "", Synonym = "Сотрудники")]
        public List<КомандировкиСотрудников_Сотрудники> КомандировкиСотрудниковСотрудники {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Сотрудники", Comment = "", Synonym = "Сотрудники")]
    [Table("KomandyrovkySotrudnykov_Sotrudnyky")]
    public class КомандировкиСотрудников_Сотрудники
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "ДатаНачала", Comment = "", Synonym = "Дата начала")]
        public DateTime ДатаНачала {get; set;}
        [Description1C8(Name = "ДатаОкончания", Comment = "", Synonym = "Дата окончания")]
        public DateTime ДатаОкончания {get; set;}
        [Description1C8(Name = "ДнейВПути", Comment = "", Synonym = "Дней в пути")]
        // Format 3.0
        public long ДнейВПути {get; set;}
        [Description1C8(Name = "МестоНазначения", Comment = "", Synonym = "Страна, город")]
        public string МестоНазначения {get; set;}
        [Description1C8(Name = "ОрганизацияНазначения", Comment = "", Synonym = "Организация")]
        public string ОрганизацияНазначения {get; set;}
        [Description1C8(Name = "Цель", Comment = "", Synonym = "Цель")]
        public string Цель {get; set;}
        [Description1C8(Name = "КомандировкаЗаСчетСредств", Comment = "", Synonym = "Командировка за счет средств")]
        public string КомандировкаЗаСчетСредств {get; set;}
        [Description1C8(Name = "Командировка", Comment = "", Synonym = "Командировка")]
        public Документ.Командировка Командировка {get; set;}
    }
}
