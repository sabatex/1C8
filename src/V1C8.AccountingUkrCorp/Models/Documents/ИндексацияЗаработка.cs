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
    [Table("YndeksatsyiaZarabotka")]
    [Description1C8(Name = "ИндексацияЗаработка", Comment = "", Synonym = "Индексация заработка")]
    public class ИндексацияЗаработка:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "МесяцИндексации", Comment = "", Synonym = "Месяц индексации")]
        public DateTime МесяцИндексации {get; set;}
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "КоэффициентИндексации", Comment = "", Synonym = "Коэффициент индексации")]
        // Format 5.4
        public decimal КоэффициентИндексации {get; set;}
        [Description1C8(Name = "Руководитель", Comment = "", Synonym = "Руководитель")]
        public Catalogs.ФизическиеЛица Руководитель {get; set;}
        [Description1C8(Name = "ДолжностьРуководителя", Comment = "", Synonym = "Должность")]
        public Catalogs.Должности ДолжностьРуководителя {get; set;}
        [Description1C8(Name = "ГлавныйБухгалтер", Comment = "", Synonym = "Главный бухгалтер")]
        public Catalogs.ФизическиеЛица ГлавныйБухгалтер {get; set;}
        [Description1C8(Name = "КраткийСоставДокумента", Comment = "", Synonym = "Сотрудники")]
        [StringLength(100)]
        public string КраткийСоставДокумента {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "УстановитьБазовыйПериод", Comment = "", Synonym = "Установить базовый период")]
        public bool УстановитьБазовыйПериод {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Сотрудники", Comment = "", Synonym = "Сотрудники")]
        public List<ИндексацияЗаработка_Сотрудники> ИндексацияЗаработкаСотрудники {get;set;}
        [Description1C8(Name = "ФизическиеЛица", Comment = "", Synonym = "Физические лица")]
        public List<ИндексацияЗаработка_ФизическиеЛица> ИндексацияЗаработкаФизическиеЛица {get;set;}
        [Description1C8(Name = "Показатели", Comment = "", Synonym = "Показатели")]
        public List<ИндексацияЗаработка_Показатели> ИндексацияЗаработкаПоказатели {get;set;}
        [Description1C8(Name = "ЗначенияПоказателей", Comment = "", Synonym = "Значения показателей")]
        public List<ИндексацияЗаработка_ЗначенияПоказателей> ИндексацияЗаработкаЗначенияПоказателей {get;set;}
        [Description1C8(Name = "НачисленияСотрудников", Comment = "", Synonym = "Начисления сотрудников")]
        public List<ИндексацияЗаработка_НачисленияСотрудников> ИндексацияЗаработкаНачисленияСотрудников {get;set;}
        [Description1C8(Name = "ПересчетТарифныхСтавок", Comment = "", Synonym = "Пересчет тарифных ставок")]
        public List<ИндексацияЗаработка_ПересчетТарифныхСтавок> ИндексацияЗаработкаПересчетТарифныхСтавок {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Сотрудники", Comment = "", Synonym = "Сотрудники")]
    [Table("YndeksatsyiaZarabotka_Sotrudnyky")]
    public class ИндексацияЗаработка_Сотрудники
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "КоэффициентИндексации", Comment = "", Synonym = "Коэффициент индексации")]
        // Format 9.8
        public decimal КоэффициентИндексации {get; set;}
        [Description1C8(Name = "ФиксСтрока", Comment = "", Synonym = "Строка зафиксирована")]
        public bool ФиксСтрока {get; set;}
        [Description1C8(Name = "ДолжностьПоШтатномуРасписанию", Comment = "", Synonym = "Должность по штатному расписанию")]
        public Catalogs.ШтатноеРасписание ДолжностьПоШтатномуРасписанию {get; set;}
    }
    [Description1C8(Name = "ФизическиеЛица", Comment = "", Synonym = "Физические лица")]
    [Table("YndeksatsyiaZarabotka_FyzycheskyeLytsa")]
    public class ИндексацияЗаработка_ФизическиеЛица
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
    }
    [Description1C8(Name = "Показатели", Comment = "", Synonym = "Показатели")]
    [Table("YndeksatsyiaZarabotka_Pokazately")]
    public class ИндексацияЗаработка_Показатели
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Показатель", Comment = "", Synonym = "Показатель")]
        public Catalogs.ПоказателиРасчетаЗарплаты Показатель {get; set;}
        [Description1C8(Name = "СпособОкругления", Comment = "", Synonym = "Округление")]
        public Catalogs.СпособыОкругленияПриРасчетеЗарплаты СпособОкругления {get; set;}
    }
    [Description1C8(Name = "ЗначенияПоказателей", Comment = "", Synonym = "Значения показателей")]
    [Table("YndeksatsyiaZarabotka_ZnachenyiaPokazatelei")]
    public class ИндексацияЗаработка_ЗначенияПоказателей
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "Показатель", Comment = "", Synonym = "Показатель")]
        public Catalogs.ПоказателиРасчетаЗарплаты Показатель {get; set;}
        [Description1C8(Name = "ДокументОснование", Comment = "", Synonym = "Документ основание")]
        public Documents.НазначениеПлановогоНачисления ДокументОснование {get; set;}
        [Description1C8(Name = "Значение", Comment = "", Synonym = "Значение")]
        // Format 15.4
        public decimal Значение {get; set;}
    }
    [Description1C8(Name = "НачисленияСотрудников", Comment = "", Synonym = "Начисления сотрудников")]
    [Table("YndeksatsyiaZarabotka_NachyslenyiaSotrudnykov")]
    public class ИндексацияЗаработка_НачисленияСотрудников
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "Начисление", Comment = "", Synonym = "Начисление")]
        public ПланВидовРасчета.Начисления Начисление {get; set;}
        [Description1C8(Name = "ДокументОснование", Comment = "", Synonym = "Документ основание")]
        public Documents.НазначениеПлановогоНачисления ДокументОснование {get; set;}
        [Description1C8(Name = "Размер", Comment = "", Synonym = "Вклад в ФОТ")]
        // Format 15.2
        public decimal Размер {get; set;}
    }
    [Description1C8(Name = "ПересчетТарифныхСтавок", Comment = "", Synonym = "Пересчет тарифных ставок")]
    [Table("YndeksatsyiaZarabotka_PereschetTaryfnykhStavok")]
    public class ИндексацияЗаработка_ПересчетТарифныхСтавок
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
