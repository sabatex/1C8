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
    [Table("UstareloNachyslenyeZarplaty")]
    [Description1C8(Name = "УстарелоНачислениеЗарплаты", Comment = "(Регл)", Synonym = "ѳ(устарело)  Начисление зарплаты")]
    public class УстарелоНачислениеЗарплаты:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "МесяцНачисления", Comment = "", Synonym = "Месяц начисления")]
        public DateTime МесяцНачисления {get; set;}
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "КраткийСоставДокумента", Comment = "", Synonym = "Краткий состав документа")]
        [StringLength(100)]
        public string КраткийСоставДокумента {get; set;}
        [Description1C8(Name = "ЭтоПересчетНДФЛ", Comment = "", Synonym = "Это пересчет НДФЛ")]
        public bool ЭтоПересчетНДФЛ {get; set;}
        [Description1C8(Name = "ПредварительныйРасчет", Comment = "", Synonym = "Предварительный расчет")]
        public bool ПредварительныйРасчет {get; set;}
        [Description1C8(Name = "КорректироватьНДФЛ", Comment = "", Synonym = "Корректировать НДФЛ")]
        public bool КорректироватьНДФЛ {get; set;}
        [Description1C8(Name = "КорректироватьВзносы", Comment = "", Synonym = "Корректировать взносы")]
        public bool КорректироватьВзносы {get; set;}
        [Description1C8(Name = "РучнаяКорректировка", Comment = "", Synonym = "Ручная корректировка")]
        public bool РучнаяКорректировка {get; set;}
        [Description1C8(Name = "УДАЛИТЬНормаЧасовЗаМесяц", Comment = "", Synonym = "(не используется) Норма часов за месяц")]
        // Format 7.2
        public decimal УДАЛИТЬНормаЧасовЗаМесяц {get; set;}
        [Description1C8(Name = "УДАЛИТЬНормаДнейЗаМесяц", Comment = "", Synonym = "(не используется) Норма дней за месяц")]
        // Format 7.2
        public decimal УДАЛИТЬНормаДнейЗаМесяц {get; set;}
        [Description1C8(Name = "УДАЛИТЬБазовыйПериодИндексацииСоцВыплат", Comment = "", Synonym = "(не используется) Базовый период индексации соц выплат")]
        public DateTime УДАЛИТЬБазовыйПериодИндексацииСоцВыплат {get; set;}
        [Description1C8(Name = "УДАЛИТЬПерерассчитываемыйДокумент", Comment = "", Synonym = "(не используется) Перерассчитываемый документ")]
        public Документ.УстарелоНачислениеЗарплаты УДАЛИТЬПерерассчитываемыйДокумент {get; set;}
        [Description1C8(Name = "УДАЛИТЬНормаДнейЗаПоловинуМесяца", Comment = "", Synonym = "(не используется) Норма дней за половину месяца")]
        // Format 7.2
        public decimal УДАЛИТЬНормаДнейЗаПоловинуМесяца {get; set;}
        [Description1C8(Name = "УДАЛИТЬНормаЧасовЗаПоловинуМесяца", Comment = "", Synonym = "(не используется) Норма часов за половину месяца")]
        // Format 7.2
        public decimal УДАЛИТЬНормаЧасовЗаПоловинуМесяца {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ФизическиеЛица", Comment = "", Synonym = "Физические лица")]
        public List<УстарелоНачислениеЗарплаты_ФизическиеЛица> УстарелоНачислениеЗарплатыФизическиеЛица {get;set;}
        [Description1C8(Name = "Начисления", Comment = "", Synonym = "Начисления")]
        public List<УстарелоНачислениеЗарплаты_Начисления> УстарелоНачислениеЗарплатыНачисления {get;set;}
        [Description1C8(Name = "Взносы", Comment = "", Synonym = "Взносы")]
        public List<УстарелоНачислениеЗарплаты_Взносы> УстарелоНачислениеЗарплатыВзносы {get;set;}
        [Description1C8(Name = "Удержания", Comment = "", Synonym = "Удержания")]
        public List<УстарелоНачислениеЗарплаты_Удержания> УстарелоНачислениеЗарплатыУдержания {get;set;}
        [Description1C8(Name = "ВзносыФОТ", Comment = "", Synonym = "Взносы ФОТ")]
        public List<УстарелоНачислениеЗарплаты_ВзносыФОТ> УстарелоНачислениеЗарплатыВзносыФОТ {get;set;}
        [Description1C8(Name = "НДФЛ", Comment = "", Synonym = "НДФЛ")]
        public List<УстарелоНачислениеЗарплаты_НДФЛ> УстарелоНачислениеЗарплатыНДФЛ {get;set;}
        [Description1C8(Name = "УДАЛИТЬОтражениеВУчете", Comment = "Отражение в регламентированном учете", Synonym = "(не используется) Отражение в учете")]
        public List<УстарелоНачислениеЗарплаты_УДАЛИТЬОтражениеВУчете> УстарелоНачислениеЗарплатыУДАЛИТЬОтражениеВУчете {get;set;}
        [Description1C8(Name = "УДАЛИТЬНачисленияПроводки", Comment = "", Synonym = "(не используется) Начисления проводки")]
        public List<УстарелоНачислениеЗарплаты_УДАЛИТЬНачисленияПроводки> УстарелоНачислениеЗарплатыУДАЛИТЬНачисленияПроводки {get;set;}
        [Description1C8(Name = "УДАЛИТЬУдержанияПроводки", Comment = "", Synonym = "(не используется) Удержания проводки")]
        public List<УстарелоНачислениеЗарплаты_УДАЛИТЬУдержанияПроводки> УстарелоНачислениеЗарплатыУДАЛИТЬУдержанияПроводки {get;set;}
        [Description1C8(Name = "УДАЛИТЬВзносыПроводки", Comment = "", Synonym = "(не используется) Взносы проводки")]
        public List<УстарелоНачислениеЗарплаты_УДАЛИТЬВзносыПроводки> УстарелоНачислениеЗарплатыУДАЛИТЬВзносыПроводки {get;set;}
        [Description1C8(Name = "УДАЛИТЬВзносыФОТПроводки", Comment = "", Synonym = "(не используется) Взносы ФОТПроводки")]
        public List<УстарелоНачислениеЗарплаты_УДАЛИТЬВзносыФОТПроводки> УстарелоНачислениеЗарплатыУДАЛИТЬВзносыФОТПроводки {get;set;}
        [Description1C8(Name = "УДАЛИТЬНДФЛПроводки", Comment = "", Synonym = "(не используется) НДФЛПроводки")]
        public List<УстарелоНачислениеЗарплаты_УДАЛИТЬНДФЛПроводки> УстарелоНачислениеЗарплатыУДАЛИТЬНДФЛПроводки {get;set;}
        [Description1C8(Name = "УпрощенныйУчет", Comment = "", Synonym = "Упрощенный учет")]
        public List<УстарелоНачислениеЗарплаты_УпрощенныйУчет> УстарелоНачислениеЗарплатыУпрощенныйУчет {get;set;}
        [Description1C8(Name = "СтруктураКолонокУпрощенногоУчета", Comment = "", Synonym = "Структура колонок упрощенного учета")]
        public List<УстарелоНачислениеЗарплаты_СтруктураКолонокУпрощенногоУчета> УстарелоНачислениеЗарплатыСтруктураКолонокУпрощенногоУчета {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ФизическиеЛица", Comment = "", Synonym = "Физические лица")]
    [Table("UstareloNachyslenyeZarplaty_FyzycheskyeLytsa")]
    public class УстарелоНачислениеЗарплаты_ФизическиеЛица
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "УДАЛИТЬСотрудник", Comment = "", Synonym = "(не используется) Сотрудник")]
        public Catalogs.Сотрудники УДАЛИТЬСотрудник {get; set;}
    }
    [Description1C8(Name = "Начисления", Comment = "", Synonym = "Начисления")]
    [Table("UstareloNachyslenyeZarplaty_Nachyslenyia")]
    public class УстарелоНачислениеЗарплаты_Начисления
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "Сотрудник", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "Начисление", Comment = "", Synonym = "Начисление")]
        public ПланВидовРасчета.УстарелоНачисления Начисление {get; set;}
        [Description1C8(Name = "ДатаНачала", Comment = "", Synonym = "Дата начала")]
        public DateTime ДатаНачала {get; set;}
        [Description1C8(Name = "ДатаОкончания", Comment = "", Synonym = "Дата окончания")]
        public DateTime ДатаОкончания {get; set;}
        [Description1C8(Name = "Размер", Comment = "", Synonym = "Размер")]
        // Format 15.3
        public decimal Размер {get; set;}
        [Description1C8(Name = "Результат", Comment = "", Synonym = "Результат")]
        // Format 16.2
        public decimal Результат {get; set;}
        [Description1C8(Name = "КалендарныеДни", Comment = "", Synonym = "Календарные дни")]
        // Format 10.0
        public long КалендарныеДни {get; set;}
        [Description1C8(Name = "ОтработаноДней", Comment = "", Synonym = "Отработано дней")]
        // Format 7.2
        public decimal ОтработаноДней {get; set;}
        [Description1C8(Name = "ОтработаноЧасов", Comment = "", Synonym = "Отработано часов")]
        // Format 7.2
        public decimal ОтработаноЧасов {get; set;}
        [Description1C8(Name = "НормаДней", Comment = "", Synonym = "Норма дней")]
        // Format 7.2
        public decimal НормаДней {get; set;}
        [Description1C8(Name = "НормаЧасов", Comment = "", Synonym = "Норма часов")]
        // Format 7.2
        public decimal НормаЧасов {get; set;}
        [Description1C8(Name = "НормаДнейЗаМесяц", Comment = "", Synonym = "Норма дней за месяц")]
        // Format 7.2
        public decimal НормаДнейЗаМесяц {get; set;}
        [Description1C8(Name = "НормаЧасовЗаМесяц", Comment = "", Synonym = "Норма часов за месяц")]
        // Format 7.2
        public decimal НормаЧасовЗаМесяц {get; set;}
        [Description1C8(Name = "Авторасчет", Comment = "", Synonym = "Авторасчет")]
        public bool Авторасчет {get; set;}
        [Description1C8(Name = "УДАЛИТЬФизлицо", Comment = "", Synonym = "(не используется) Физическое лицо")]
        public Catalogs.ФизическиеЛица УДАЛИТЬФизлицо {get; set;}
        [Description1C8(Name = "УДАЛИТЬСторно", Comment = "", Synonym = "(не используется) Сторно")]
        public bool УДАЛИТЬСторно {get; set;}
        [Description1C8(Name = "УДАЛИТЬСпособОтраженияВБухучете", Comment = "", Synonym = "(не используется) Способ отражения в бухучете")]
        public Catalogs.УстарелоСпособыОтраженияЗарплатыВРеглУчете УДАЛИТЬСпособОтраженияВБухучете {get; set;}
        [Description1C8(Name = "УДАЛИТЬБазовыйПериодНачало", Comment = "", Synonym = "(не используется) Базовый период начало")]
        public DateTime УДАЛИТЬБазовыйПериодНачало {get; set;}
        [Description1C8(Name = "УДАЛИТЬБазовыйПериодКонец", Comment = "", Synonym = "(не используется) Базовый период конец")]
        public DateTime УДАЛИТЬБазовыйПериодКонец {get; set;}
        [Description1C8(Name = "УДАЛИТЬОплаченоДнейЧасов", Comment = "", Synonym = "(не используется) Оплачено дней часов")]
        // Format 16.2
        public decimal УДАЛИТЬОплаченоДнейЧасов {get; set;}
        [Description1C8(Name = "УДАЛИТЬСотрудник", Comment = "", Synonym = "(не используется) Сотрудник")]
        public Catalogs.Сотрудники УДАЛИТЬСотрудник {get; set;}
        [Description1C8(Name = "Должность", Comment = "", Synonym = "Должность")]
        public Catalogs.УстарелоДолжности Должность {get; set;}
    }
    [Description1C8(Name = "Взносы", Comment = "", Synonym = "Взносы")]
    [Table("UstareloNachyslenyeZarplaty_Vznosy")]
    public class УстарелоНачислениеЗарплаты_Взносы
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Авторасчет", Comment = "", Synonym = "Авторасчет")]
        public bool Авторасчет {get; set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "Налог", Comment = "", Synonym = "Налог")]
        public Catalogs.Налоги Налог {get; set;}
        [Description1C8(Name = "СтатьяНалоговойДекларации", Comment = "", Synonym = "Статья налоговой декларации")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяНалоговойДекларации {get; set;}
        [Description1C8(Name = "Предел", Comment = "", Synonym = "Предел")]
        // Format 15.2
        public decimal Предел {get; set;}
        [Description1C8(Name = "ДатаНачала", Comment = "", Synonym = "Дата начала")]
        public DateTime ДатаНачала {get; set;}
        [Description1C8(Name = "ДатаОкончания", Comment = "", Synonym = "Дата окончания")]
        public DateTime ДатаОкончания {get; set;}
        [Description1C8(Name = "База", Comment = "", Synonym = "База")]
        // Format 16.2
        public decimal База {get; set;}
        [Description1C8(Name = "БазаВзноса", Comment = "База налога с учетом ограничений", Synonym = "База (с ограничением)")]
        // Format 16.2
        public decimal БазаВзноса {get; set;}
        [Description1C8(Name = "Результат", Comment = "", Synonym = "Результат")]
        // Format 16.2
        public decimal Результат {get; set;}
        [Description1C8(Name = "Ставка", Comment = "", Synonym = "Ставка")]
        // Format 10.4
        public decimal Ставка {get; set;}
        [Description1C8(Name = "ОтработаноДней", Comment = "", Synonym = "Отработано дней")]
        // Format 7.2
        public decimal ОтработаноДней {get; set;}
        [Description1C8(Name = "ОтработаноДнейВсего", Comment = "", Synonym = "Отработано дней всего")]
        // Format 7.2
        public decimal ОтработаноДнейВсего {get; set;}
        [Description1C8(Name = "БазаВычет", Comment = "База (вычет)", Synonym = "База (вычет)")]
        // Format 16.2
        public decimal БазаВычет {get; set;}
        [Description1C8(Name = "ТипНачисления", Comment = "", Synonym = "Тип начисления")]
        // Format 2.0
        public long ТипНачисления {get; set;}
        [Description1C8(Name = "БазаОтпускные", Comment = "", Synonym = "База (отпускные)")]
        // Format 16.2
        public decimal БазаОтпускные {get; set;}
        [Description1C8(Name = "КатегорияЕСВ", Comment = "", Synonym = "Категория ЕСВ")]
        public Catalogs.КатегорииЗастрахованныхЛицЕСВ КатегорияЕСВ {get; set;}
        [Description1C8(Name = "ВидЕСВ", Comment = "", Synonym = "Вид ЕСВ")]
        public Enums.ВидыЕСВ ВидЕСВ {get; set;}
        [Description1C8(Name = "КоэффициентСтавки", Comment = "", Synonym = "Коэффициент ставки")]
        // Format 10.4
        public decimal КоэффициентСтавки {get; set;}
        [Description1C8(Name = "МинимальнаяБаза", Comment = "", Synonym = "Минимальная база")]
        // Format 15.3
        public decimal МинимальнаяБаза {get; set;}
        [Description1C8(Name = "БазаДоначисление", Comment = "", Synonym = "База (доначисление)")]
        // Format 16.2
        public decimal БазаДоначисление {get; set;}
        [Description1C8(Name = "РезультатДоначисление", Comment = "", Synonym = "Результат (доначисление)")]
        // Format 16.2
        public decimal РезультатДоначисление {get; set;}
        [Description1C8(Name = "УДАЛИТЬСотрудник", Comment = "", Synonym = "(не используется) Сотрудник")]
        public Catalogs.Сотрудники УДАЛИТЬСотрудник {get; set;}
        [Description1C8(Name = "УДАЛИТЬКодКатегорииЗЛ", Comment = "", Synonym = "(не используется) Код категории застрахованного лица")]
        // Format 2.0
        public long УДАЛИТЬКодКатегорииЗЛ {get; set;}
        [Description1C8(Name = "УДАЛИТЬНомерПорога", Comment = "", Synonym = "(не используется) Номер порога")]
        public Enums.ПорогиШкалыСтавокНалогов УДАЛИТЬНомерПорога {get; set;}
        [Description1C8(Name = "УДАЛИТЬПодразделениеОрганизации", Comment = "", Synonym = "(не используется) Подразделение организации")]
        public Catalogs.ПодразделенияОрганизаций УДАЛИТЬПодразделениеОрганизации {get; set;}
        [Description1C8(Name = "УДАЛИТЬВидРасчета", Comment = "", Synonym = "(не используется) Вид расчета")]
        public ПланВидовРасчета.УДАЛИТЬВзносы УДАЛИТЬВидРасчета {get; set;}
        [Description1C8(Name = "УДАЛИТЬБазовыйПериодНачало", Comment = "", Synonym = "(не используется) Базовый период начало")]
        public DateTime УДАЛИТЬБазовыйПериодНачало {get; set;}
        [Description1C8(Name = "УДАЛИТЬБазовыйПериодКонец", Comment = "Налоговый период", Synonym = "(не используется) Базовый период конец")]
        public DateTime УДАЛИТЬБазовыйПериодКонец {get; set;}
        [Description1C8(Name = "УДАЛИТЬСторно", Comment = "", Synonym = "(не используется) Сторно")]
        public bool УДАЛИТЬСторно {get; set;}
        [Description1C8(Name = "СтавкаПолная", Comment = "", Synonym = "Ставка полная")]
        // Format 10.4
        public decimal СтавкаПолная {get; set;}
        [Description1C8(Name = "РезультатПолная", Comment = "", Synonym = "Результат по полной ставке")]
        // Format 16.6
        public decimal РезультатПолная {get; set;}
    }
    [Description1C8(Name = "Удержания", Comment = "", Synonym = "Удержания")]
    [Table("UstareloNachyslenyeZarplaty_Uderzhanyia")]
    public class УстарелоНачислениеЗарплаты_Удержания
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "Удержание", Comment = "", Synonym = "Удержание")]
        public ПланВидовРасчета.УстарелоУдержания Удержание {get; set;}
        [Description1C8(Name = "ДатаНачала", Comment = "", Synonym = "Дата начала")]
        public DateTime ДатаНачала {get; set;}
        [Description1C8(Name = "ДатаОкончания", Comment = "", Synonym = "Дата окончания")]
        public DateTime ДатаОкончания {get; set;}
        [Description1C8(Name = "Размер", Comment = "", Synonym = "Размер")]
        // Format 15.3
        public decimal Размер {get; set;}
        [Description1C8(Name = "Результат", Comment = "", Synonym = "Результат")]
        // Format 16.2
        public decimal Результат {get; set;}
        [Description1C8(Name = "Авторасчет", Comment = "", Synonym = "Авторасчет")]
        public bool Авторасчет {get; set;}
        [Description1C8(Name = "Контрагент", Comment = "", Synonym = "Контрагент")]
        public Catalogs.Контрагенты Контрагент {get; set;}
        [Description1C8(Name = "УДАЛИТЬСторно", Comment = "", Synonym = "(не используется) Сторно")]
        public bool УДАЛИТЬСторно {get; set;}
        [Description1C8(Name = "УДАЛИТЬФизЛицо", Comment = "", Synonym = "(не используется) Физическое лицо")]
        public Catalogs.ФизическиеЛица УДАЛИТЬФизЛицо {get; set;}
    }
    [Description1C8(Name = "ВзносыФОТ", Comment = "", Synonym = "Взносы ФОТ")]
    [Table("UstareloNachyslenyeZarplaty_VznosyFOT")]
    public class УстарелоНачислениеЗарплаты_ВзносыФОТ
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "Налог", Comment = "", Synonym = "Налог")]
        public Catalogs.Налоги Налог {get; set;}
        [Description1C8(Name = "СтатьяНалоговойДекларации", Comment = "", Synonym = "Статья налоговой декларации")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяНалоговойДекларации {get; set;}
        [Description1C8(Name = "ВидРасчета", Comment = "", Synonym = "Вид расчета")]
        public ПланВидовРасчета.УДАЛИТЬВзносы ВидРасчета {get; set;}
        [Description1C8(Name = "Предел", Comment = "", Synonym = "Предел")]
        // Format 15.3
        public decimal Предел {get; set;}
        [Description1C8(Name = "База", Comment = "", Synonym = "База")]
        // Format 16.2
        public decimal База {get; set;}
        [Description1C8(Name = "БазаВзноса", Comment = "База налога с учетом ограничений", Synonym = "База взноса")]
        // Format 16.2
        public decimal БазаВзноса {get; set;}
        [Description1C8(Name = "Результат", Comment = "", Synonym = "Результат")]
        // Format 16.6
        public decimal Результат {get; set;}
        [Description1C8(Name = "Ставка", Comment = "", Synonym = "Ставка")]
        // Format 10.4
        public decimal Ставка {get; set;}
        [Description1C8(Name = "Авторасчет", Comment = "", Synonym = "Авторасчет")]
        public bool Авторасчет {get; set;}
        [Description1C8(Name = "ДатаНачала", Comment = "Период параметров налога начало", Synonym = "Дата начала")]
        public DateTime ДатаНачала {get; set;}
        [Description1C8(Name = "ДатаОкончания", Comment = "Период параметров налога окончания", Synonym = "Дата окончания")]
        public DateTime ДатаОкончания {get; set;}
        [Description1C8(Name = "ОтработаноДней", Comment = "", Synonym = "Отработано дней")]
        // Format 7.2
        public decimal ОтработаноДней {get; set;}
        [Description1C8(Name = "ОтработаноДнейВсего", Comment = "", Synonym = "Отработано дней всего")]
        // Format 7.2
        public decimal ОтработаноДнейВсего {get; set;}
        [Description1C8(Name = "БазаВычет", Comment = "База (вычет)", Synonym = "База (вычет)")]
        // Format 16.2
        public decimal БазаВычет {get; set;}
        [Description1C8(Name = "ТипНачисления", Comment = "", Synonym = "Тип начисления")]
        // Format 2.0
        public long ТипНачисления {get; set;}
        [Description1C8(Name = "БазаОтпускные", Comment = "", Synonym = "База (отпускные)")]
        // Format 16.2
        public decimal БазаОтпускные {get; set;}
        [Description1C8(Name = "КатегорияЕСВ", Comment = "", Synonym = "Категория ЕСВ")]
        public Catalogs.КатегорииЗастрахованныхЛицЕСВ КатегорияЕСВ {get; set;}
        [Description1C8(Name = "ВидЕСВ", Comment = "", Synonym = "Вид ЕСВ")]
        public Enums.ВидыЕСВ ВидЕСВ {get; set;}
        [Description1C8(Name = "КоэффициентСтавки", Comment = "", Synonym = "Коэффициент ставки")]
        // Format 10.4
        public decimal КоэффициентСтавки {get; set;}
        [Description1C8(Name = "МинимальнаяБаза", Comment = "", Synonym = "Минимальная база")]
        // Format 15.3
        public decimal МинимальнаяБаза {get; set;}
        [Description1C8(Name = "БазаДоначисление", Comment = "", Synonym = "База (доначисление)")]
        // Format 16.2
        public decimal БазаДоначисление {get; set;}
        [Description1C8(Name = "РезультатДоначисление", Comment = "", Synonym = "Результат (доначисление)")]
        // Format 16.2
        public decimal РезультатДоначисление {get; set;}
        [Description1C8(Name = "УДАЛИТЬСотрудник", Comment = "", Synonym = "(не используется) Сотрудник")]
        public Catalogs.Сотрудники УДАЛИТЬСотрудник {get; set;}
        [Description1C8(Name = "УдалитьПериодПараметровНалогаНачало", Comment = "", Synonym = "(не используется)  Период параметров налога начало")]
        public DateTime УдалитьПериодПараметровНалогаНачало {get; set;}
        [Description1C8(Name = "УдалитьПериодПараметровНалогаКонец", Comment = "", Synonym = "(не используется) период параметров налога конец")]
        public DateTime УдалитьПериодПараметровНалогаКонец {get; set;}
        [Description1C8(Name = "УДАЛИТЬБазаВзносаЗаМесяц", Comment = "", Synonym = "(не используется) База взноса за месяц")]
        // Format 15.2
        public decimal УДАЛИТЬБазаВзносаЗаМесяц {get; set;}
        [Description1C8(Name = "УДАЛИТЬНомерПорога", Comment = "", Synonym = "(не используется) Номер порога")]
        public Enums.ПорогиШкалыСтавокНалогов УДАЛИТЬНомерПорога {get; set;}
        [Description1C8(Name = "УДАЛИТЬПодразделениеОрганизации", Comment = "", Synonym = "(не используется) Подразделение организации")]
        public Catalogs.ПодразделенияОрганизаций УДАЛИТЬПодразделениеОрганизации {get; set;}
        [Description1C8(Name = "УДАЛИТЬБазаЗаМесяц", Comment = "", Synonym = "(не используется) База за месяц")]
        // Format 15.2
        public decimal УДАЛИТЬБазаЗаМесяц {get; set;}
        [Description1C8(Name = "УДАЛИТЬСторно", Comment = "", Synonym = "(не используется) Сторно")]
        public bool УДАЛИТЬСторно {get; set;}
        [Description1C8(Name = "УДАЛИТЬБазовыйПериодКонец", Comment = "", Synonym = "(не используется) Базовый период конец")]
        public DateTime УДАЛИТЬБазовыйПериодКонец {get; set;}
        [Description1C8(Name = "УДАЛИТЬБазовыйПериодНачало", Comment = "", Synonym = "(не используется) Базовый период начало")]
        public DateTime УДАЛИТЬБазовыйПериодНачало {get; set;}
        [Description1C8(Name = "УДАЛИТЬКодКатегорииЗЛ", Comment = "", Synonym = "(не используется) Код категории застрахованного лица")]
        // Format 2.0
        public long УДАЛИТЬКодКатегорииЗЛ {get; set;}
        [Description1C8(Name = "СтавкаПолная", Comment = "", Synonym = "Ставка полная")]
        // Format 10.4
        public decimal СтавкаПолная {get; set;}
        [Description1C8(Name = "РезультатПолная", Comment = "", Synonym = "Результат по полной ставке")]
        // Format 16.2
        public decimal РезультатПолная {get; set;}
    }
    [Description1C8(Name = "НДФЛ", Comment = "", Synonym = "НДФЛ")]
    [Table("UstareloNachyslenyeZarplaty_NDFL")]
    public class УстарелоНачислениеЗарплаты_НДФЛ
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "ДоходНДФЛ", Comment = "", Synonym = "Доход НДФЛ")]
        public Catalogs.УстарелоВидыДоходовНДФЛ ДоходНДФЛ {get; set;}
        [Description1C8(Name = "НалоговыйПериод", Comment = "", Synonym = "Налоговый период")]
        public DateTime НалоговыйПериод {get; set;}
        [Description1C8(Name = "ВидСтавки", Comment = "", Synonym = "Вид ставки")]
        public Enums.ВидыСтавокНДФЛ ВидСтавки {get; set;}
        [Description1C8(Name = "УвеличеннаяСтавка", Comment = "", Synonym = "Увеличенная ставка")]
        public Enums.ВидыСтавокНДФЛ УвеличеннаяСтавка {get; set;}
        [Description1C8(Name = "Налог", Comment = "", Synonym = "Налог")]
        // Format 15.2
        public decimal Налог {get; set;}
        [Description1C8(Name = "Доход", Comment = "", Synonym = "Доход")]
        // Format 15.2
        public decimal Доход {get; set;}
        [Description1C8(Name = "Льгота", Comment = "", Synonym = "Льгота")]
        public Catalogs.УстарелоВидыЛьготПоНДФЛ Льгота {get; set;}
        [Description1C8(Name = "КоличествоЛьгот", Comment = "", Synonym = "Количество льгот")]
        // Format 5.2
        public decimal КоличествоЛьгот {get; set;}
        [Description1C8(Name = "Авторасчет", Comment = "", Synonym = "Авторасчет")]
        public bool Авторасчет {get; set;}
        [Description1C8(Name = "ДоходПолный", Comment = "", Synonym = "Доход полный")]
        // Format 15.2
        public decimal ДоходПолный {get; set;}
        [Description1C8(Name = "СуммаЛьготы", Comment = "", Synonym = "Сумма льготы")]
        // Format 15.2
        public decimal СуммаЛьготы {get; set;}
        [Description1C8(Name = "УДАЛИТЬСотрудник", Comment = "", Synonym = "(не используется) Сотрудник")]
        public Catalogs.Сотрудники УДАЛИТЬСотрудник {get; set;}
        [Description1C8(Name = "УДАЛИТЬСторно", Comment = "", Synonym = "(не используется) Сторно")]
        public bool УДАЛИТЬСторно {get; set;}
    }
    [Description1C8(Name = "УДАЛИТЬОтражениеВУчете", Comment = "Отражение в регламентированном учете", Synonym = "(не используется) Отражение в учете")]
    [Table("UstareloNachyslenyeZarplaty_UDALYTOtrazhenyeVUchete")]
    public class УстарелоНачислениеЗарплаты_УДАЛИТЬОтражениеВУчете
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "СчетДт", Comment = "", Synonym = "Счет дт")]
        public ПланСчетов.Хозрасчетный СчетДт {get; set;}
        [Description1C8(Name = "СубконтоДт1", Comment = "", Synonym = "Субконто дт номер 1")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоДт1 {get; set;}
        [Description1C8(Name = "СубконтоДт2", Comment = "", Synonym = "Субконто дт номер 2")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоДт2 {get; set;}
        [Description1C8(Name = "СубконтоДт3", Comment = "", Synonym = "Субконто дт номер 3")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоДт3 {get; set;}
        [Description1C8(Name = "СчетКт", Comment = "", Synonym = "Счет кт")]
        public ПланСчетов.Хозрасчетный СчетКт {get; set;}
        [Description1C8(Name = "СубконтоКт1", Comment = "", Synonym = "Субконто кт номер 1")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоКт1 {get; set;}
        [Description1C8(Name = "СубконтоКт2", Comment = "", Synonym = "Субконто кт номер 2")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоКт2 {get; set;}
        [Description1C8(Name = "СубконтоКт3", Comment = "", Synonym = "Субконто кт номер 3")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоКт3 {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "УДАЛИТЬСтатьяВаловыхРасходов", Comment = "", Synonym = "Статья в/р")]
        public Catalogs.СтатьиНалоговыхДеклараций УДАЛИТЬСтатьяВаловыхРасходов {get; set;}
        [Description1C8(Name = "НалоговоеНазначениеДоходовИЗатрат", Comment = "", Synonym = "Налоговое назначение доходов и затрат")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначениеДоходовИЗатрат {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение (НДС)")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        [Description1C8(Name = "НеОтражатьВБУ", Comment = "", Synonym = "Не отражать в бухгалтерском учете")]
        public bool НеОтражатьВБУ {get; set;}
    }
    [Description1C8(Name = "УДАЛИТЬНачисленияПроводки", Comment = "", Synonym = "(не используется) Начисления проводки")]
    [Table("UstareloNachyslenyeZarplaty_UDALYTNachyslenyiaProvodky")]
    public class УстарелоНачислениеЗарплаты_УДАЛИТЬНачисленияПроводки
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ВидРасчета", Comment = "", Synonym = "Вид расчета")]
        public ПланВидовРасчета.УстарелоНачисления ВидРасчета {get; set;}
        [Description1C8(Name = "ДоходНДФЛ", Comment = "'Код дохода НДФЛ' или 'Вид расчета взносов наФОТ'", Synonym = "Доход НДФЛ")]
        public Catalogs.УстарелоВидыДоходовНДФЛ ДоходНДФЛ {get; set;}
        [Description1C8(Name = "Результат", Comment = "", Synonym = "Результат")]
        // Format 16.2
        public decimal Результат {get; set;}
        [Description1C8(Name = "СчетДт", Comment = "", Synonym = "Счет Дт")]
        public ПланСчетов.Хозрасчетный СчетДт {get; set;}
        [Description1C8(Name = "СубконтоДт1", Comment = "", Synonym = "Субконто Дт номер 1")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоДт1 {get; set;}
        [Description1C8(Name = "СубконтоДт2", Comment = "", Synonym = "Субконто Дт номер 2")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоДт2 {get; set;}
        [Description1C8(Name = "СубконтоДт3", Comment = "", Synonym = "Субконто Дт номер 3")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоДт3 {get; set;}
        [Description1C8(Name = "СчетКт", Comment = "", Synonym = "Счет Кт")]
        public ПланСчетов.Хозрасчетный СчетКт {get; set;}
        [Description1C8(Name = "СубконтоКт1", Comment = "", Synonym = "Субконто Кт номер 1")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоКт1 {get; set;}
        [Description1C8(Name = "СубконтоКт2", Comment = "", Synonym = "Субконто Кт номер 2")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоКт2 {get; set;}
        [Description1C8(Name = "СубконтоКт3", Comment = "", Synonym = "Субконто Кт номер 3")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоКт3 {get; set;}
        [Description1C8(Name = "УДАЛИТЬСтатьяВаловыхРасходов", Comment = "", Synonym = "Статья в/р")]
        public Catalogs.СтатьиНалоговыхДеклараций УДАЛИТЬСтатьяВаловыхРасходов {get; set;}
        [Description1C8(Name = "НалоговоеНазначениеДоходовИЗатрат", Comment = "", Synonym = "Налоговое назначение доходов и затрат")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначениеДоходовИЗатрат {get; set;}
        [Description1C8(Name = "ВзносыОсновногоНачисления", Comment = "Взносы получать от основного начисления (больничный соцстрах)", Synonym = "Особый способ отражения для ЕСВ ФОТ")]
        public bool ВзносыОсновногоНачисления {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "Назначение", Comment = "", Synonym = "Назначение")]
        public Catalogs.Сотрудники Назначение {get; set;}
        [Description1C8(Name = "ДатаНачала", Comment = "", Synonym = "Дата начала")]
        public DateTime ДатаНачала {get; set;}
        [Description1C8(Name = "ДатаОкончания", Comment = "", Synonym = "Дата окончания")]
        public DateTime ДатаОкончания {get; set;}
        [Description1C8(Name = "ПодразделениеОрганизации", Comment = "", Synonym = "Подразделение организации")]
        public Catalogs.ПодразделенияОрганизаций ПодразделениеОрганизации {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение (НДС)")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        [Description1C8(Name = "СпособОтраженияЕСВФОТ", Comment = "", Synonym = "Способ отражения ЕСВ ФОТ")]
        public Catalogs.УстарелоСпособыОтраженияЗарплатыВРеглУчете СпособОтраженияЕСВФОТ {get; set;}
    }
    [Description1C8(Name = "УДАЛИТЬУдержанияПроводки", Comment = "", Synonym = "(не используется) Удержания проводки")]
    [Table("UstareloNachyslenyeZarplaty_UDALYTUderzhanyiaProvodky")]
    public class УстарелоНачислениеЗарплаты_УДАЛИТЬУдержанияПроводки
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "ВидРасчета", Comment = "", Synonym = "Вид расчета")]
        public ПланВидовРасчета.УстарелоУдержания ВидРасчета {get; set;}
        [Description1C8(Name = "НалоговыйПериод", Comment = "", Synonym = "Налоговый период")]
        public DateTime НалоговыйПериод {get; set;}
        [Description1C8(Name = "Результат", Comment = "", Synonym = "Результат")]
        // Format 16.2
        public decimal Результат {get; set;}
        [Description1C8(Name = "СчетДт", Comment = "", Synonym = "Счет Дт")]
        public ПланСчетов.Хозрасчетный СчетДт {get; set;}
        [Description1C8(Name = "СубконтоДт1", Comment = "", Synonym = "Субконто Дт номер 1")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоДт1 {get; set;}
        [Description1C8(Name = "СубконтоДт2", Comment = "", Synonym = "Субконто Дт номер 2")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоДт2 {get; set;}
        [Description1C8(Name = "СубконтоДт3", Comment = "", Synonym = "Субконто Дт номер 3")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоДт3 {get; set;}
        [Description1C8(Name = "СчетКт", Comment = "", Synonym = "Счет Кт")]
        public ПланСчетов.Хозрасчетный СчетКт {get; set;}
        [Description1C8(Name = "СубконтоКт1", Comment = "", Synonym = "Субконто Кт номер 1")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоКт1 {get; set;}
        [Description1C8(Name = "СубконтоКт2", Comment = "", Synonym = "Субконто Кт номер 2")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоКт2 {get; set;}
        [Description1C8(Name = "СубконтоКт3", Comment = "", Synonym = "Субконто Кт номер 3")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоКт3 {get; set;}
    }
    [Description1C8(Name = "УДАЛИТЬВзносыПроводки", Comment = "", Synonym = "(не используется) Взносы проводки")]
    [Table("UstareloNachyslenyeZarplaty_UDALYTVznosyProvodky")]
    public class УстарелоНачислениеЗарплаты_УДАЛИТЬВзносыПроводки
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ВидРасчета", Comment = "", Synonym = "Вид расчета")]
        public ПланВидовРасчета.УДАЛИТЬВзносы ВидРасчета {get; set;}
        [Description1C8(Name = "СтатьяНалоговойДекларации", Comment = "", Synonym = "Статья налоговой декларации")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяНалоговойДекларации {get; set;}
        [Description1C8(Name = "БазовыйПериодНачало", Comment = "", Synonym = "Базовый период начало")]
        public DateTime БазовыйПериодНачало {get; set;}
        [Description1C8(Name = "Результат", Comment = "", Synonym = "Результат")]
        // Format 16.2
        public decimal Результат {get; set;}
        [Description1C8(Name = "РезультатТочный", Comment = "", Synonym = "Результат (точный)")]
        // Format 20.8
        public decimal РезультатТочный {get; set;}
        [Description1C8(Name = "СчетДт", Comment = "", Synonym = "Счет Дт")]
        public ПланСчетов.Хозрасчетный СчетДт {get; set;}
        [Description1C8(Name = "СубконтоДт1", Comment = "", Synonym = "Субконто Дт номер 1")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоДт1 {get; set;}
        [Description1C8(Name = "СубконтоДт2", Comment = "", Synonym = "Субконто Дт номер 2")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоДт2 {get; set;}
        [Description1C8(Name = "СубконтоДт3", Comment = "", Synonym = "Субконто Дт номер 3")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоДт3 {get; set;}
        [Description1C8(Name = "СчетКт", Comment = "", Synonym = "Счет Кт")]
        public ПланСчетов.Хозрасчетный СчетКт {get; set;}
        [Description1C8(Name = "СубконтоКт1", Comment = "", Synonym = "Субконто Кт номер 1")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоКт1 {get; set;}
        [Description1C8(Name = "СубконтоКт2", Comment = "", Synonym = "Субконто Кт номер 2")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоКт2 {get; set;}
        [Description1C8(Name = "СубконтоКт3", Comment = "", Synonym = "Субконто Кт номер 3")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоКт3 {get; set;}
        [Description1C8(Name = "УДАЛИТЬСтатьяВаловыхРасходов", Comment = "", Synonym = "Статья в/р")]
        public Catalogs.СтатьиНалоговыхДеклараций УДАЛИТЬСтатьяВаловыхРасходов {get; set;}
        [Description1C8(Name = "ДоходНДФЛ", Comment = "'Код дохода НДФЛ' или 'Вид расчета взносов наФОТ'", Synonym = "Доход НДФЛ")]
        public Catalogs.УстарелоВидыДоходовНДФЛ ДоходНДФЛ {get; set;}
        [Description1C8(Name = "Налог", Comment = "", Synonym = "Налог")]
        public Catalogs.Налоги Налог {get; set;}
        [Description1C8(Name = "БазаВзноса", Comment = "", Synonym = "Результат")]
        // Format 14.2
        public decimal БазаВзноса {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
    }
    [Description1C8(Name = "УДАЛИТЬВзносыФОТПроводки", Comment = "", Synonym = "(не используется) Взносы ФОТПроводки")]
    [Table("UstareloNachyslenyeZarplaty_UDALYTVznosyFOTProvodky")]
    public class УстарелоНачислениеЗарплаты_УДАЛИТЬВзносыФОТПроводки
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ВидРасчета", Comment = "", Synonym = "Вид расчета")]
        public ПланВидовРасчета.УДАЛИТЬВзносы ВидРасчета {get; set;}
        [Description1C8(Name = "ВидРасчетаБазы", Comment = "", Synonym = "Вид расчета (базы)")]
        public ПланВидовРасчета.УстарелоНачисления ВидРасчетаБазы {get; set;}
        [Description1C8(Name = "СтатьяНалоговойДекларации", Comment = "", Synonym = "Статья налоговой декларации")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяНалоговойДекларации {get; set;}
        [Description1C8(Name = "БазовыйПериодНачало", Comment = "", Synonym = "Базовый период начало")]
        public DateTime БазовыйПериодНачало {get; set;}
        [Description1C8(Name = "ПериодСтавки", Comment = "Если ставка менялась в середине месяца не равно  первому числу месяца", Synonym = "Период ставки")]
        public DateTime ПериодСтавки {get; set;}
        [Description1C8(Name = "Результат", Comment = "", Synonym = "Результат")]
        // Format 18.6
        public decimal Результат {get; set;}
        [Description1C8(Name = "РезультатТочный", Comment = "", Synonym = "Результат (точный)")]
        // Format 20.8
        public decimal РезультатТочный {get; set;}
        [Description1C8(Name = "СчетДт", Comment = "", Synonym = "Счет Дт")]
        public ПланСчетов.Хозрасчетный СчетДт {get; set;}
        [Description1C8(Name = "СубконтоДт1", Comment = "", Synonym = "Субконто Дт номер 1")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоДт1 {get; set;}
        [Description1C8(Name = "СубконтоДт2", Comment = "", Synonym = "Субконто Дт номер 2")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоДт2 {get; set;}
        [Description1C8(Name = "СубконтоДт3", Comment = "", Synonym = "Субконто Дт номер 3")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоДт3 {get; set;}
        [Description1C8(Name = "СчетКт", Comment = "", Synonym = "Счет Кт")]
        public ПланСчетов.Хозрасчетный СчетКт {get; set;}
        [Description1C8(Name = "СубконтоКт1", Comment = "", Synonym = "Субконто Кт номер 1")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоКт1 {get; set;}
        [Description1C8(Name = "СубконтоКт2", Comment = "", Synonym = "Субконто Кт номер 2")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоКт2 {get; set;}
        [Description1C8(Name = "СубконтоКт3", Comment = "", Synonym = "Субконто Кт номер 3")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоКт3 {get; set;}
        [Description1C8(Name = "УДАЛИТЬСтатьяВаловыхРасходов", Comment = "", Synonym = "Статья в/р")]
        public Catalogs.СтатьиНалоговыхДеклараций УДАЛИТЬСтатьяВаловыхРасходов {get; set;}
        [Description1C8(Name = "ДоходНДФЛ", Comment = "'Код дохода НДФЛ' или 'Вид расчета взносов наФОТ'", Synonym = "Доход НДФЛ")]
        public Catalogs.УстарелоВидыДоходовНДФЛ ДоходНДФЛ {get; set;}
        [Description1C8(Name = "Налог", Comment = "", Synonym = "Налог")]
        public Catalogs.Налоги Налог {get; set;}
        [Description1C8(Name = "БазаВзноса", Comment = "", Synonym = "Результат")]
        // Format 14.2
        public decimal БазаВзноса {get; set;}
        [Description1C8(Name = "НалоговоеНазначениеДоходовИЗатрат", Comment = "", Synonym = "Налоговое назначение доходов и затрат")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначениеДоходовИЗатрат {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение (НДС)")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
    }
    [Description1C8(Name = "УДАЛИТЬНДФЛПроводки", Comment = "", Synonym = "(не используется) НДФЛПроводки")]
    [Table("UstareloNachyslenyeZarplaty_UDALYTNDFLProvodky")]
    public class УстарелоНачислениеЗарплаты_УДАЛИТЬНДФЛПроводки
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ДоходНДФЛ", Comment = "'Код дохода НДФЛ' или 'Вид расчета взносов наФОТ'", Synonym = "Доход НДФЛ")]
        public Catalogs.УстарелоВидыДоходовНДФЛ ДоходНДФЛ {get; set;}
        [Description1C8(Name = "Результат", Comment = "", Synonym = "Результат")]
        // Format 16.2
        public decimal Результат {get; set;}
        [Description1C8(Name = "БазовыйПериодНачало", Comment = "", Synonym = "Базовый период начало")]
        public DateTime БазовыйПериодНачало {get; set;}
        [Description1C8(Name = "СчетДт", Comment = "", Synonym = "Счет Дт")]
        public ПланСчетов.Хозрасчетный СчетДт {get; set;}
        [Description1C8(Name = "СубконтоДт1", Comment = "", Synonym = "Субконто Дт номер 1")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоДт1 {get; set;}
        [Description1C8(Name = "СубконтоДт2", Comment = "", Synonym = "Субконто Дт номер 2")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоДт2 {get; set;}
        [Description1C8(Name = "СубконтоДт3", Comment = "", Synonym = "Субконто Дт номер 3")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоДт3 {get; set;}
        [Description1C8(Name = "СчетКт", Comment = "", Synonym = "Счет Кт")]
        public ПланСчетов.Хозрасчетный СчетКт {get; set;}
        [Description1C8(Name = "СубконтоКт1", Comment = "", Synonym = "Субконто Кт номер 1")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоКт1 {get; set;}
        [Description1C8(Name = "СубконтоКт2", Comment = "", Synonym = "Субконто Кт номер 2")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоКт2 {get; set;}
        [Description1C8(Name = "СубконтоКт3", Comment = "", Synonym = "Субконто Кт номер 3")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоКт3 {get; set;}
        [Description1C8(Name = "УДАЛИТЬСтатьяВаловыхРасходов", Comment = "", Synonym = "Статья в/р")]
        public Catalogs.СтатьиНалоговыхДеклараций УДАЛИТЬСтатьяВаловыхРасходов {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
    }
    [Description1C8(Name = "УпрощенныйУчет", Comment = "", Synonym = "Упрощенный учет")]
    [Table("UstareloNachyslenyeZarplaty_UproshchennyiUchet")]
    public class УстарелоНачислениеЗарплаты_УпрощенныйУчет
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "Сотрудник", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "ПлановыйОклад", Comment = "", Synonym = "Плановый оклад")]
        // Format 16.2
        public decimal ПлановыйОклад {get; set;}
        [Description1C8(Name = "НормаДнейЗаМесяц", Comment = "", Synonym = "Норма дней")]
        // Format 7.2
        public decimal НормаДнейЗаМесяц {get; set;}
        [Description1C8(Name = "Оклад", Comment = "", Synonym = "Оклад")]
        // Format 16.2
        public decimal Оклад {get; set;}
        [Description1C8(Name = "Отпускные", Comment = "", Synonym = "Отпускные")]
        // Format 16.2
        public decimal Отпускные {get; set;}
        [Description1C8(Name = "БольничныеПредприятие", Comment = "", Synonym = "Больничные")]
        // Format 16.2
        public decimal БольничныеПредприятие {get; set;}
        [Description1C8(Name = "БольничныеФСС", Comment = "", Synonym = "Больничные (за счет ФСС)")]
        // Format 16.2
        public decimal БольничныеФСС {get; set;}
        [Description1C8(Name = "Индексация", Comment = "", Synonym = "Индексация")]
        // Format 16.2
        public decimal Индексация {get; set;}
        [Description1C8(Name = "ОтработаноДней", Comment = "", Synonym = "Отработано дней")]
        // Format 7.2
        public decimal ОтработаноДней {get; set;}
        [Description1C8(Name = "ОтпускныеКалендарныхДней", Comment = "", Synonym = "Отпускные календарных дней")]
        // Format 7.2
        public decimal ОтпускныеКалендарныхДней {get; set;}
        [Description1C8(Name = "БольничныеПредприятиеКалендарныхДней", Comment = "", Synonym = "Больничные предприятие календарных дней")]
        // Format 7.2
        public decimal БольничныеПредприятиеКалендарныхДней {get; set;}
        [Description1C8(Name = "БольничныеФССКалендарныхДней", Comment = "", Synonym = "Больничные ФСС календарных дней")]
        // Format 7.2
        public decimal БольничныеФССКалендарныхДней {get; set;}
        [Description1C8(Name = "ВсегоНачислено", Comment = "", Synonym = "Всего начислено")]
        // Format 16.2
        public decimal ВсегоНачислено {get; set;}
        [Description1C8(Name = "Доплата1", Comment = "", Synonym = "Доплата1")]
        // Format 16.2
        public decimal Доплата1 {get; set;}
        [Description1C8(Name = "Доплата2", Comment = "", Synonym = "Доплата2")]
        // Format 16.2
        public decimal Доплата2 {get; set;}
        [Description1C8(Name = "Доплата3", Comment = "", Synonym = "Доплата3")]
        // Format 16.2
        public decimal Доплата3 {get; set;}
        [Description1C8(Name = "Доплата4", Comment = "", Synonym = "Доплата4")]
        // Format 16.2
        public decimal Доплата4 {get; set;}
        [Description1C8(Name = "Доплата5", Comment = "", Synonym = "Доплата5")]
        // Format 16.2
        public decimal Доплата5 {get; set;}
        [Description1C8(Name = "Доплата6", Comment = "", Synonym = "Доплата6")]
        // Format 16.2
        public decimal Доплата6 {get; set;}
        [Description1C8(Name = "Должность", Comment = "", Synonym = "Должность")]
        public Catalogs.УстарелоДолжности Должность {get; set;}
    }
    [Description1C8(Name = "СтруктураКолонокУпрощенногоУчета", Comment = "", Synonym = "Структура колонок упрощенного учета")]
    [Table("UstareloNachyslenyeZarplaty_StrukturaKolonokUproshchennohoUcheta")]
    public class УстарелоНачислениеЗарплаты_СтруктураКолонокУпрощенногоУчета
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Колонка", Comment = "", Synonym = "Колонка")]
        public Enums.УстарелоКолонкиУпрощенногоРасчета Колонка {get; set;}
        [Description1C8(Name = "Начисление", Comment = "", Synonym = "Начисление")]
        public ПланВидовРасчета.УстарелоНачисления Начисление {get; set;}
        [Description1C8(Name = "Наименование", Comment = "", Synonym = "Наименование")]
        [StringLength(30)]
        public string Наименование {get; set;}
    }
}
