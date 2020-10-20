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
    [Table("UstareloVedomostNaVyplatuZarplaty")]
    [Description1C8(Name = "УстарелоВедомостьНаВыплатуЗарплаты", Comment = "", Synonym = "ѳ(устарело) Ведомость на выплату зарплаты")]
    public class УстарелоВедомостьНаВыплатуЗарплаты:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "ПодразделениеОрганизации", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций ПодразделениеОрганизации {get; set;}
        [Description1C8(Name = "ПериодРегистрации", Comment = "", Synonym = "Месяц")]
        public DateTime ПериодРегистрации {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "ВидВыплаты", Comment = "", Synonym = "Вид выплаты")]
        public Catalogs.УстарелоВидыВыплат ВидВыплаты {get; set;}
        [Description1C8(Name = "УдалитьВидРасчета", Comment = "", Synonym = "(не используется) Вид расчета")]
        public ПланВидовРасчета.УстарелоНачисления УдалитьВидРасчета {get; set;}
        [Description1C8(Name = "УдалитьСпособВыплаты", Comment = "", Synonym = "(не используется) Способ выплаты")]
        public Enums.УстарелоСпособыВыплатыЗарплаты УдалитьСпособВыплаты {get; set;}
        [Description1C8(Name = "УдалитьКодОперации", Comment = "", Synonym = "(не используется) Код операции")]
        public Enums.КодыОперацийВзаиморасчетыСРаботникамиОрганизаций УдалитьКодОперации {get; set;}
        [Description1C8(Name = "УдалитьДнейНеВыплаты", Comment = "Количество дней, на которые задержана выплата зарплаты", Synonym = "(не используется) Дней не выплаты")]
        // Format 5.0
        public long УдалитьДнейНеВыплаты {get; set;}
        [Description1C8(Name = "КраткийСоставДокумента", Comment = "", Synonym = "Сотрудники")]
        [StringLength(100)]
        public string КраткийСоставДокумента {get; set;}
        [Description1C8(Name = "ДокументОснование", Comment = "", Synonym = "Документ основание")]
        public Документ.УстарелоОтражениеВзаиморасчетовСКонтрагентамиВ1ДФ ДокументОснование {get; set;}
        [Description1C8(Name = "СуммаДокумента", Comment = "", Synonym = "Сумма")]
        // Format 15.2
        public decimal СуммаДокумента {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "РаботникиОрганизации", Comment = "", Synonym = "Работники организации")]
        public List<УстарелоВедомостьНаВыплатуЗарплаты_РаботникиОрганизации> УстарелоВедомостьНаВыплатуЗарплатыРаботникиОрганизации {get;set;}
        [Description1C8(Name = "ПараметрыОплаты", Comment = "", Synonym = "Параметры оплаты")]
        public List<УстарелоВедомостьНаВыплатуЗарплаты_ПараметрыОплаты> УстарелоВедомостьНаВыплатуЗарплатыПараметрыОплаты {get;set;}
        [Description1C8(Name = "Взносы", Comment = "", Synonym = "Взносы")]
        public List<УстарелоВедомостьНаВыплатуЗарплаты_Взносы> УстарелоВедомостьНаВыплатуЗарплатыВзносы {get;set;}
        [Description1C8(Name = "НДФЛ", Comment = "", Synonym = "НДФЛ")]
        public List<УстарелоВедомостьНаВыплатуЗарплаты_НДФЛ> УстарелоВедомостьНаВыплатуЗарплатыНДФЛ {get;set;}
        [Description1C8(Name = "ВзносыФОТ", Comment = "", Synonym = "Взносы ФОТ")]
        public List<УстарелоВедомостьНаВыплатуЗарплаты_ВзносыФОТ> УстарелоВедомостьНаВыплатуЗарплатыВзносыФОТ {get;set;}
        [Description1C8(Name = "УдалитьЗарплата", Comment = "", Synonym = "(не используется) Зарплата")]
        public List<УстарелоВедомостьНаВыплатуЗарплаты_УдалитьЗарплата> УстарелоВедомостьНаВыплатуЗарплатыУдалитьЗарплата {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "РаботникиОрганизации", Comment = "", Synonym = "Работники организации")]
    [Table("UstareloVedomostNaVyplatuZarplaty_RabotnykyOrhanyzatsyy")]
    public class УстарелоВедомостьНаВыплатуЗарплаты_РаботникиОрганизации
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Авторасчет", Comment = "", Synonym = "Авторасчет")]
        public bool Авторасчет {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "Физлицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица Физлицо {get; set;}
        [Description1C8(Name = "СуммаОкругления", Comment = "", Synonym = "Сумма округления")]
        // Format 10.2
        public decimal СуммаОкругления {get; set;}
        [Description1C8(Name = "ВыплаченностьЗарплаты", Comment = "", Synonym = "Выплаченность зарплаты")]
        public Enums.УстарелоВыплаченностьЗарплаты ВыплаченностьЗарплаты {get; set;}
        [Description1C8(Name = "СпособВыплаты", Comment = "", Synonym = "Способ выплаты")]
        public Enums.УстарелоСпособыВыплатыЗарплаты СпособВыплаты {get; set;}
        [Description1C8(Name = "Банк", Comment = "", Synonym = "Банк")]
        public Catalogs.Контрагенты Банк {get; set;}
        [Description1C8(Name = "НомерКарточки", Comment = "", Synonym = "Номер карточки")]
        [StringLength(16)]
        public string НомерКарточки {get; set;}
        [Description1C8(Name = "СуммаГрязными", Comment = "", Synonym = "Сумма грязными")]
        // Format 15.2
        public decimal СуммаГрязными {get; set;}
        [Description1C8(Name = "СуммаПромежуточная", Comment = "", Synonym = "Сумма промежуточная")]
        // Format 15.2
        public decimal СуммаПромежуточная {get; set;}
    }
    [Description1C8(Name = "ПараметрыОплаты", Comment = "", Synonym = "Параметры оплаты")]
    [Table("UstareloVedomostNaVyplatuZarplaty_ParametryOplaty")]
    public class УстарелоВедомостьНаВыплатуЗарплаты_ПараметрыОплаты
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "ПериодВзаиморасчетов", Comment = "", Synonym = "Период взаиморасчетов")]
        public DateTime ПериодВзаиморасчетов {get; set;}
        [Description1C8(Name = "СчетУчета", Comment = "", Synonym = "Счет учета")]
        public ПланСчетов.Хозрасчетный СчетУчета {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "СуммаОкругления", Comment = "", Synonym = "Сумма округления")]
        // Format 10.2
        public decimal СуммаОкругления {get; set;}
        [Description1C8(Name = "Ведомость", Comment = "", Synonym = "Ведомость")]
        public Документ.УстарелоВедомостьНаВыплатуЗарплаты Ведомость {get; set;}
        [Description1C8(Name = "Физлицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица Физлицо {get; set;}
    }
    [Description1C8(Name = "Взносы", Comment = "", Synonym = "Взносы")]
    [Table("UstareloVedomostNaVyplatuZarplaty_Vznosy")]
    public class УстарелоВедомостьНаВыплатуЗарплаты_Взносы
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Авторасчет", Comment = "", Synonym = "Авторасчет")]
        public bool Авторасчет {get; set;}
        [Description1C8(Name = "ПериодВзаиморасчетов", Comment = "", Synonym = "Период взаиморасчетов")]
        public DateTime ПериодВзаиморасчетов {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "Налог", Comment = "", Synonym = "Налог")]
        public Catalogs.Налоги Налог {get; set;}
        [Description1C8(Name = "НомерПорога", Comment = "", Synonym = "Номер порога")]
        public Enums.ПорогиШкалыСтавокНалогов НомерПорога {get; set;}
        [Description1C8(Name = "СтатьяНалоговойДекларации", Comment = "", Synonym = "Статья налоговой декларации")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяНалоговойДекларации {get; set;}
        [Description1C8(Name = "ВидРасчета", Comment = "", Synonym = "Вид расчета")]
        public ПланВидовРасчета.УДАЛИТЬВзносы ВидРасчета {get; set;}
        [Description1C8(Name = "Предел", Comment = "", Synonym = "Предел")]
        // Format 15.3
        public decimal Предел {get; set;}
        [Description1C8(Name = "ДатаНачала", Comment = "", Synonym = "Дата начала")]
        public DateTime ДатаНачала {get; set;}
        [Description1C8(Name = "ДатаОкончания", Comment = "", Synonym = "Дата окончания")]
        public DateTime ДатаОкончания {get; set;}
        [Description1C8(Name = "БазовыйПериодНачало", Comment = "", Synonym = "Базовый период начало")]
        public DateTime БазовыйПериодНачало {get; set;}
        [Description1C8(Name = "БазовыйПериодКонец", Comment = "", Synonym = "Базовый период конец")]
        public DateTime БазовыйПериодКонец {get; set;}
        [Description1C8(Name = "База", Comment = "", Synonym = "База")]
        // Format 16.2
        public decimal База {get; set;}
        [Description1C8(Name = "БазаВзноса", Comment = "База налога с учетом ограничений", Synonym = "База взноса")]
        // Format 16.2
        public decimal БазаВзноса {get; set;}
        [Description1C8(Name = "Результат", Comment = "", Synonym = "Результат")]
        // Format 16.2
        public decimal Результат {get; set;}
        [Description1C8(Name = "ПодразделениеОрганизации", Comment = "", Synonym = "Подразделение организации")]
        public Catalogs.ПодразделенияОрганизаций ПодразделениеОрганизации {get; set;}
        [Description1C8(Name = "Ставка", Comment = "", Synonym = "Ставка")]
        // Format 10.4
        public decimal Ставка {get; set;}
        [Description1C8(Name = "Сторно", Comment = "", Synonym = "Сторно")]
        public bool Сторно {get; set;}
        [Description1C8(Name = "УдалитьБазаЗаМесяц", Comment = "", Synonym = "(не используется) База за месяц")]
        // Format 15.2
        public decimal УдалитьБазаЗаМесяц {get; set;}
        [Description1C8(Name = "УдалитьБазаВзносаЗаМесяц", Comment = "", Synonym = "(не используется) База взноса за месяц")]
        // Format 15.2
        public decimal УдалитьБазаВзносаЗаМесяц {get; set;}
        [Description1C8(Name = "УдалитьФизлицо", Comment = "", Synonym = "(не используется) Физическое лицо")]
        public Catalogs.ФизическиеЛица УдалитьФизлицо {get; set;}
        [Description1C8(Name = "БазаВычет", Comment = "База (вычет)", Synonym = "База (вычет)")]
        // Format 16.2
        public decimal БазаВычет {get; set;}
        [Description1C8(Name = "КодКатегорииЗЛ", Comment = "", Synonym = "Код категории застрахованного лица")]
        // Format 2.0
        public long КодКатегорииЗЛ {get; set;}
        [Description1C8(Name = "ТипНачисления", Comment = "", Synonym = "Тип начисления")]
        // Format 2.0
        public long ТипНачисления {get; set;}
        [Description1C8(Name = "БазаОтпускные", Comment = "", Synonym = "База (отпускные)")]
        // Format 16.2
        public decimal БазаОтпускные {get; set;}
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
        [Description1C8(Name = "СтавкаПолная", Comment = "", Synonym = "Ставка полная")]
        // Format 10.4
        public decimal СтавкаПолная {get; set;}
        [Description1C8(Name = "РезультатПолная", Comment = "", Synonym = "Результат по полной ставке")]
        // Format 16.6
        public decimal РезультатПолная {get; set;}
    }
    [Description1C8(Name = "НДФЛ", Comment = "", Synonym = "НДФЛ")]
    [Table("UstareloVedomostNaVyplatuZarplaty_NDFL")]
    public class УстарелоВедомостьНаВыплатуЗарплаты_НДФЛ
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Авторасчет", Comment = "", Synonym = "Авторасчет")]
        public bool Авторасчет {get; set;}
        [Description1C8(Name = "ПериодВзаиморасчетов", Comment = "", Synonym = "Период взаиморасчетов")]
        public DateTime ПериодВзаиморасчетов {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Контрагенты Сотрудник {get; set;}
        [Description1C8(Name = "ДоходНДФЛ", Comment = "", Synonym = "Доход НДФЛ")]
        public Catalogs.УстарелоВидыДоходовНДФЛ ДоходНДФЛ {get; set;}
        [Description1C8(Name = "ВидСтавки", Comment = "", Synonym = "Вид ставки")]
        public Enums.ВидыСтавокНДФЛ ВидСтавки {get; set;}
        [Description1C8(Name = "НалоговыйПериод", Comment = "", Synonym = "Налоговый период")]
        public DateTime НалоговыйПериод {get; set;}
        [Description1C8(Name = "Доход", Comment = "", Synonym = "Доход")]
        // Format 15.2
        public decimal Доход {get; set;}
        [Description1C8(Name = "Налог", Comment = "", Synonym = "Налог")]
        // Format 15.2
        public decimal Налог {get; set;}
        [Description1C8(Name = "Льгота", Comment = "", Synonym = "Льгота")]
        public Catalogs.УстарелоВидыЛьготПоНДФЛ Льгота {get; set;}
        [Description1C8(Name = "КоличествоЛьгот", Comment = "", Synonym = "Количество льгот")]
        // Format 5.2
        public decimal КоличествоЛьгот {get; set;}
        [Description1C8(Name = "Сторно", Comment = "", Synonym = "Сторно")]
        public bool Сторно {get; set;}
        [Description1C8(Name = "УдалитьФизЛицо", Comment = "", Synonym = "(не используется) Физическое лицо")]
        public Catalogs.ФизическиеЛица УдалитьФизЛицо {get; set;}
        [Description1C8(Name = "УвеличеннаяСтавка", Comment = "", Synonym = "Увеличенная ставка")]
        public Enums.ВидыСтавокНДФЛ УвеличеннаяСтавка {get; set;}
        [Description1C8(Name = "ДоходПолный", Comment = "", Synonym = "Доход полный")]
        // Format 15.2
        public decimal ДоходПолный {get; set;}
    }
    [Description1C8(Name = "ВзносыФОТ", Comment = "", Synonym = "Взносы ФОТ")]
    [Table("UstareloVedomostNaVyplatuZarplaty_VznosyFOT")]
    public class УстарелоВедомостьНаВыплатуЗарплаты_ВзносыФОТ
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Авторасчет", Comment = "", Synonym = "Авторасчет")]
        public bool Авторасчет {get; set;}
        [Description1C8(Name = "ПериодВзаиморасчетов", Comment = "", Synonym = "Период взаиморасчетов")]
        public DateTime ПериодВзаиморасчетов {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "Налог", Comment = "", Synonym = "Налог")]
        public Catalogs.Налоги Налог {get; set;}
        [Description1C8(Name = "НомерПорога", Comment = "", Synonym = "Номер порога")]
        public Enums.ПорогиШкалыСтавокНалогов НомерПорога {get; set;}
        [Description1C8(Name = "СтатьяНалоговойДекларации", Comment = "", Synonym = "Статья налоговой декларации")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяНалоговойДекларации {get; set;}
        [Description1C8(Name = "ВидРасчета", Comment = "", Synonym = "Вид расчета")]
        public ПланВидовРасчета.УДАЛИТЬВзносы ВидРасчета {get; set;}
        [Description1C8(Name = "Предел", Comment = "", Synonym = "Предел")]
        // Format 15.3
        public decimal Предел {get; set;}
        [Description1C8(Name = "ДатаНачала", Comment = "", Synonym = "Дата начала")]
        public DateTime ДатаНачала {get; set;}
        [Description1C8(Name = "ДатаОкончания", Comment = "", Synonym = "Дата окончания")]
        public DateTime ДатаОкончания {get; set;}
        [Description1C8(Name = "БазовыйПериодНачало", Comment = "", Synonym = "Базовый период начало")]
        public DateTime БазовыйПериодНачало {get; set;}
        [Description1C8(Name = "БазовыйПериодКонец", Comment = "", Synonym = "Базовый период конец")]
        public DateTime БазовыйПериодКонец {get; set;}
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
        [Description1C8(Name = "Сторно", Comment = "", Synonym = "Сторно")]
        public bool Сторно {get; set;}
        [Description1C8(Name = "УдалитьБазаЗаМесяц", Comment = "", Synonym = "(не используется) База за месяц")]
        // Format 15.2
        public decimal УдалитьБазаЗаМесяц {get; set;}
        [Description1C8(Name = "УдалитьБазаВзносаЗаМесяц", Comment = "", Synonym = "(не используется) База взноса за месяц")]
        // Format 15.2
        public decimal УдалитьБазаВзносаЗаМесяц {get; set;}
        [Description1C8(Name = "УдалитьПодразделениеОрганизации", Comment = "", Synonym = "(не используется) Подразделение организации")]
        public Catalogs.ПодразделенияОрганизаций УдалитьПодразделениеОрганизации {get; set;}
        [Description1C8(Name = "УдалитьФизлицо", Comment = "", Synonym = "(не используется) Физическое лицо")]
        public Catalogs.ФизическиеЛица УдалитьФизлицо {get; set;}
        [Description1C8(Name = "БазаВычет", Comment = "База (вычет)", Synonym = "База (вычет)")]
        // Format 16.2
        public decimal БазаВычет {get; set;}
        [Description1C8(Name = "КодКатегорииЗЛ", Comment = "", Synonym = "Код категории застрахованного лица")]
        // Format 2.0
        public long КодКатегорииЗЛ {get; set;}
        [Description1C8(Name = "ТипНачисления", Comment = "", Synonym = "Тип начисления")]
        // Format 2.0
        public long ТипНачисления {get; set;}
        [Description1C8(Name = "БазаОтпускные", Comment = "", Synonym = "База (отпускные)")]
        // Format 16.2
        public decimal БазаОтпускные {get; set;}
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
        [Description1C8(Name = "СтавкаПолная", Comment = "", Synonym = "Ставка полная")]
        // Format 10.4
        public decimal СтавкаПолная {get; set;}
        [Description1C8(Name = "РезультатПолная", Comment = "", Synonym = "Результат по полной ставке")]
        // Format 16.6
        public decimal РезультатПолная {get; set;}
    }
    [Description1C8(Name = "УдалитьЗарплата", Comment = "", Synonym = "(не используется) Зарплата")]
    [Table("UstareloVedomostNaVyplatuZarplaty_UdalytZarplata")]
    public class УстарелоВедомостьНаВыплатуЗарплаты_УдалитьЗарплата
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Физлицо", Comment = "", Synonym = "Физлицо")]
        public Catalogs.ФизическиеЛица Физлицо {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "ВыплаченностьЗарплаты", Comment = "", Synonym = "Выплаченность зарплаты")]
        public Enums.УстарелоВыплаченностьЗарплаты ВыплаченностьЗарплаты {get; set;}
        [Description1C8(Name = "СчетУчета", Comment = "", Synonym = "Счет учета")]
        public ПланСчетов.Хозрасчетный СчетУчета {get; set;}
        [Description1C8(Name = "ВидВзаиморасчетов", Comment = "(Регл)", Synonym = "Вид взаиморасчетов")]
        public Enums.УдалитьВидыВзаиморасчетовСРаботниками ВидВзаиморасчетов {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
    }
}
