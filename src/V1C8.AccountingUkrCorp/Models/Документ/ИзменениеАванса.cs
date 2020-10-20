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
    [Table("YzmenenyeAvansa")]
    [Description1C8(Name = "ИзменениеАванса", Comment = "", Synonym = "Изменение аванса")]
    public class ИзменениеАванса:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "СпособРасчетаАванса", Comment = "", Synonym = "Способ расчета аванса")]
        public Enums.СпособыРасчетаАванса СпособРасчетаАванса {get; set;}
        [Description1C8(Name = "МесяцИзменения", Comment = "", Synonym = "Месяц изменения")]
        public DateTime МесяцИзменения {get; set;}
        [Description1C8(Name = "ПериодОкончания", Comment = "", Synonym = "Период окончания")]
        public DateTime ПериодОкончания {get; set;}
        [Description1C8(Name = "КраткийСоставДокумента", Comment = "Краткий перечень сотрудников, включенных в документ", Synonym = "Сотрудники")]
        [StringLength(100)]
        public string КраткийСоставДокумента {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "АвансыСотрудников", Comment = "", Synonym = "Авансы сотрудников")]
        public List<ИзменениеАванса_АвансыСотрудников> ИзменениеАвансаАвансыСотрудников {get;set;}
        [Description1C8(Name = "ФизическиеЛица", Comment = "", Synonym = "Физические лица")]
        public List<ИзменениеАванса_ФизическиеЛица> ИзменениеАвансаФизическиеЛица {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "АвансыСотрудников", Comment = "", Synonym = "Авансы сотрудников")]
    [Table("YzmenenyeAvansa_AvansySotrudnykov")]
    public class ИзменениеАванса_АвансыСотрудников
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "Аванс", Comment = "", Synonym = "Аванс")]
        // Format 15.2
        public decimal Аванс {get; set;}
    }
    [Description1C8(Name = "ФизическиеЛица", Comment = "", Synonym = "Физические лица")]
    [Table("YzmenenyeAvansa_FyzycheskyeLytsa")]
    public class ИзменениеАванса_ФизическиеЛица
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
    }
}
