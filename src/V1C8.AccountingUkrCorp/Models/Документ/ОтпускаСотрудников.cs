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
    [Table("OtpuskaSotrudnykov")]
    [Description1C8(Name = "ОтпускаСотрудников", Comment = "", Synonym = "Отпуск сотрудников")]
    public class ОтпускаСотрудников:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "КраткийСоставДокумента", Comment = "", Synonym = "Сотрудники")]
        [StringLength(100)]
        public string КраткийСоставДокумента {get; set;}
        [Description1C8(Name = "ДатаСобытия", Comment = "", Synonym = "Дата события")]
        public DateTime ДатаСобытия {get; set;}
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
        public List<ОтпускаСотрудников_Сотрудники> ОтпускаСотрудниковСотрудники {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Сотрудники", Comment = "", Synonym = "Сотрудники")]
    [Table("OtpuskaSotrudnykov_Sotrudnyky")]
    public class ОтпускаСотрудников_Сотрудники
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "ВидОтпуска", Comment = "", Synonym = "Вид отпуска")]
        public Catalogs.ВидыОтпусков ВидОтпуска {get; set;}
        [Description1C8(Name = "ДатаНачала", Comment = "", Synonym = "Дата начала")]
        public DateTime ДатаНачала {get; set;}
        [Description1C8(Name = "ДатаОкончания", Comment = "", Synonym = "Дата окончания")]
        public DateTime ДатаОкончания {get; set;}
        [Description1C8(Name = "НачалоПериодаЗаКоторыйПредоставляетсяОтпуск", Comment = "", Synonym = "Начало периода за который предоставляется отпуск")]
        public DateTime НачалоПериодаЗаКоторыйПредоставляетсяОтпуск {get; set;}
        [Description1C8(Name = "КонецПериодаЗаКоторыйПредоставляетсяОтпуск", Comment = "", Synonym = "Конец периода за который предоставляется отпуск")]
        public DateTime КонецПериодаЗаКоторыйПредоставляетсяОтпуск {get; set;}
        [Description1C8(Name = "Основание", Comment = "", Synonym = "Основание")]
        public string Основание {get; set;}
        [Description1C8(Name = "КоличествоДней", Comment = "", Synonym = "Количество дней")]
        // Format 3.0
        public long КоличествоДней {get; set;}
        [Description1C8(Name = "КоличествоДнейКомпенсации", Comment = "", Synonym = "Количество дней компенсации")]
        // Format 5.2
        public decimal КоличествоДнейКомпенсации {get; set;}
    }
}
