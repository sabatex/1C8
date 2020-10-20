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
    [Table("YzmenenyePlanovykhNachyslenyi")]
    [Description1C8(Name = "ИзменениеПлановыхНачислений", Comment = "", Synonym = "Изменение плановых начислений")]
    public class ИзменениеПлановыхНачислений:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "ДолжностьПоШтатномуРасписанию", Comment = "", Synonym = "Должность")]
        public Catalogs.ШтатноеРасписание ДолжностьПоШтатномуРасписанию {get; set;}
        [Description1C8(Name = "Должность", Comment = "", Synonym = "Должность")]
        public Catalogs.Должности Должность {get; set;}
        [Description1C8(Name = "ДатаИзменения", Comment = "", Synonym = "Дата изменения")]
        public DateTime ДатаИзменения {get; set;}
        [Description1C8(Name = "ДатаОкончания", Comment = "", Synonym = "Дата окончания")]
        public DateTime ДатаОкончания {get; set;}
        [Description1C8(Name = "ИзменениеШтатногоРасписания", Comment = "", Synonym = "Основание")]
        public Документ.УтверждениеШтатногоРасписания ИзменениеШтатногоРасписания {get; set;}
        [Description1C8(Name = "ИдентификаторСтрокиПозиции", Comment = "", Synonym = "Идентификатор строки позиции")]
        // Format 5.0
        public long ИдентификаторСтрокиПозиции {get; set;}
        [Description1C8(Name = "КраткийСоставДокумента", Comment = "", Synonym = "Сотрудники")]
        [StringLength(100)]
        public string КраткийСоставДокумента {get; set;}
        [Description1C8(Name = "ЭтоОтражениеИзмененияШтатногоРасписания", Comment = "", Synonym = "Это отражение изменения штатного расписания")]
        public bool ЭтоОтражениеИзмененияШтатногоРасписания {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Начисления", Comment = "", Synonym = "Начисления")]
        public List<ИзменениеПлановыхНачислений_Начисления> ИзменениеПлановыхНачисленийНачисления {get;set;}
        [Description1C8(Name = "Сотрудники", Comment = "", Synonym = "Сотрудники")]
        public List<ИзменениеПлановыхНачислений_Сотрудники> ИзменениеПлановыхНачисленийСотрудники {get;set;}
        [Description1C8(Name = "НачисленияСотрудников", Comment = "", Synonym = "Начисления сотрудников")]
        public List<ИзменениеПлановыхНачислений_НачисленияСотрудников> ИзменениеПлановыхНачисленийНачисленияСотрудников {get;set;}
        [Description1C8(Name = "ПоказателиСотрудников", Comment = "", Synonym = "Показатели сотрудников")]
        public List<ИзменениеПлановыхНачислений_ПоказателиСотрудников> ИзменениеПлановыхНачисленийПоказателиСотрудников {get;set;}
        [Description1C8(Name = "ФизическиеЛица", Comment = "", Synonym = "Физические лица")]
        public List<ИзменениеПлановыхНачислений_ФизическиеЛица> ИзменениеПлановыхНачисленийФизическиеЛица {get;set;}
        [Description1C8(Name = "УдалитьПоказателиПозиции", Comment = "", Synonym = "Мин. и макс. показателей позиции")]
        public List<ИзменениеПлановыхНачислений_УдалитьПоказателиПозиции> ИзменениеПлановыхНачисленийУдалитьПоказателиПозиции {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Начисления", Comment = "", Synonym = "Начисления")]
    [Table("YzmenenyePlanovykhNachyslenyi_Nachyslenyia")]
    public class ИзменениеПлановыхНачислений_Начисления
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Начисление", Comment = "", Synonym = "Начисление")]
        public ПланВидовРасчета.Начисления Начисление {get; set;}
        [Description1C8(Name = "Действие", Comment = "", Synonym = "Действие")]
        public Enums.ДействияСНачислениямиИУдержаниями Действие {get; set;}
    }
    [Description1C8(Name = "Сотрудники", Comment = "", Synonym = "Сотрудники")]
    [Table("YzmenenyePlanovykhNachyslenyi_Sotrudnyky")]
    public class ИзменениеПлановыхНачислений_Сотрудники
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "ДатаИзменения", Comment = "", Synonym = "Дата изменения")]
        public DateTime ДатаИзменения {get; set;}
        [Description1C8(Name = "ДатаОкончания", Comment = "", Synonym = "Дата окончания")]
        public DateTime ДатаОкончания {get; set;}
        [Description1C8(Name = "СовокупнаяТарифнаяСтавка", Comment = "", Synonym = "Совокупная тарифная ставка")]
        // Format 15.2
        public decimal СовокупнаяТарифнаяСтавка {get; set;}
        [Description1C8(Name = "ВидТарифнойСтавки", Comment = "", Synonym = "Вид тарифной ставки")]
        public Enums.ВидыТарифныхСтавок ВидТарифнойСтавки {get; set;}
    }
    [Description1C8(Name = "НачисленияСотрудников", Comment = "", Synonym = "Начисления сотрудников")]
    [Table("YzmenenyePlanovykhNachyslenyi_NachyslenyiaSotrudnykov")]
    public class ИзменениеПлановыхНачислений_НачисленияСотрудников
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "Начисление", Comment = "", Synonym = "Начисление")]
        public ПланВидовРасчета.Начисления Начисление {get; set;}
        [Description1C8(Name = "ДокументОснование", Comment = "", Synonym = "Документ основание")]
        public Документ.НазначениеПлановогоНачисления ДокументОснование {get; set;}
        [Description1C8(Name = "Действие", Comment = "", Synonym = "Действие")]
        public Enums.ДействияСНачислениямиИУдержаниями Действие {get; set;}
        [Description1C8(Name = "Размер", Comment = "", Synonym = "Размер")]
        // Format 15.3
        public decimal Размер {get; set;}
    }
    [Description1C8(Name = "ПоказателиСотрудников", Comment = "", Synonym = "Показатели сотрудников")]
    [Table("YzmenenyePlanovykhNachyslenyi_PokazatelySotrudnykov")]
    public class ИзменениеПлановыхНачислений_ПоказателиСотрудников
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
    [Table("YzmenenyePlanovykhNachyslenyi_FyzycheskyeLytsa")]
    public class ИзменениеПлановыхНачислений_ФизическиеЛица
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
    }
    [Description1C8(Name = "УдалитьПоказателиПозиции", Comment = "", Synonym = "Мин. и макс. показателей позиции")]
    [Table("YzmenenyePlanovykhNachyslenyi_UdalytPokazatelyPozytsyy")]
    public class ИзменениеПлановыхНачислений_УдалитьПоказателиПозиции
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ЗначениеПоказателяМин", Comment = "", Synonym = "Значение показателя мин")]
        // Format 15.4
        public decimal ЗначениеПоказателяМин {get; set;}
        [Description1C8(Name = "ЗначениеПоказателяМакс", Comment = "", Synonym = "Значение показателя макс")]
        // Format 15.4
        public decimal ЗначениеПоказателяМакс {get; set;}
        [Description1C8(Name = "Показатель", Comment = "", Synonym = "Показатель")]
        public Catalogs.ПоказателиРасчетаЗарплаты Показатель {get; set;}
    }
}
