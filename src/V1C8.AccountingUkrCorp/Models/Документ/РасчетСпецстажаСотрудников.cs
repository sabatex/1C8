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
    [Table("RaschetSpetsstazhaSotrudnykov")]
    [Description1C8(Name = "РасчетСпецстажаСотрудников", Comment = "", Synonym = "Расчет спецстажа сотрудников")]
    public class РасчетСпецстажаСотрудников:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "ПериодРегистрации", Comment = "", Synonym = "Период регистрации")]
        public DateTime ПериодРегистрации {get; set;}
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "КраткийСоставДокумента", Comment = "", Synonym = "Краткий состав документа")]
        [StringLength(100)]
        public string КраткийСоставДокумента {get; set;}
        [Description1C8(Name = "ПодразделениеОрганизации", Comment = "", Synonym = "Подразделение организации")]
        public Catalogs.ПодразделенияОрганизаций ПодразделениеОрганизации {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Спецстаж", Comment = "", Synonym = "Спецстаж")]
        public List<РасчетСпецстажаСотрудников_Спецстаж> РасчетСпецстажаСотрудниковСпецстаж {get;set;}
        [Description1C8(Name = "ФизическиеЛица", Comment = "", Synonym = "Физические лица")]
        public List<РасчетСпецстажаСотрудников_ФизическиеЛица> РасчетСпецстажаСотрудниковФизическиеЛица {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Спецстаж", Comment = "", Synonym = "Спецстаж")]
    [Table("RaschetSpetsstazhaSotrudnykov_Spetsstazh")]
    public class РасчетСпецстажаСотрудников_Спецстаж
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "ОснованияСпецСтажа", Comment = "", Synonym = "Основания спецстажа")]
        public Catalogs.ОснованияСпециальногоСтажа ОснованияСпецСтажа {get; set;}
        [Description1C8(Name = "ДатаНачала", Comment = "", Synonym = "Дата начала")]
        public DateTime ДатаНачала {get; set;}
        [Description1C8(Name = "ДатаОкончания", Comment = "", Synonym = "Дата окончания")]
        public DateTime ДатаОкончания {get; set;}
        [Description1C8(Name = "ЕдиницаВремени", Comment = "", Synonym = "Единица времени")]
        public Enums.ЕдиницыВремениУчетаСпецстажа ЕдиницаВремени {get; set;}
        [Description1C8(Name = "ГрафикНормы", Comment = "", Synonym = "График нормы")]
        public Catalogs.ГрафикиРаботыСотрудников ГрафикНормы {get; set;}
        [Description1C8(Name = "Сезонность", Comment = "", Synonym = "Сезонность")]
        // Format 1.0
        public long Сезонность {get; set;}
        [Description1C8(Name = "Результат", Comment = "", Synonym = "Результат")]
        // Format 15.2
        public decimal Результат {get; set;}
        [Description1C8(Name = "Норма", Comment = "", Synonym = "Норма")]
        // Format 15.2
        public decimal Норма {get; set;}
        [Description1C8(Name = "Приказ", Comment = "", Synonym = "Приказ")]
        public Документ.АттестацияРабочихМестДляУчетаСпецстажа Приказ {get; set;}
    }
    [Description1C8(Name = "ФизическиеЛица", Comment = "", Synonym = "Физические лица")]
    [Table("RaschetSpetsstazhaSotrudnykov_FyzycheskyeLytsa")]
    public class РасчетСпецстажаСотрудников_ФизическиеЛица
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
    }
}
