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
    [Table("RehystratsyiaPererabotok")]
    [Description1C8(Name = "РегистрацияПереработок", Comment = "", Synonym = "Регистрация переработок")]
    public class РегистрацияПереработок:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "ПериодСуммированногоУчетаНачало", Comment = "", Synonym = "Период суммированного учета начало")]
        public DateTime ПериодСуммированногоУчетаНачало {get; set;}
        [Description1C8(Name = "ПериодСуммированногоУчетаОкончание", Comment = "", Synonym = "Период суммированного учета окончание")]
        public DateTime ПериодСуммированногоУчетаОкончание {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Руководитель", Comment = "", Synonym = "Руководитель")]
        public Catalogs.ФизическиеЛица Руководитель {get; set;}
        [Description1C8(Name = "ДолжностьРуководителя", Comment = "", Synonym = "Должность")]
        public Catalogs.Должности ДолжностьРуководителя {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "КраткийСоставДокумента", Comment = "", Synonym = "Сотрудники")]
        [StringLength(100)]
        public string КраткийСоставДокумента {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Сотрудники", Comment = "", Synonym = "Сотрудники")]
        public List<РегистрацияПереработок_Сотрудники> РегистрацияПереработокСотрудники {get;set;}
        [Description1C8(Name = "ФизическиеЛица", Comment = "", Synonym = "Физические лица")]
        public List<РегистрацияПереработок_ФизическиеЛица> РегистрацияПереработокФизическиеЛица {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Сотрудники", Comment = "", Synonym = "Сотрудники")]
    [Table("RehystratsyiaPererabotok_Sotrudnyky")]
    public class РегистрацияПереработок_Сотрудники
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "НормаЧасов", Comment = "", Synonym = "Норма")]
        // Format 7.2
        public decimal НормаЧасов {get; set;}
        [Description1C8(Name = "ОтработаноЧасов", Comment = "", Synonym = "Отработано")]
        // Format 7.2
        public decimal ОтработаноЧасов {get; set;}
        [Description1C8(Name = "ОтработаноЧасовВПраздники", Comment = "", Synonym = "в т.ч. в праздн.")]
        // Format 7.2
        public decimal ОтработаноЧасовВПраздники {get; set;}
        [Description1C8(Name = "Сверхурочно1_5", Comment = "", Synonym = "х1,5")]
        // Format 7.2
        public decimal Сверхурочно1_5 {get; set;}
        [Description1C8(Name = "Сверхурочно2", Comment = "", Synonym = "х2")]
        // Format 7.2
        public decimal Сверхурочно2 {get; set;}
        [Description1C8(Name = "СпособКомпенсацииПереработки", Comment = "", Synonym = "Способ компенсации")]
        public Enums.СпособыКомпенсацииПереработки СпособКомпенсацииПереработки {get; set;}
        [Description1C8(Name = "Сверхурочно0", Comment = "", Synonym = "Уже оплач. по повыш. тарифу")]
        // Format 7.2
        public decimal Сверхурочно0 {get; set;}
    }
    [Description1C8(Name = "ФизическиеЛица", Comment = "", Synonym = "Физические лица")]
    [Table("RehystratsyiaPererabotok_FyzycheskyeLytsa")]
    public class РегистрацияПереработок_ФизическиеЛица
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
    }
}
