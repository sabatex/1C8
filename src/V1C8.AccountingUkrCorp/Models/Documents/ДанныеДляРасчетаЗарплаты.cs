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
    [Table("DannyeDliaRaschetaZarplaty")]
    [Description1C8(Name = "ДанныеДляРасчетаЗарплаты", Comment = "", Synonym = "Данные для расчета зарплаты")]
    public class ДанныеДляРасчетаЗарплаты:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "Период", Comment = "", Synonym = "Месяц")]
        public DateTime Период {get; set;}
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "ПериодОкончания", Comment = "", Synonym = "Дата окончания действия")]
        public DateTime ПериодОкончания {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "ВидДокумента", Comment = "", Synonym = "Вид документа")]
        public Catalogs.ВидыДокументовВводДанныхДляРасчетаЗарплаты ВидДокумента {get; set;}
        [Description1C8(Name = "КраткийСоставДокумента", Comment = "", Synonym = "Сотрудники")]
        [StringLength(100)]
        public string КраткийСоставДокумента {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ЗначенияПоказателей", Comment = "", Synonym = "Значения показателей")]
        public List<ДанныеДляРасчетаЗарплаты_ЗначенияПоказателей> ДанныеДляРасчетаЗарплатыЗначенияПоказателей {get;set;}
        [Description1C8(Name = "ДанныеОВремениСводно", Comment = "", Synonym = "Данные о времени (сводно)")]
        public List<ДанныеДляРасчетаЗарплаты_ДанныеОВремениСводно> ДанныеДляРасчетаЗарплатыДанныеОВремениСводно {get;set;}
        [Description1C8(Name = "ДанныеОВремениДетально", Comment = "", Synonym = "Данные о времени (детально)")]
        public List<ДанныеДляРасчетаЗарплаты_ДанныеОВремениДетально> ДанныеДляРасчетаЗарплатыДанныеОВремениДетально {get;set;}
        [Description1C8(Name = "ВыполненныеРаботы", Comment = "", Synonym = "Выполненные работы")]
        public List<ДанныеДляРасчетаЗарплаты_ВыполненныеРаботы> ДанныеДляРасчетаЗарплатыВыполненныеРаботы {get;set;}
        [Description1C8(Name = "ФизическиеЛица", Comment = "", Synonym = "Физические лица")]
        public List<ДанныеДляРасчетаЗарплаты_ФизическиеЛица> ДанныеДляРасчетаЗарплатыФизическиеЛица {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ЗначенияПоказателей", Comment = "", Synonym = "Значения показателей")]
    [Table("DannyeDliaRaschetaZarplaty_ZnachenyiaPokazatelei")]
    public class ДанныеДляРасчетаЗарплаты_ЗначенияПоказателей
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Объект", Comment = "", Synonym = "Объект")]
        public Catalogs.ПодразделенияОрганизаций Объект {get; set;}
        [Description1C8(Name = "Показатель", Comment = "", Synonym = "Показатель")]
        public Catalogs.ПоказателиРасчетаЗарплаты Показатель {get; set;}
        [Description1C8(Name = "Значение", Comment = "", Synonym = "Значение")]
        // Format 15.4
        public decimal Значение {get; set;}
        [Description1C8(Name = "Период", Comment = "", Synonym = "Период")]
        public DateTime Период {get; set;}
        [Description1C8(Name = "ПериодОкончания", Comment = "", Synonym = "Период окончания")]
        public DateTime ПериодОкончания {get; set;}
        [Description1C8(Name = "Коэффициент", Comment = "", Synonym = "Коэффициент")]
        // Format 15.3
        public decimal Коэффициент {get; set;}
        [Description1C8(Name = "ТарифнаяСтавка", Comment = "", Synonym = "Тарифная ставка")]
        // Format 15.3
        public decimal ТарифнаяСтавка {get; set;}
        [Description1C8(Name = "ВремяВЧасах", Comment = "", Synonym = "Время в часах")]
        public bool ВремяВЧасах {get; set;}
        [Description1C8(Name = "ОтработаноДней", Comment = "", Synonym = "Отработано дней")]
        // Format 2.0
        public long ОтработаноДней {get; set;}
        [Description1C8(Name = "ОтработаноЧасов", Comment = "", Synonym = "Отработано часов")]
        // Format 5.2
        public decimal ОтработаноЧасов {get; set;}
        [Description1C8(Name = "ФиксТарифнаяСтавка", Comment = "", Synonym = "Фикс тарифная ставка")]
        public bool ФиксТарифнаяСтавка {get; set;}
        [Description1C8(Name = "ФиксОтработанноеВремя", Comment = "", Synonym = "Фикс отработанное время")]
        public bool ФиксОтработанноеВремя {get; set;}
        [Description1C8(Name = "ФиксЗначение", Comment = "", Synonym = "Фикс значение")]
        public bool ФиксЗначение {get; set;}
    }
    [Description1C8(Name = "ДанныеОВремениСводно", Comment = "", Synonym = "Данные о времени (сводно)")]
    [Table("DannyeDliaRaschetaZarplaty_DannyeOVremenySvodno")]
    public class ДанныеДляРасчетаЗарплаты_ДанныеОВремениСводно
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "ВидВремени", Comment = "", Synonym = "Вид времени")]
        public Catalogs.ВидыИспользованияРабочегоВремени ВидВремени {get; set;}
        [Description1C8(Name = "Дней", Comment = "", Synonym = "Дней")]
        // Format 2.0
        public long Дней {get; set;}
        [Description1C8(Name = "Часов", Comment = "", Synonym = "Часов")]
        // Format 5.2
        public decimal Часов {get; set;}
    }
    [Description1C8(Name = "ДанныеОВремениДетально", Comment = "", Synonym = "Данные о времени (детально)")]
    [Table("DannyeDliaRaschetaZarplaty_DannyeOVremenyDetalno")]
    public class ДанныеДляРасчетаЗарплаты_ДанныеОВремениДетально
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "ВидВремени", Comment = "", Synonym = "Вид времени")]
        public Catalogs.ВидыИспользованияРабочегоВремени ВидВремени {get; set;}
        [Description1C8(Name = "Часов1", Comment = "", Synonym = "Часов1")]
        // Format 4.2
        public decimal Часов1 {get; set;}
        [Description1C8(Name = "Часов2", Comment = "", Synonym = "Часов2")]
        // Format 4.2
        public decimal Часов2 {get; set;}
        [Description1C8(Name = "Часов3", Comment = "", Synonym = "Часов3")]
        // Format 4.2
        public decimal Часов3 {get; set;}
        [Description1C8(Name = "Часов4", Comment = "", Synonym = "Часов4")]
        // Format 4.2
        public decimal Часов4 {get; set;}
        [Description1C8(Name = "Часов5", Comment = "", Synonym = "Часов5")]
        // Format 4.2
        public decimal Часов5 {get; set;}
        [Description1C8(Name = "Часов6", Comment = "", Synonym = "Часов6")]
        // Format 4.2
        public decimal Часов6 {get; set;}
        [Description1C8(Name = "Часов7", Comment = "", Synonym = "Часов7")]
        // Format 4.2
        public decimal Часов7 {get; set;}
        [Description1C8(Name = "Часов8", Comment = "", Synonym = "Часов8")]
        // Format 4.2
        public decimal Часов8 {get; set;}
        [Description1C8(Name = "Часов9", Comment = "", Synonym = "Часов9")]
        // Format 4.2
        public decimal Часов9 {get; set;}
        [Description1C8(Name = "Часов10", Comment = "", Synonym = "Часов10")]
        // Format 4.2
        public decimal Часов10 {get; set;}
        [Description1C8(Name = "Часов11", Comment = "", Synonym = "Часов11")]
        // Format 4.2
        public decimal Часов11 {get; set;}
        [Description1C8(Name = "Часов12", Comment = "", Synonym = "Часов12")]
        // Format 4.2
        public decimal Часов12 {get; set;}
        [Description1C8(Name = "Часов13", Comment = "", Synonym = "Часов13")]
        // Format 4.2
        public decimal Часов13 {get; set;}
        [Description1C8(Name = "Часов14", Comment = "", Synonym = "Часов14")]
        // Format 4.2
        public decimal Часов14 {get; set;}
        [Description1C8(Name = "Часов15", Comment = "", Synonym = "Часов15")]
        // Format 4.2
        public decimal Часов15 {get; set;}
        [Description1C8(Name = "Часов16", Comment = "", Synonym = "Часов16")]
        // Format 4.2
        public decimal Часов16 {get; set;}
        [Description1C8(Name = "Часов17", Comment = "", Synonym = "Часов17")]
        // Format 4.2
        public decimal Часов17 {get; set;}
        [Description1C8(Name = "Часов18", Comment = "", Synonym = "Часов18")]
        // Format 4.2
        public decimal Часов18 {get; set;}
        [Description1C8(Name = "Часов19", Comment = "", Synonym = "Часов19")]
        // Format 4.2
        public decimal Часов19 {get; set;}
        [Description1C8(Name = "Часов20", Comment = "", Synonym = "Часов20")]
        // Format 4.2
        public decimal Часов20 {get; set;}
        [Description1C8(Name = "Часов21", Comment = "", Synonym = "Часов21")]
        // Format 4.2
        public decimal Часов21 {get; set;}
        [Description1C8(Name = "Часов22", Comment = "", Synonym = "Часов22")]
        // Format 4.2
        public decimal Часов22 {get; set;}
        [Description1C8(Name = "Часов23", Comment = "", Synonym = "Часов23")]
        // Format 4.2
        public decimal Часов23 {get; set;}
        [Description1C8(Name = "Часов24", Comment = "", Synonym = "Часов24")]
        // Format 4.2
        public decimal Часов24 {get; set;}
        [Description1C8(Name = "Часов25", Comment = "", Synonym = "Часов25")]
        // Format 4.2
        public decimal Часов25 {get; set;}
        [Description1C8(Name = "Часов26", Comment = "", Synonym = "Часов26")]
        // Format 4.2
        public decimal Часов26 {get; set;}
        [Description1C8(Name = "Часов27", Comment = "", Synonym = "Часов27")]
        // Format 4.2
        public decimal Часов27 {get; set;}
        [Description1C8(Name = "Часов28", Comment = "", Synonym = "Часов28")]
        // Format 4.2
        public decimal Часов28 {get; set;}
        [Description1C8(Name = "Часов29", Comment = "", Synonym = "Часов29")]
        // Format 4.2
        public decimal Часов29 {get; set;}
        [Description1C8(Name = "Часов30", Comment = "", Synonym = "Часов30")]
        // Format 4.2
        public decimal Часов30 {get; set;}
        [Description1C8(Name = "Часов31", Comment = "", Synonym = "1")]
        // Format 4.2
        public decimal Часов31 {get; set;}
    }
    [Description1C8(Name = "ВыполненныеРаботы", Comment = "", Synonym = "Выполненные работы")]
    [Table("DannyeDliaRaschetaZarplaty_VypolnennyeRaboty")]
    public class ДанныеДляРасчетаЗарплаты_ВыполненныеРаботы
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "ВидРабот", Comment = "", Synonym = "Вид работ")]
        public Catalogs.ВидыРаботСотрудников ВидРабот {get; set;}
        [Description1C8(Name = "ОбъемВыполненныхРабот", Comment = "", Synonym = "Объем выполненных работ")]
        // Format 15.3
        public decimal ОбъемВыполненныхРабот {get; set;}
        [Description1C8(Name = "Период", Comment = "", Synonym = "Дата")]
        public DateTime Период {get; set;}
        [Description1C8(Name = "Расценка", Comment = "", Synonym = "Расценка")]
        // Format 15.3
        public decimal Расценка {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
    }
    [Description1C8(Name = "ФизическиеЛица", Comment = "", Synonym = "Физические лица")]
    [Table("DannyeDliaRaschetaZarplaty_FyzycheskyeLytsa")]
    public class ДанныеДляРасчетаЗарплаты_ФизическиеЛица
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
    }
}
