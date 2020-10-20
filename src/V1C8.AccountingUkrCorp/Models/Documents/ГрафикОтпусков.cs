using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Documents
{
    [Table("HrafykOtpuskov")]
    [Description1C8(Name = "ГрафикОтпусков", Comment = "", Synonym = "График отпусков")]
    public class ГрафикОтпусков:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "КраткийСоставДокумента", Comment = "", Synonym = "Сотрудники")]
        [StringLength(100)]
        public string КраткийСоставДокумента {get; set;}
        [Description1C8(Name = "ДатаВычисленияОстатков", Comment = "", Synonym = "Дата остатков")]
        public DateTime ДатаВычисленияОстатков {get; set;}
        [Description1C8(Name = "ДатаСобытия", Comment = "", Synonym = "Дата события")]
        public DateTime ДатаСобытия {get; set;}
        [Description1C8(Name = "Руководитель", Comment = "", Synonym = "Руководитель")]
        public Catalogs.ФизическиеЛица Руководитель {get; set;}
        [Description1C8(Name = "ДолжностьРуководителя", Comment = "", Synonym = "Должность руководителя")]
        public Catalogs.Должности ДолжностьРуководителя {get; set;}
        [Description1C8(Name = "РуководительКадровойСлужбы", Comment = "", Synonym = "Руководитель кадровой службы")]
        public Catalogs.ФизическиеЛица РуководительКадровойСлужбы {get; set;}
        [Description1C8(Name = "ДолжностьРуководителяКадровойСлужбы", Comment = "", Synonym = "Должность руководителя кадровой службы")]
        public Catalogs.Должности ДолжностьРуководителяКадровойСлужбы {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Сотрудники", Comment = "", Synonym = "Сотрудники")]
        public List<ГрафикОтпусков_Сотрудники> ГрафикОтпусковСотрудники {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Сотрудники", Comment = "", Synonym = "Сотрудники")]
    [Table("HrafykOtpuskov_Sotrudnyky")]
    public class ГрафикОтпусков_Сотрудники
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
        [Description1C8(Name = "КоличествоДней", Comment = "", Synonym = "Количество дней")]
        // Format 3.0
        public long КоличествоДней {get; set;}
        [Description1C8(Name = "УдалитьНачалоПериодаЗаКоторыйПредоставляетсяОтпуск", Comment = "", Synonym = "(не используется) начало периода за который предоставляется отпуск")]
        public DateTime УдалитьНачалоПериодаЗаКоторыйПредоставляетсяОтпуск {get; set;}
        [Description1C8(Name = "УдалитьКонецПериодаЗаКоторыйПредоставляетсяОтпуск", Comment = "", Synonym = "(не используется) конец периода за который предоставляется отпуск")]
        public DateTime УдалитьКонецПериодаЗаКоторыйПредоставляетсяОтпуск {get; set;}
    }
}
