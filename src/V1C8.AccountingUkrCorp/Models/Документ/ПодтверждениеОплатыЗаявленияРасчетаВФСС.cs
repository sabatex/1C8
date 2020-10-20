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
    [Table("PodtverzhdenyeOplatyZaiavlenyiaRaschetaVFSS")]
    [Description1C8(Name = "ПодтверждениеОплатыЗаявленияРасчетаВФСС", Comment = "", Synonym = "Подтверждение оплаты заявления расчета в ФСС")]
    public class ПодтверждениеОплатыЗаявленияРасчетаВФСС:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "ЗаявлениеРасчетВФСС", Comment = "", Synonym = "Заявление расчет ВФСС")]
        public Документ.ЗаявлениеРасчетВФСС ЗаявлениеРасчетВФСС {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "ФондСоциальногоСтрахования", Comment = "", Synonym = "Фонд социального страхования")]
        public Enums.ВидыОбязательногоСтрахованияСотрудников ФондСоциальногоСтрахования {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "РасчетыСФондами", Comment = "", Synonym = "Расчеты с фондами")]
        public List<ПодтверждениеОплатыЗаявленияРасчетаВФСС_РасчетыСФондами> ПодтверждениеОплатыЗаявленияРасчетаВФССРасчетыСФондами {get;set;}
        [Description1C8(Name = "ФизическиеЛица", Comment = "", Synonym = "Физические лица")]
        public List<ПодтверждениеОплатыЗаявленияРасчетаВФСС_ФизическиеЛица> ПодтверждениеОплатыЗаявленияРасчетаВФССФизическиеЛица {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "РасчетыСФондами", Comment = "", Synonym = "Расчеты с фондами")]
    [Table("PodtverzhdenyeOplatyZaiavlenyiaRaschetaVFSS_RaschetySFondamy")]
    public class ПодтверждениеОплатыЗаявленияРасчетаВФСС_РасчетыСФондами
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Отклонено", Comment = "", Synonym = "Отклонено")]
        public bool Отклонено {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "СтатьяРасчетов", Comment = "", Synonym = "Статья расчетов")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяРасчетов {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "КоличествоДней", Comment = "", Synonym = "Количество дней")]
        // Format 10.0
        public long КоличествоДней {get; set;}
        [Description1C8(Name = "СуммаЛьготЧернобыльцы", Comment = "", Synonym = "Сумма льгот чернобыльцы")]
        // Format 15.2
        public decimal СуммаЛьготЧернобыльцы {get; set;}
        [Description1C8(Name = "ФондСоциальногоСтрахования", Comment = "", Synonym = "Фонд социального страхования")]
        public Enums.ВидыОбязательногоСтрахованияСотрудников ФондСоциальногоСтрахования {get; set;}
        [Description1C8(Name = "Месяц", Comment = "Месяц, которым сумма попадет в отчетность", Synonym = "Месяц")]
        public DateTime Месяц {get; set;}
        [Description1C8(Name = "ДокументОснование", Comment = "", Synonym = "Документ основание")]
        public Документ.ЕдиновременноеПособиеЗаСчетФСС ДокументОснование {get; set;}
    }
    [Description1C8(Name = "ФизическиеЛица", Comment = "", Synonym = "Физические лица")]
    [Table("PodtverzhdenyeOplatyZaiavlenyiaRaschetaVFSS_FyzycheskyeLytsa")]
    public class ПодтверждениеОплатыЗаявленияРасчетаВФСС_ФизическиеЛица
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
    }
}
