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
    [Table("AktProverkyStrakhovykhVznosov")]
    [Description1C8(Name = "АктПроверкиСтраховыхВзносов", Comment = "", Synonym = "Доначисление страховых взносов")]
    public class АктПроверкиСтраховыхВзносов:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "ПериодРегистрации", Comment = "", Synonym = "Период регистрации")]
        public DateTime ПериодРегистрации {get; set;}
        [Description1C8(Name = "ОснованиеДляДоначисления", Comment = "", Synonym = "Основание для доначисления")]
        public Enums.ОснованияДляДоначисленияСтраховыхВзносов ОснованиеДляДоначисления {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "КраткийСоставДокумента", Comment = "", Synonym = "Сотрудники")]
        [StringLength(100)]
        public string КраткийСоставДокумента {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ВзносыФОТ", Comment = "", Synonym = "Взносы ФОТ")]
        public List<АктПроверкиСтраховыхВзносов_ВзносыФОТ> АктПроверкиСтраховыхВзносовВзносыФОТ {get;set;}
        [Description1C8(Name = "ФизическиеЛица", Comment = "", Synonym = "Физические лица")]
        public List<АктПроверкиСтраховыхВзносов_ФизическиеЛица> АктПроверкиСтраховыхВзносовФизическиеЛица {get;set;}
        [Description1C8(Name = "Взносы", Comment = "", Synonym = "Взносы")]
        public List<АктПроверкиСтраховыхВзносов_Взносы> АктПроверкиСтраховыхВзносовВзносы {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ВзносыФОТ", Comment = "", Synonym = "Взносы ФОТ")]
    [Table("AktProverkyStrakhovykhVznosov_VznosyFOT")]
    public class АктПроверкиСтраховыхВзносов_ВзносыФОТ
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "МесяцРасчетногоПериода", Comment = "", Synonym = "Месяц расчетного периода")]
        public DateTime МесяцРасчетногоПериода {get; set;}
        [Description1C8(Name = "ВидЕСВ", Comment = "", Synonym = "Вид ЕСВ")]
        public Enums.ВидыЕСВ ВидЕСВ {get; set;}
        [Description1C8(Name = "КатегорияЕСВ", Comment = "", Synonym = "Категория ЕСВ")]
        public Catalogs.КатегорииЗастрахованныхЛицЕСВ КатегорияЕСВ {get; set;}
        [Description1C8(Name = "Налог", Comment = "", Synonym = "Налог")]
        public Catalogs.Налоги Налог {get; set;}
        [Description1C8(Name = "СтатьяНалоговойДекларации", Comment = "", Synonym = "Статья налоговой декларации")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяНалоговойДекларации {get; set;}
        [Description1C8(Name = "База", Comment = "", Synonym = "База")]
        // Format 16.2
        public decimal База {get; set;}
        [Description1C8(Name = "БазаВзноса", Comment = "База налога с учетом ограничений", Synonym = "База взноса")]
        // Format 16.2
        public decimal БазаВзноса {get; set;}
        [Description1C8(Name = "Результат", Comment = "", Synonym = "Результат")]
        // Format 16.2
        public decimal Результат {get; set;}
        [Description1C8(Name = "ТипНачисления", Comment = "", Synonym = "Тип начисления")]
        // Format 2.0
        public long ТипНачисления {get; set;}
    }
    [Description1C8(Name = "ФизическиеЛица", Comment = "", Synonym = "Физические лица")]
    [Table("AktProverkyStrakhovykhVznosov_FyzycheskyeLytsa")]
    public class АктПроверкиСтраховыхВзносов_ФизическиеЛица
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
    }
    [Description1C8(Name = "Взносы", Comment = "", Synonym = "Взносы")]
    [Table("AktProverkyStrakhovykhVznosov_Vznosy")]
    public class АктПроверкиСтраховыхВзносов_Взносы
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ВидЕСВ", Comment = "", Synonym = "Вид ЕСВ")]
        public Enums.ВидыЕСВ ВидЕСВ {get; set;}
        [Description1C8(Name = "КатегорияЕСВ", Comment = "", Synonym = "Категория ЕСВ")]
        public Catalogs.КатегорииЗастрахованныхЛицЕСВ КатегорияЕСВ {get; set;}
        [Description1C8(Name = "Налог", Comment = "", Synonym = "Налог")]
        public Catalogs.Налоги Налог {get; set;}
        [Description1C8(Name = "СтатьяНалоговойДекларации", Comment = "", Synonym = "Статья налоговой декларации")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяНалоговойДекларации {get; set;}
        [Description1C8(Name = "База", Comment = "", Synonym = "База")]
        // Format 16.2
        public decimal База {get; set;}
        [Description1C8(Name = "БазаВзноса", Comment = "База налога с учетом ограничений", Synonym = "База взноса")]
        // Format 16.2
        public decimal БазаВзноса {get; set;}
        [Description1C8(Name = "Результат", Comment = "", Synonym = "Результат")]
        // Format 16.6
        public decimal Результат {get; set;}
        [Description1C8(Name = "ТипНачисления", Comment = "", Synonym = "Тип начисления")]
        // Format 2.0
        public long ТипНачисления {get; set;}
        [Description1C8(Name = "МесяцРасчетногоПериода", Comment = "", Synonym = "Месяц расчетного периода")]
        public DateTime МесяцРасчетногоПериода {get; set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
    }
}
