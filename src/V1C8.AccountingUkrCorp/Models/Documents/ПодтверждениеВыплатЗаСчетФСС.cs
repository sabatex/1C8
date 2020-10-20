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
    [Table("PodtverzhdenyeVyplatZaSchetFSS")]
    [Description1C8(Name = "ПодтверждениеВыплатЗаСчетФСС", Comment = "", Synonym = "Подтверждение выплат за счет ФСС")]
    public class ПодтверждениеВыплатЗаСчетФСС:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "ПериодС", Comment = "", Synonym = "Период С")]
        public DateTime ПериодС {get; set;}
        [Description1C8(Name = "ПериодПо", Comment = "", Synonym = "Период по")]
        public DateTime ПериодПо {get; set;}
        [Description1C8(Name = "СтатусДокумента", Comment = "", Synonym = "Статус документа")]
        public Enums.СтатусыЗаявленийИРеестровНаВыплатуПособий СтатусДокумента {get; set;}
        [Description1C8(Name = "Руководитель", Comment = "", Synonym = "Руководитель")]
        public Catalogs.ФизическиеЛица Руководитель {get; set;}
        [Description1C8(Name = "ГлавныйБухгалтер", Comment = "", Synonym = "Главный бухгалтер")]
        public Catalogs.ФизическиеЛица ГлавныйБухгалтер {get; set;}
        [Description1C8(Name = "АдресОрганизации", Comment = "", Synonym = "Адрес организации")]
        public string АдресОрганизации {get; set;}
        [Description1C8(Name = "ТелефонОрганизации", Comment = "", Synonym = "Телефон организации")]
        public string ТелефонОрганизации {get; set;}
        [Description1C8(Name = "КодПоЕДРПОУ", Comment = "", Synonym = "Код по ЕДРПОУ")]
        [StringLength(10)]
        public string КодПоЕДРПОУ {get; set;}
        [Description1C8(Name = "НомерФССУ", Comment = "Номер регистрации ФСС Украины", Synonym = "Номер регистрации ФСС Украины")]
        [StringLength(20)]
        public string НомерФССУ {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Выплаты", Comment = "", Synonym = "Выплаты")]
        public List<ПодтверждениеВыплатЗаСчетФСС_Выплаты> ПодтверждениеВыплатЗаСчетФССВыплаты {get;set;}
        [Description1C8(Name = "ФизическиеЛица", Comment = "", Synonym = "Физические лица")]
        public List<ПодтверждениеВыплатЗаСчетФСС_ФизическиеЛица> ПодтверждениеВыплатЗаСчетФССФизическиеЛица {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Выплаты", Comment = "", Synonym = "Выплаты")]
    [Table("PodtverzhdenyeVyplatZaSchetFSS_Vyplaty")]
    public class ПодтверждениеВыплатЗаСчетФСС_Выплаты
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "ДокументОснование", Comment = "", Synonym = "Документ основание")]
        public Documents.ЕдиновременноеПособиеЗаСчетФСС ДокументОснование {get; set;}
        [Description1C8(Name = "ДатаВыплаты", Comment = "", Synonym = "Дата выплаты")]
        public DateTime ДатаВыплаты {get; set;}
        [Description1C8(Name = "Заявление", Comment = "", Synonym = "Заявление")]
        public Documents.ЗаявлениеРасчетВФСС Заявление {get; set;}
    }
    [Description1C8(Name = "ФизическиеЛица", Comment = "", Synonym = "Физические лица")]
    [Table("PodtverzhdenyeVyplatZaSchetFSS_FyzycheskyeLytsa")]
    public class ПодтверждениеВыплатЗаСчетФСС_ФизическиеЛица
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
    }
}
