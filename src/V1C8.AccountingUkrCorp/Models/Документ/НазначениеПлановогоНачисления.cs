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
    [Table("NaznachenyePlanovohoNachyslenyia")]
    [Description1C8(Name = "НазначениеПлановогоНачисления", Comment = "", Synonym = "Назначение планового начисления")]
    public class НазначениеПлановогоНачисления:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "Начисление", Comment = "", Synonym = "Начисление")]
        public ПланВидовРасчета.Начисления Начисление {get; set;}
        [Description1C8(Name = "ДатаНазначения", Comment = "", Synonym = "Дата назначения")]
        public DateTime ДатаНазначения {get; set;}
        [Description1C8(Name = "ДатаОкончания", Comment = "", Synonym = "Дата окончания")]
        public DateTime ДатаОкончания {get; set;}
        [Description1C8(Name = "КраткийСоставДокумента", Comment = "", Synonym = "Сотрудники")]
        [StringLength(100)]
        public string КраткийСоставДокумента {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Сотрудники", Comment = "", Synonym = "Сотрудники")]
        public List<НазначениеПлановогоНачисления_Сотрудники> НазначениеПлановогоНачисленияСотрудники {get;set;}
        [Description1C8(Name = "ПоказателиСотрудников", Comment = "", Synonym = "Показатели сотрудников")]
        public List<НазначениеПлановогоНачисления_ПоказателиСотрудников> НазначениеПлановогоНачисленияПоказателиСотрудников {get;set;}
        [Description1C8(Name = "ФизическиеЛица", Comment = "", Synonym = "Физические лица")]
        public List<НазначениеПлановогоНачисления_ФизическиеЛица> НазначениеПлановогоНачисленияФизическиеЛица {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Сотрудники", Comment = "", Synonym = "Сотрудники")]
    [Table("NaznachenyePlanovohoNachyslenyia_Sotrudnyky")]
    public class НазначениеПлановогоНачисления_Сотрудники
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "ДатаНазначения", Comment = "", Synonym = "Дата назначения")]
        public DateTime ДатаНазначения {get; set;}
        [Description1C8(Name = "ДатаОкончания", Comment = "", Synonym = "Дата окончания")]
        public DateTime ДатаОкончания {get; set;}
        [Description1C8(Name = "СовокупнаяТарифнаяСтавка", Comment = "", Synonym = "Совокупная тарифная ставка")]
        // Format 15.2
        public decimal СовокупнаяТарифнаяСтавка {get; set;}
        [Description1C8(Name = "ВидТарифнойСтавки", Comment = "", Synonym = "Вид тарифной ставки")]
        public Enums.ВидыТарифныхСтавок ВидТарифнойСтавки {get; set;}
        [Description1C8(Name = "Размер", Comment = "", Synonym = "Размер")]
        // Format 15.3
        public decimal Размер {get; set;}
    }
    [Description1C8(Name = "ПоказателиСотрудников", Comment = "", Synonym = "Показатели сотрудников")]
    [Table("NaznachenyePlanovohoNachyslenyia_PokazatelySotrudnykov")]
    public class НазначениеПлановогоНачисления_ПоказателиСотрудников
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "Показатель", Comment = "", Synonym = "Показатель")]
        public Catalogs.ПоказателиРасчетаЗарплаты Показатель {get; set;}
        [Description1C8(Name = "ДокументОснование", Comment = "", Synonym = "Документ основание")]
        public Документ.НазначениеПлановогоНачисления ДокументОснование {get; set;}
        [Description1C8(Name = "Значение", Comment = "", Synonym = "Значение")]
        // Format 15.4
        public decimal Значение {get; set;}
    }
    [Description1C8(Name = "ФизическиеЛица", Comment = "", Synonym = "Физические лица")]
    [Table("NaznachenyePlanovohoNachyslenyia_FyzycheskyeLytsa")]
    public class НазначениеПлановогоНачисления_ФизическиеЛица
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
    }
}
