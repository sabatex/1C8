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
    [Table("YzmenenyeHrafykaRabotySpyskom")]
    [Description1C8(Name = "ИзменениеГрафикаРаботыСписком", Comment = "", Synonym = "Изменение графика работы списком")]
    public class ИзменениеГрафикаРаботыСписком:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "ГрафикРаботы", Comment = "", Synonym = "График работы")]
        public Catalogs.ГрафикиРаботыСотрудников ГрафикРаботы {get; set;}
        [Description1C8(Name = "Руководитель", Comment = "", Synonym = "Руководитель")]
        public Catalogs.ФизическиеЛица Руководитель {get; set;}
        [Description1C8(Name = "ДолжностьРуководителя", Comment = "", Synonym = "Должность")]
        public Catalogs.Должности ДолжностьРуководителя {get; set;}
        [Description1C8(Name = "ГлавныйБухгалтер", Comment = "", Synonym = "Главный бухгалтер")]
        public Catalogs.ФизическиеЛица ГлавныйБухгалтер {get; set;}
        [Description1C8(Name = "ИсправленныйДокумент", Comment = "", Synonym = "Исправленный документ")]
        public Документ.ИзменениеГрафикаРаботыСписком ИсправленныйДокумент {get; set;}
        [Description1C8(Name = "ДатаИзменения", Comment = "", Synonym = "Дата изменения")]
        public DateTime ДатаИзменения {get; set;}
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
        public List<ИзменениеГрафикаРаботыСписком_Сотрудники> ИзменениеГрафикаРаботыСпискомСотрудники {get;set;}
        [Description1C8(Name = "ФизическиеЛица", Comment = "", Synonym = "Физические лица")]
        public List<ИзменениеГрафикаРаботыСписком_ФизическиеЛица> ИзменениеГрафикаРаботыСпискомФизическиеЛица {get;set;}
        [Description1C8(Name = "НачисленияСотрудников", Comment = "", Synonym = "Начисления сотрудников")]
        public List<ИзменениеГрафикаРаботыСписком_НачисленияСотрудников> ИзменениеГрафикаРаботыСпискомНачисленияСотрудников {get;set;}
        [Description1C8(Name = "ПересчетТарифныхСтавок", Comment = "", Synonym = "Пересчет тарифных ставок")]
        public List<ИзменениеГрафикаРаботыСписком_ПересчетТарифныхСтавок> ИзменениеГрафикаРаботыСпискомПересчетТарифныхСтавок {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Сотрудники", Comment = "", Synonym = "Сотрудники")]
    [Table("YzmenenyeHrafykaRabotySpyskom_Sotrudnyky")]
    public class ИзменениеГрафикаРаботыСписком_Сотрудники
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "ФиксСтрока", Comment = "", Synonym = "Строка зафиксирована")]
        public bool ФиксСтрока {get; set;}
    }
    [Description1C8(Name = "ФизическиеЛица", Comment = "", Synonym = "Физические лица")]
    [Table("YzmenenyeHrafykaRabotySpyskom_FyzycheskyeLytsa")]
    public class ИзменениеГрафикаРаботыСписком_ФизическиеЛица
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
    }
    [Description1C8(Name = "НачисленияСотрудников", Comment = "", Synonym = "Начисления сотрудников")]
    [Table("YzmenenyeHrafykaRabotySpyskom_NachyslenyiaSotrudnykov")]
    public class ИзменениеГрафикаРаботыСписком_НачисленияСотрудников
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "Начисление", Comment = "", Synonym = "Начисление")]
        public ПланВидовРасчета.Начисления Начисление {get; set;}
        [Description1C8(Name = "ДокументОснование", Comment = "", Synonym = "Документ основание")]
        public Документ.НазначениеПлановогоНачисления ДокументОснование {get; set;}
        [Description1C8(Name = "Размер", Comment = "", Synonym = "Вклад в ФОТ")]
        // Format 15.2
        public decimal Размер {get; set;}
    }
    [Description1C8(Name = "ПересчетТарифныхСтавок", Comment = "", Synonym = "Пересчет тарифных ставок")]
    [Table("YzmenenyeHrafykaRabotySpyskom_PereschetTaryfnykhStavok")]
    public class ИзменениеГрафикаРаботыСписком_ПересчетТарифныхСтавок
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "СовокупнаяТарифнаяСтавка", Comment = "", Synonym = "Совокупная тарифная ставка")]
        // Format 15.2
        public decimal СовокупнаяТарифнаяСтавка {get; set;}
        [Description1C8(Name = "ВидТарифнойСтавки", Comment = "", Synonym = "Вид тарифной ставки")]
        public Enums.ВидыТарифныхСтавок ВидТарифнойСтавки {get; set;}
    }
}
