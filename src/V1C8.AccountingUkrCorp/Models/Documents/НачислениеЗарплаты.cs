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
    [Table("NachyslenyeZarplaty")]
    [Description1C8(Name = "НачислениеЗарплаты", Comment = "", Synonym = "Начисление зарплаты и взносов")]
    public class НачислениеЗарплаты:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "МесяцНачисления", Comment = "", Synonym = "Месяц начисления")]
        public DateTime МесяцНачисления {get; set;}
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "РежимДоначисления", Comment = "", Synonym = "Режим доначисления")]
        public bool РежимДоначисления {get; set;}
        [Description1C8(Name = "ПериодыПерерасчета", Comment = "", Synonym = "Периоды перерасчета")]
        [StringLength(100)]
        public string ПериодыПерерасчета {get; set;}
        [Description1C8(Name = "Начислено", Comment = "", Synonym = "Начислено")]
        // Format 13.2
        public decimal Начислено {get; set;}
        [Description1C8(Name = "Удержано", Comment = "", Synonym = "Удержано")]
        // Format 13.2
        public decimal Удержано {get; set;}
        [Description1C8(Name = "ПорядокВыплаты", Comment = "", Synonym = "Порядок выплаты")]
        public Enums.ХарактерВыплатыЗарплаты ПорядокВыплаты {get; set;}
        [Description1C8(Name = "ПланируемаяДатаВыплаты", Comment = "", Synonym = "Планируемая дата выплаты")]
        public DateTime ПланируемаяДатаВыплаты {get; set;}
        [Description1C8(Name = "КраткийСоставДокумента", Comment = "Краткий перечень сотрудников, включенных в документ", Synonym = "Сотрудники")]
        [StringLength(100)]
        public string КраткийСоставДокумента {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "НачислениеЗарплатыВоеннослужащим", Comment = "", Synonym = "Начисление зарплаты военнослужащим")]
        public bool НачислениеЗарплатыВоеннослужащим {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Взносы", Comment = "", Synonym = "Взносы")]
        public List<НачислениеЗарплаты_Взносы> НачислениеЗарплатыВзносы {get;set;}
        [Description1C8(Name = "Начисления", Comment = "", Synonym = "Начисления")]
        public List<НачислениеЗарплаты_Начисления> НачислениеЗарплатыНачисления {get;set;}
        [Description1C8(Name = "НачисленияПерерасчет", Comment = "", Synonym = "Начисления перерасчет")]
        public List<НачислениеЗарплаты_НачисленияПерерасчет> НачислениеЗарплатыНачисленияПерерасчет {get;set;}
        [Description1C8(Name = "НачисленияПоДоговорам", Comment = "", Synonym = "Начисления по договорам")]
        public List<НачислениеЗарплаты_НачисленияПоДоговорам> НачислениеЗарплатыНачисленияПоДоговорам {get;set;}
        [Description1C8(Name = "НДФЛ", Comment = "", Synonym = "НДФЛ")]
        public List<НачислениеЗарплаты_НДФЛ> НачислениеЗарплатыНДФЛ {get;set;}
        [Description1C8(Name = "ПогашениеЗаймов", Comment = "", Synonym = "Погашение займов")]
        public List<НачислениеЗарплаты_ПогашениеЗаймов> НачислениеЗарплатыПогашениеЗаймов {get;set;}
        [Description1C8(Name = "Показатели", Comment = "", Synonym = "Показатели")]
        public List<НачислениеЗарплаты_Показатели> НачислениеЗарплатыПоказатели {get;set;}
        [Description1C8(Name = "Пособия", Comment = "", Synonym = "Пособия")]
        public List<НачислениеЗарплаты_Пособия> НачислениеЗарплатыПособия {get;set;}
        [Description1C8(Name = "Удержания", Comment = "", Synonym = "Удержания")]
        public List<НачислениеЗарплаты_Удержания> НачислениеЗарплатыУдержания {get;set;}
        [Description1C8(Name = "ФизическиеЛица", Comment = "", Synonym = "Физические лица")]
        public List<НачислениеЗарплаты_ФизическиеЛица> НачислениеЗарплатыФизическиеЛица {get;set;}
        [Description1C8(Name = "РаспределениеРезультатовНачислений", Comment = "", Synonym = "Распределение результатов начислений")]
        public List<НачислениеЗарплаты_РаспределениеРезультатовНачислений> НачислениеЗарплатыРаспределениеРезультатовНачислений {get;set;}
        [Description1C8(Name = "РаспределениеРезультатовУдержаний", Comment = "", Synonym = "Распределение результатов удержаний")]
        public List<НачислениеЗарплаты_РаспределениеРезультатовУдержаний> НачислениеЗарплатыРаспределениеРезультатовУдержаний {get;set;}
        [Description1C8(Name = "ПредставлениеРаспределенияРезультатовРасчета", Comment = "", Synonym = "Представление распределения результатов расчета")]
        public List<НачислениеЗарплаты_ПредставлениеРаспределенияРезультатовРасчета> НачислениеЗарплатыПредставлениеРаспределенияРезультатовРасчета {get;set;}
        [Description1C8(Name = "Льготы", Comment = "", Synonym = "Льготы")]
        public List<НачислениеЗарплаты_Льготы> НачислениеЗарплатыЛьготы {get;set;}
        [Description1C8(Name = "РаспределениеПоТерриториямУсловиямТруда", Comment = "", Synonym = "Распределение по территориям и условиям труда")]
        public List<НачислениеЗарплаты_РаспределениеПоТерриториямУсловиямТруда> НачислениеЗарплатыРаспределениеПоТерриториямУсловиямТруда {get;set;}
        [Description1C8(Name = "ПособияПерерасчет", Comment = "", Synonym = "Перерасчет пособий")]
        public List<НачислениеЗарплаты_ПособияПерерасчет> НачислениеЗарплатыПособияПерерасчет {get;set;}
        [Description1C8(Name = "ВзносыФОТ", Comment = "", Synonym = "Взносы ФОТ")]
        public List<НачислениеЗарплаты_ВзносыФОТ> НачислениеЗарплатыВзносыФОТ {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Взносы", Comment = "", Synonym = "Взносы")]
    [Table("NachyslenyeZarplaty_Vznosy")]
    public class НачислениеЗарплаты_Взносы
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "ДатаПолученияДохода", Comment = "", Synonym = "Дата получения дохода")]
        public DateTime ДатаПолученияДохода {get; set;}
        [Description1C8(Name = "ВидЕСВ", Comment = "", Synonym = "Вид ЕСВ")]
        public Enums.ВидыЕСВ ВидЕСВ {get; set;}
        [Description1C8(Name = "КатегорияЕСВ", Comment = "", Synonym = "Категория ЕСВ")]
        public Catalogs.КатегорииЗастрахованныхЛицЕСВ КатегорияЕСВ {get; set;}
        [Description1C8(Name = "ДатаНачала", Comment = "Период параметров налога начало", Synonym = "Дата начала")]
        public DateTime ДатаНачала {get; set;}
        [Description1C8(Name = "ДатаОкончания", Comment = "Период параметров налога окончания", Synonym = "Дата окончания")]
        public DateTime ДатаОкончания {get; set;}
        [Description1C8(Name = "Налог", Comment = "", Synonym = "Налог")]
        public Catalogs.Налоги Налог {get; set;}
        [Description1C8(Name = "СтатьяНалоговойДекларации", Comment = "", Synonym = "Статья налоговой декларации")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяНалоговойДекларации {get; set;}
        [Description1C8(Name = "База", Comment = "", Synonym = "База")]
        // Format 16.2
        public decimal База {get; set;}
        [Description1C8(Name = "БазаОтпускные", Comment = "", Synonym = "База (отпускные)")]
        // Format 16.2
        public decimal БазаОтпускные {get; set;}
        [Description1C8(Name = "БазаВзноса", Comment = "База налога с учетом ограничений", Synonym = "База взноса")]
        // Format 16.2
        public decimal БазаВзноса {get; set;}
        [Description1C8(Name = "БазаДоначисление", Comment = "", Synonym = "База (доначисление)")]
        // Format 16.2
        public decimal БазаДоначисление {get; set;}
        [Description1C8(Name = "Результат", Comment = "", Synonym = "Результат")]
        // Format 16.2
        public decimal Результат {get; set;}
        [Description1C8(Name = "РезультатДоначисление", Comment = "", Synonym = "Результат (доначисление)")]
        // Format 16.2
        public decimal РезультатДоначисление {get; set;}
        [Description1C8(Name = "Предел", Comment = "", Synonym = "Предел")]
        // Format 15.3
        public decimal Предел {get; set;}
        [Description1C8(Name = "Ставка", Comment = "", Synonym = "Ставка")]
        // Format 10.4
        public decimal Ставка {get; set;}
        [Description1C8(Name = "МинимальнаяБаза", Comment = "", Synonym = "Минимальная база")]
        // Format 15.3
        public decimal МинимальнаяБаза {get; set;}
        [Description1C8(Name = "БазаВычет", Comment = "База (вычет)", Synonym = "База (вычет)")]
        // Format 16.2
        public decimal БазаВычет {get; set;}
        [Description1C8(Name = "КоэффициентСтавки", Comment = "", Synonym = "Коэффициент ставки")]
        // Format 10.4
        public decimal КоэффициентСтавки {get; set;}
        [Description1C8(Name = "ТипНачисления", Comment = "", Synonym = "Тип начисления")]
        // Format 2.0
        public long ТипНачисления {get; set;}
        [Description1C8(Name = "СтавкаПолная", Comment = "", Synonym = "Ставка полная")]
        // Format 10.4
        public decimal СтавкаПолная {get; set;}
        [Description1C8(Name = "РезультатПолная", Comment = "", Synonym = "Результат по полн. ставке")]
        // Format 16.2
        public decimal РезультатПолная {get; set;}
    }
    [Description1C8(Name = "Начисления", Comment = "", Synonym = "Начисления")]
    [Table("NachyslenyeZarplaty_Nachyslenyia")]
    public class НачислениеЗарплаты_Начисления
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "ДатаНачала", Comment = "", Synonym = "Дата начала")]
        public DateTime ДатаНачала {get; set;}
        [Description1C8(Name = "ДатаОкончания", Comment = "", Synonym = "Дата окончания")]
        public DateTime ДатаОкончания {get; set;}
        [Description1C8(Name = "Начисление", Comment = "", Synonym = "Начисление")]
        public ПланВидовРасчета.Начисления Начисление {get; set;}
        [Description1C8(Name = "Результат", Comment = "", Synonym = "Результат")]
        // Format 13.2
        public decimal Результат {get; set;}
        [Description1C8(Name = "ОтработаноДней", Comment = "", Synonym = "дн.")]
        // Format 7.2
        public decimal ОтработаноДней {get; set;}
        [Description1C8(Name = "ОтработаноЧасов", Comment = "", Synonym = "чс.")]
        // Format 7.2
        public decimal ОтработаноЧасов {get; set;}
        [Description1C8(Name = "НормаДней", Comment = "", Synonym = "Норма дн.")]
        // Format 7.2
        public decimal НормаДней {get; set;}
        [Description1C8(Name = "НормаЧасов", Comment = "", Synonym = "Норма чс.")]
        // Format 7.2
        public decimal НормаЧасов {get; set;}
        [Description1C8(Name = "ФиксСтрока", Comment = "", Synonym = "Фикс строка")]
        public bool ФиксСтрока {get; set;}
        [Description1C8(Name = "ФиксЗаполнение", Comment = "", Synonym = "Фиксировано заполнение")]
        public bool ФиксЗаполнение {get; set;}
        [Description1C8(Name = "ФиксРасчетВремени", Comment = "", Synonym = "Фиксирован расчет времени")]
        public bool ФиксРасчетВремени {get; set;}
        [Description1C8(Name = "ФиксРасчет", Comment = "", Synonym = "Фиксирован расчет")]
        public bool ФиксРасчет {get; set;}
        [Description1C8(Name = "РасчетнаяБазаЗаЕдиницуНормыВремени", Comment = "Расчетная база на единицу нормы времени для расчета сторно-записей", Synonym = "Расчетная база за единицу нормы времени")]
        // Format 15.2
        public decimal РасчетнаяБазаЗаЕдиницуНормыВремени {get; set;}
        [Description1C8(Name = "ГрафикРаботы", Comment = "", Synonym = "График работы")]
        public Catalogs.ГрафикиРаботыСотрудников ГрафикРаботы {get; set;}
        [Description1C8(Name = "ВидУчетаВремени", Comment = "", Synonym = "Вид учета времени")]
        public Catalogs.ВидыИспользованияРабочегоВремени ВидУчетаВремени {get; set;}
        [Description1C8(Name = "ВремяВЧасах", Comment = "", Synonym = "Время в часах")]
        public bool ВремяВЧасах {get; set;}
        [Description1C8(Name = "ГрафикРаботыНорма", Comment = "", Synonym = "График работы норма")]
        public Catalogs.ГрафикиРаботыСотрудников ГрафикРаботыНорма {get; set;}
        [Description1C8(Name = "ИдентификаторСтрокиВидаРасчета", Comment = "", Synonym = "Идентификатор строки вида расчета")]
        // Format 7.0
        public long ИдентификаторСтрокиВидаРасчета {get; set;}
        [Description1C8(Name = "ПериодРегистрацииВремени", Comment = "", Synonym = "Период регистрации времени")]
        public DateTime ПериодРегистрацииВремени {get; set;}
        [Description1C8(Name = "ОплаченоДней", Comment = "", Synonym = "Оплачено дней")]
        // Format 7.2
        public decimal ОплаченоДней {get; set;}
        [Description1C8(Name = "ОплаченоЧасов", Comment = "", Synonym = "Оплачено часов")]
        // Format 7.2
        public decimal ОплаченоЧасов {get; set;}
        [Description1C8(Name = "ДокументОснование", Comment = "", Synonym = "Документ основание")]
        public Documents.НазначениеПлановогоНачисления ДокументОснование {get; set;}
        [Description1C8(Name = "ПериодДействия", Comment = "", Synonym = "Период действия")]
        public DateTime ПериодДействия {get; set;}
        [Description1C8(Name = "Должность", Comment = "", Synonym = "Должность")]
        public Catalogs.Должности Должность {get; set;}
    }
    [Description1C8(Name = "НачисленияПерерасчет", Comment = "", Synonym = "Начисления перерасчет")]
    [Table("NachyslenyeZarplaty_NachyslenyiaPereraschet")]
    public class НачислениеЗарплаты_НачисленияПерерасчет
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "ДатаНачала", Comment = "", Synonym = "Дата начала")]
        public DateTime ДатаНачала {get; set;}
        [Description1C8(Name = "ДатаОкончания", Comment = "", Synonym = "Дата окончания")]
        public DateTime ДатаОкончания {get; set;}
        [Description1C8(Name = "Начисление", Comment = "", Synonym = "Начисление")]
        public ПланВидовРасчета.Начисления Начисление {get; set;}
        [Description1C8(Name = "Результат", Comment = "", Synonym = "Результат")]
        // Format 13.2
        public decimal Результат {get; set;}
        [Description1C8(Name = "ОтработаноДней", Comment = "", Synonym = "дн.")]
        // Format 7.2
        public decimal ОтработаноДней {get; set;}
        [Description1C8(Name = "ОтработаноЧасов", Comment = "", Synonym = "чс.")]
        // Format 7.2
        public decimal ОтработаноЧасов {get; set;}
        [Description1C8(Name = "НормаДней", Comment = "", Synonym = "Норма дн.")]
        // Format 7.2
        public decimal НормаДней {get; set;}
        [Description1C8(Name = "НормаЧасов", Comment = "", Synonym = "Норма чс.")]
        // Format 7.2
        public decimal НормаЧасов {get; set;}
        [Description1C8(Name = "ФиксСтрока", Comment = "", Synonym = "Фикс строка")]
        public bool ФиксСтрока {get; set;}
        [Description1C8(Name = "ФиксЗаполнение", Comment = "", Synonym = "Фиксировано заполнение")]
        public bool ФиксЗаполнение {get; set;}
        [Description1C8(Name = "ФиксРасчетВремени", Comment = "", Synonym = "Фиксирован расчет времени")]
        public bool ФиксРасчетВремени {get; set;}
        [Description1C8(Name = "ФиксРасчет", Comment = "", Synonym = "Фиксирован расчет")]
        public bool ФиксРасчет {get; set;}
        [Description1C8(Name = "РасчетнаяБазаЗаЕдиницуНормыВремени", Comment = "Расчетная база на единицу нормы времени для расчета сторно-записей", Synonym = "Расчетная база за единицу нормы времени")]
        // Format 15.2
        public decimal РасчетнаяБазаЗаЕдиницуНормыВремени {get; set;}
        [Description1C8(Name = "КодВычета", Comment = "", Synonym = "Код вычета")]
        public Catalogs.ВидыЛьготПоНДФЛ КодВычета {get; set;}
        [Description1C8(Name = "СуммаВычета", Comment = "", Synonym = "Сумма вычета")]
        // Format 15.2
        public decimal СуммаВычета {get; set;}
        [Description1C8(Name = "ГрафикРаботы", Comment = "", Synonym = "График работы")]
        public Catalogs.ГрафикиРаботыСотрудников ГрафикРаботы {get; set;}
        [Description1C8(Name = "ВидУчетаВремени", Comment = "", Synonym = "Вид учета времени")]
        public Catalogs.ВидыИспользованияРабочегоВремени ВидУчетаВремени {get; set;}
        [Description1C8(Name = "ВремяВЧасах", Comment = "", Synonym = "Время в часах")]
        public bool ВремяВЧасах {get; set;}
        [Description1C8(Name = "ГрафикРаботыНорма", Comment = "", Synonym = "График работы норма")]
        public Catalogs.ГрафикиРаботыСотрудников ГрафикРаботыНорма {get; set;}
        [Description1C8(Name = "ИдентификаторСтрокиВидаРасчета", Comment = "", Synonym = "Идентификатор строки вида расчета")]
        // Format 7.0
        public long ИдентификаторСтрокиВидаРасчета {get; set;}
        [Description1C8(Name = "ПериодРегистрацииВремени", Comment = "", Synonym = "Период регистрации времени")]
        public DateTime ПериодРегистрацииВремени {get; set;}
        [Description1C8(Name = "ОплаченоДней", Comment = "", Synonym = "Оплачено дней")]
        // Format 7.2
        public decimal ОплаченоДней {get; set;}
        [Description1C8(Name = "ОплаченоЧасов", Comment = "", Synonym = "Оплачено часов")]
        // Format 7.2
        public decimal ОплаченоЧасов {get; set;}
        [Description1C8(Name = "Сторно", Comment = "", Synonym = "Сторно")]
        public bool Сторно {get; set;}
        [Description1C8(Name = "ФиксСторно", Comment = "", Synonym = "Не рассчитываемая сторно-запись")]
        public bool ФиксСторно {get; set;}
        [Description1C8(Name = "СторнируемыйДокумент", Comment = "Документ, который зарегистрировал сторнируемое начисление", Synonym = "Сторнируемый документ")]
        public Documents.СторнированиеНачислений СторнируемыйДокумент {get; set;}
        [Description1C8(Name = "ДокументОснование", Comment = "", Synonym = "Документ основание")]
        public Documents.НазначениеПлановогоНачисления ДокументОснование {get; set;}
        [Description1C8(Name = "ПериодДействия", Comment = "", Synonym = "Период действия")]
        public DateTime ПериодДействия {get; set;}
        [Description1C8(Name = "Должность", Comment = "", Synonym = "Должность")]
        public Catalogs.Должности Должность {get; set;}
    }
    [Description1C8(Name = "НачисленияПоДоговорам", Comment = "", Synonym = "Начисления по договорам")]
    [Table("NachyslenyeZarplaty_NachyslenyiaPoDohovoram")]
    public class НачислениеЗарплаты_НачисленияПоДоговорам
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "ДатаНачала", Comment = "", Synonym = "Дата начала")]
        public DateTime ДатаНачала {get; set;}
        [Description1C8(Name = "ДатаОкончания", Comment = "", Synonym = "Дата окончания")]
        public DateTime ДатаОкончания {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "КодВычета", Comment = "", Synonym = "Код вычета")]
        public Catalogs.ВидыЛьготПоНДФЛ КодВычета {get; set;}
        [Description1C8(Name = "СуммаВычета", Comment = "", Synonym = "Сумма вычета")]
        // Format 15.2
        public decimal СуммаВычета {get; set;}
        [Description1C8(Name = "ДокументОснование", Comment = "", Synonym = "Документ основание")]
        public Documents.ДоговорАвторскогоЗаказа ДокументОснование {get; set;}
        [Description1C8(Name = "Результат", Comment = "", Synonym = "Результат")]
        // Format 13.2
        public decimal Результат {get; set;}
        [Description1C8(Name = "ФиксРасчет", Comment = "", Synonym = "Фиксирован расчет")]
        public bool ФиксРасчет {get; set;}
        [Description1C8(Name = "ФиксСтрока", Comment = "", Synonym = "Фикс строка")]
        public bool ФиксСтрока {get; set;}
        [Description1C8(Name = "КодДохода", Comment = "", Synonym = "Код дохода")]
        public Catalogs.ВидыДоходовНДФЛ КодДохода {get; set;}
        [Description1C8(Name = "ПланируемаяДатаВыплаты", Comment = "", Synonym = "Планируемая дата выплаты")]
        public DateTime ПланируемаяДатаВыплаты {get; set;}
        [Description1C8(Name = "ИдентификаторСтроки", Comment = "", Synonym = "Идентификатор строки")]
        // Format 7.0
        public long ИдентификаторСтроки {get; set;}
        [Description1C8(Name = "КатегорияЕСВ", Comment = "", Synonym = "Категория ЕСВ")]
        public Catalogs.КатегорииЗастрахованныхЛицЕСВ КатегорияЕСВ {get; set;}
    }
    [Description1C8(Name = "НДФЛ", Comment = "", Synonym = "НДФЛ")]
    [Table("NachyslenyeZarplaty_NDFL")]
    public class НачислениеЗарплаты_НДФЛ
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "НалоговыйПериод", Comment = "", Synonym = "Налоговый период")]
        public DateTime НалоговыйПериод {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ТерриторииВыполненияРабот Подразделение {get; set;}
        [Description1C8(Name = "Налог", Comment = "", Synonym = "Налог")]
        // Format 15.2
        public decimal Налог {get; set;}
        [Description1C8(Name = "ФиксСтрока", Comment = "", Synonym = "Фикс строка")]
        public bool ФиксСтрока {get; set;}
        [Description1C8(Name = "ФиксРасчет", Comment = "", Synonym = "Фиксирован расчет")]
        public bool ФиксРасчет {get; set;}
        [Description1C8(Name = "ИдентификаторСтрокиНДФЛ", Comment = "", Synonym = "Идентификатор строки НДФЛ")]
        // Format 7.0
        public long ИдентификаторСтрокиНДФЛ {get; set;}
        [Description1C8(Name = "Доход", Comment = "ВидСтавки", Synonym = "Доход")]
        // Format 15.2
        public decimal Доход {get; set;}
        [Description1C8(Name = "ВидСтавки", Comment = "", Synonym = "Вид ставки")]
        public Enums.ВидыСтавокНДФЛ ВидСтавки {get; set;}
        [Description1C8(Name = "УвеличеннаяСтавка", Comment = "", Synonym = "Увеличенная ставка")]
        public Enums.ВидыСтавокНДФЛ УвеличеннаяСтавка {get; set;}
        [Description1C8(Name = "Льгота", Comment = "", Synonym = "Льгота")]
        public Catalogs.ВидыЛьготПоНДФЛ Льгота {get; set;}
        [Description1C8(Name = "КоличествоЛьгот", Comment = "", Synonym = "Количество льгот")]
        // Format 5.2
        public decimal КоличествоЛьгот {get; set;}
        [Description1C8(Name = "СуммаЛьготы", Comment = "", Synonym = "Сумма льготы")]
        // Format 15.2
        public decimal СуммаЛьготы {get; set;}
        [Description1C8(Name = "КодДохода", Comment = "", Synonym = "Код дохода")]
        public Catalogs.ВидыДоходовНДФЛ КодДохода {get; set;}
        [Description1C8(Name = "ДоходПолный", Comment = "", Synonym = "Доход полный")]
        // Format 15.2
        public decimal ДоходПолный {get; set;}
    }
    [Description1C8(Name = "ПогашениеЗаймов", Comment = "", Synonym = "Погашение займов")]
    [Table("NachyslenyeZarplaty_PohashenyeZaimov")]
    public class НачислениеЗарплаты_ПогашениеЗаймов
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "ДоговорЗайма", Comment = "", Synonym = "Договор займа")]
        public Documents.ДоговорЗаймаСотруднику ДоговорЗайма {get; set;}
        [Description1C8(Name = "НачисленоПроцентов", Comment = "", Synonym = "Начислено процентов")]
        // Format 15.2
        public decimal НачисленоПроцентов {get; set;}
        [Description1C8(Name = "ПогашениеПроцентов", Comment = "", Synonym = "Погашение процентов")]
        // Format 15.2
        public decimal ПогашениеПроцентов {get; set;}
        [Description1C8(Name = "ПогашениеЗайма", Comment = "", Synonym = "Погашение займа")]
        // Format 15.2
        public decimal ПогашениеЗайма {get; set;}
        [Description1C8(Name = "МатериальнаяВыгода", Comment = "", Synonym = "Материальная выгода")]
        // Format 15.2
        public decimal МатериальнаяВыгода {get; set;}
        [Description1C8(Name = "НалогНаМатериальнуюВыгоду", Comment = "", Synonym = "Налог на материальную выгоду")]
        // Format 13.0
        public long НалогНаМатериальнуюВыгоду {get; set;}
        [Description1C8(Name = "СтавкаНалогообложенияМатвыгоды", Comment = "", Synonym = "Ставка налогообложения матвыгоды")]
        [StringLength(10)]
        public string СтавкаНалогообложенияМатвыгоды {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "ИдентификаторСтроки", Comment = "", Synonym = "Идентификатор строки")]
        // Format 7.0
        public long ИдентификаторСтроки {get; set;}
    }
    [Description1C8(Name = "Показатели", Comment = "", Synonym = "Показатели")]
    [Table("NachyslenyeZarplaty_Pokazately")]
    public class НачислениеЗарплаты_Показатели
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Показатель", Comment = "", Synonym = "Показатель")]
        public Catalogs.ПоказателиРасчетаЗарплаты Показатель {get; set;}
        [Description1C8(Name = "Значение", Comment = "", Synonym = "Значение")]
        // Format 15.4
        public decimal Значение {get; set;}
        [Description1C8(Name = "ИдентификаторСтрокиВидаРасчета", Comment = "", Synonym = "Идентификатор строки вида расчета")]
        // Format 7.0
        public long ИдентификаторСтрокиВидаРасчета {get; set;}
    }
    [Description1C8(Name = "Пособия", Comment = "", Synonym = "Пособия")]
    [Table("NachyslenyeZarplaty_Posobyia")]
    public class НачислениеЗарплаты_Пособия
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "ВидЗанятости", Comment = "", Synonym = "Вид занятости")]
        public Enums.ВидыЗанятости ВидЗанятости {get; set;}
        [Description1C8(Name = "ДатаНачала", Comment = "", Synonym = "Дата начала")]
        public DateTime ДатаНачала {get; set;}
        [Description1C8(Name = "ДатаОкончания", Comment = "", Synonym = "Дата окончания")]
        public DateTime ДатаОкончания {get; set;}
        [Description1C8(Name = "Начисление", Comment = "", Synonym = "Начисление")]
        public ПланВидовРасчета.Начисления Начисление {get; set;}
        [Description1C8(Name = "Результат", Comment = "", Synonym = "Результат")]
        // Format 13.2
        public decimal Результат {get; set;}
        [Description1C8(Name = "РезультатВТомЧислеЗаСчетФБ", Comment = "", Synonym = "В том числе")]
        // Format 15.2
        public decimal РезультатВТомЧислеЗаСчетФБ {get; set;}
        [Description1C8(Name = "ФиксСтрока", Comment = "", Synonym = "Фикс строка")]
        public bool ФиксСтрока {get; set;}
        [Description1C8(Name = "ФиксЗаполнение", Comment = "", Synonym = "Фиксировано заполнение")]
        public bool ФиксЗаполнение {get; set;}
        [Description1C8(Name = "ФиксРасчетВремени", Comment = "", Synonym = "Фиксирован расчет времени")]
        public bool ФиксРасчетВремени {get; set;}
        [Description1C8(Name = "ФиксРасчет", Comment = "", Synonym = "Фиксирован расчет")]
        public bool ФиксРасчет {get; set;}
        [Description1C8(Name = "РасчетнаяБазаЗаЕдиницуНормыВремени", Comment = "Расчетная база на единицу нормы времени для расчета сторно-записей", Synonym = "Расчетная база за единицу нормы времени")]
        // Format 15.2
        public decimal РасчетнаяБазаЗаЕдиницуНормыВремени {get; set;}
        [Description1C8(Name = "ИдентификаторСтрокиВидаРасчета", Comment = "", Synonym = "Идентификатор строки вида расчета")]
        // Format 7.0
        public long ИдентификаторСтрокиВидаРасчета {get; set;}
        [Description1C8(Name = "ОплаченоДней", Comment = "", Synonym = "Оплачено дней")]
        // Format 7.2
        public decimal ОплаченоДней {get; set;}
        [Description1C8(Name = "ОплаченоЧасов", Comment = "", Synonym = "Оплачено часов")]
        // Format 7.2
        public decimal ОплаченоЧасов {get; set;}
        [Description1C8(Name = "СуммаВсегоПоУходуЗаПервымРебенком", Comment = "", Synonym = "Сумма пособия по уходу за первым ребенком, всего")]
        // Format 15.2
        public decimal СуммаВсегоПоУходуЗаПервымРебенком {get; set;}
        [Description1C8(Name = "СуммаСверхНормПоУходуЗаПервымРебенком", Comment = "", Synonym = "Сумма пособия по уходу за первым ребенком, сверх норм")]
        // Format 15.2
        public decimal СуммаСверхНормПоУходуЗаПервымРебенком {get; set;}
        [Description1C8(Name = "СуммаВсегоПоУходуЗаВторымРебенком", Comment = "", Synonym = "Сумма пособия по уходу за вторым ребенком, всего")]
        // Format 15.2
        public decimal СуммаВсегоПоУходуЗаВторымРебенком {get; set;}
        [Description1C8(Name = "СуммаСверхНормПоУходуЗаВторымРебенком", Comment = "", Synonym = "Сумма пособия по уходу за вторым ребенком, сверх норм")]
        // Format 15.2
        public decimal СуммаСверхНормПоУходуЗаВторымРебенком {get; set;}
        [Description1C8(Name = "ЛьготаПоПособию", Comment = "", Synonym = "Льгота по пособию")]
        public Enums.ОснованияЛьготПоПособию ЛьготаПоПособию {get; set;}
        [Description1C8(Name = "СтраховойСлучай", Comment = "", Synonym = "Страховой случай")]
        public Documents.ОтпускПоУходуЗаРебенком СтраховойСлучай {get; set;}
        [Description1C8(Name = "КоличествоДетей", Comment = "", Synonym = "Количество детей")]
        // Format 2.0
        public long КоличествоДетей {get; set;}
        [Description1C8(Name = "КоличествоПервыхДетей", Comment = "", Synonym = "Количество первых детей")]
        // Format 1.0
        public long КоличествоПервыхДетей {get; set;}
        [Description1C8(Name = "ПериодДействия", Comment = "", Synonym = "Период действия")]
        public DateTime ПериодДействия {get; set;}
    }
    [Description1C8(Name = "Удержания", Comment = "", Synonym = "Удержания")]
    [Table("NachyslenyeZarplaty_Uderzhanyia")]
    public class НачислениеЗарплаты_Удержания
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "ДатаНачала", Comment = "", Synonym = "Дата начала")]
        public DateTime ДатаНачала {get; set;}
        [Description1C8(Name = "ДатаОкончания", Comment = "", Synonym = "Дата окончания")]
        public DateTime ДатаОкончания {get; set;}
        [Description1C8(Name = "ДокументОснование", Comment = "", Synonym = "Документ основание")]
        public Documents.УдержаниеВСчетРасчетовПоПрочимОперациям ДокументОснование {get; set;}
        [Description1C8(Name = "Получатель", Comment = "", Synonym = "Получатель")]
        public Catalogs.Контрагенты Получатель {get; set;}
        [Description1C8(Name = "ПлатежныйАгент", Comment = "", Synonym = "Платежный агент")]
        public Catalogs.Контрагенты ПлатежныйАгент {get; set;}
        [Description1C8(Name = "Удержание", Comment = "", Synonym = "Удержание")]
        public ПланВидовРасчета.Удержания Удержание {get; set;}
        [Description1C8(Name = "ФиксСтрока", Comment = "", Synonym = "Фикс строка")]
        public bool ФиксСтрока {get; set;}
        [Description1C8(Name = "ФиксЗаполнение", Comment = "", Synonym = "Фиксировано заполнение")]
        public bool ФиксЗаполнение {get; set;}
        [Description1C8(Name = "ФиксРасчет", Comment = "", Synonym = "Фиксирован расчет")]
        public bool ФиксРасчет {get; set;}
        [Description1C8(Name = "Результат", Comment = "", Synonym = "Результат")]
        // Format 13.2
        public decimal Результат {get; set;}
        [Description1C8(Name = "ИдентификаторСтрокиВидаРасчета", Comment = "", Synonym = "Идентификатор строки вида расчета")]
        // Format 7.0
        public long ИдентификаторСтрокиВидаРасчета {get; set;}
    }
    [Description1C8(Name = "ФизическиеЛица", Comment = "", Synonym = "Физические лица")]
    [Table("NachyslenyeZarplaty_FyzycheskyeLytsa")]
    public class НачислениеЗарплаты_ФизическиеЛица
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
    }
    [Description1C8(Name = "РаспределениеРезультатовНачислений", Comment = "", Synonym = "Распределение результатов начислений")]
    [Table("NachyslenyeZarplaty_RaspredelenyeRezultatovNachyslenyi")]
    public class НачислениеЗарплаты_РаспределениеРезультатовНачислений
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ИдентификаторСтроки", Comment = "", Synonym = "Идентификатор строки")]
        // Format 7.0
        public long ИдентификаторСтроки {get; set;}
        [Description1C8(Name = "Территория", Comment = "", Synonym = "Территория")]
        public Catalogs.ТерриторииВыполненияРабот Территория {get; set;}
        [Description1C8(Name = "СтатьяФинансирования", Comment = "", Synonym = "Статья финансирования")]
        public Catalogs.СтатьиФинансированияЗарплата СтатьяФинансирования {get; set;}
        [Description1C8(Name = "СтатьяРасходов", Comment = "", Synonym = "Статья расходов")]
        public Catalogs.СтатьиРасходовЗарплата СтатьяРасходов {get; set;}
        [Description1C8(Name = "СпособОтраженияЗарплатыВБухучете", Comment = "", Synonym = "Способ отражения")]
        public Catalogs.СпособыОтраженияЗарплатыВБухУчете СпособОтраженияЗарплатыВБухучете {get; set;}
        [Description1C8(Name = "ОблагаетсяЕНВД", Comment = "", Synonym = "Облагается ЕНВД")]
        public bool ОблагаетсяЕНВД {get; set;}
        [Description1C8(Name = "Результат", Comment = "", Synonym = "Результат")]
        // Format 13.2
        public decimal Результат {get; set;}
    }
    [Description1C8(Name = "РаспределениеРезультатовУдержаний", Comment = "", Synonym = "Распределение результатов удержаний")]
    [Table("NachyslenyeZarplaty_RaspredelenyeRezultatovUderzhanyi")]
    public class НачислениеЗарплаты_РаспределениеРезультатовУдержаний
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ИдентификаторСтроки", Comment = "", Synonym = "Идентификатор строки")]
        // Format 7.0
        public long ИдентификаторСтроки {get; set;}
        [Description1C8(Name = "ВидУдержания", Comment = "", Synonym = "Вид удержания")]
        public Enums.ВидыОсобыхНачисленийИУдержаний ВидУдержания {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "СтатьяФинансирования", Comment = "", Synonym = "Статья финансирования")]
        public Catalogs.СтатьиФинансированияЗарплата СтатьяФинансирования {get; set;}
        [Description1C8(Name = "СтатьяРасходов", Comment = "", Synonym = "Статья расходов")]
        public Catalogs.СтатьиРасходовЗарплата СтатьяРасходов {get; set;}
        [Description1C8(Name = "Результат", Comment = "", Synonym = "Результат")]
        // Format 13.2
        public decimal Результат {get; set;}
    }
    [Description1C8(Name = "ПредставлениеРаспределенияРезультатовРасчета", Comment = "", Synonym = "Представление распределения результатов расчета")]
    [Table("NachyslenyeZarplaty_PredstavlenyeRaspredelenyiaRezultatovRascheta")]
    public class НачислениеЗарплаты_ПредставлениеРаспределенияРезультатовРасчета
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ИдентификаторСтроки", Comment = "", Synonym = "Идентификатор строки")]
        // Format 7.0
        public long ИдентификаторСтроки {get; set;}
        [Description1C8(Name = "НомерСтрокиРаспределения", Comment = "", Synonym = "Номер строки распределения")]
        // Format 10.0
        public long НомерСтрокиРаспределения {get; set;}
        [Description1C8(Name = "НомерЭлементаПредставления", Comment = "", Synonym = "Номер элемента представления")]
        // Format 10.0
        public long НомерЭлементаПредставления {get; set;}
        [Description1C8(Name = "КоличествоЭлементовПредставления", Comment = "", Synonym = "Количество элементов представления")]
        // Format 10.0
        public long КоличествоЭлементовПредставления {get; set;}
        [Description1C8(Name = "ПредставлениеРезультата", Comment = "", Synonym = "Представление результата")]
        [StringLength(50)]
        public string ПредставлениеРезультата {get; set;}
        [Description1C8(Name = "ЕстьОшибкиЗаполнения", Comment = "", Synonym = "Есть ошибки заполнения")]
        public bool ЕстьОшибкиЗаполнения {get; set;}
        [Description1C8(Name = "РаспределениеНачислений", Comment = "", Synonym = "Распределение начислений")]
        public bool РаспределениеНачислений {get; set;}
    }
    [Description1C8(Name = "Льготы", Comment = "", Synonym = "Льготы")]
    [Table("NachyslenyeZarplaty_Lhoty")]
    public class НачислениеЗарплаты_Льготы
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "ДатаНачала", Comment = "", Synonym = "Дата начала")]
        public DateTime ДатаНачала {get; set;}
        [Description1C8(Name = "ДатаОкончания", Comment = "", Synonym = "Дата окончания")]
        public DateTime ДатаОкончания {get; set;}
        [Description1C8(Name = "Начисление", Comment = "", Synonym = "Начисление")]
        public ПланВидовРасчета.Начисления Начисление {get; set;}
        [Description1C8(Name = "Результат", Comment = "", Synonym = "Результат")]
        // Format 13.2
        public decimal Результат {get; set;}
        [Description1C8(Name = "ОтработаноДней", Comment = "", Synonym = "дн.")]
        // Format 7.2
        public decimal ОтработаноДней {get; set;}
        [Description1C8(Name = "ОтработаноЧасов", Comment = "", Synonym = "чс.")]
        // Format 7.2
        public decimal ОтработаноЧасов {get; set;}
        [Description1C8(Name = "НормаДней", Comment = "", Synonym = "Норма дн.")]
        // Format 7.2
        public decimal НормаДней {get; set;}
        [Description1C8(Name = "НормаЧасов", Comment = "", Synonym = "Норма чс.")]
        // Format 7.2
        public decimal НормаЧасов {get; set;}
        [Description1C8(Name = "ФиксСтрока", Comment = "", Synonym = "Фикс строка")]
        public bool ФиксСтрока {get; set;}
        [Description1C8(Name = "ФиксЗаполнение", Comment = "", Synonym = "Фиксировано заполнение")]
        public bool ФиксЗаполнение {get; set;}
        [Description1C8(Name = "ФиксРасчетВремени", Comment = "", Synonym = "Фиксирован расчет времени")]
        public bool ФиксРасчетВремени {get; set;}
        [Description1C8(Name = "ФиксРасчет", Comment = "", Synonym = "Фиксирован расчет")]
        public bool ФиксРасчет {get; set;}
        [Description1C8(Name = "РасчетнаяБазаЗаЕдиницуНормыВремени", Comment = "Расчетная база на единицу нормы времени для расчета сторно-записей", Synonym = "Расчетная база за единицу нормы времени")]
        // Format 15.2
        public decimal РасчетнаяБазаЗаЕдиницуНормыВремени {get; set;}
        [Description1C8(Name = "КодВычета", Comment = "", Synonym = "Код вычета")]
        public Catalogs.ВидыЛьготПоНДФЛ КодВычета {get; set;}
        [Description1C8(Name = "СуммаВычета", Comment = "", Synonym = "Сумма вычета")]
        // Format 15.2
        public decimal СуммаВычета {get; set;}
        [Description1C8(Name = "ГрафикРаботы", Comment = "", Synonym = "График работы")]
        public Catalogs.ГрафикиРаботыСотрудников ГрафикРаботы {get; set;}
        [Description1C8(Name = "ВидУчетаВремени", Comment = "", Synonym = "Вид учета времени")]
        public Catalogs.ВидыИспользованияРабочегоВремени ВидУчетаВремени {get; set;}
        [Description1C8(Name = "ВремяВЧасах", Comment = "", Synonym = "Время в часах")]
        public bool ВремяВЧасах {get; set;}
        [Description1C8(Name = "ГрафикРаботыНорма", Comment = "", Synonym = "График работы норма")]
        public Catalogs.ГрафикиРаботыСотрудников ГрафикРаботыНорма {get; set;}
        [Description1C8(Name = "ИдентификаторСтрокиВидаРасчета", Comment = "", Synonym = "Идентификатор строки вида расчета")]
        // Format 7.0
        public long ИдентификаторСтрокиВидаРасчета {get; set;}
        [Description1C8(Name = "ПериодРегистрацииВремени", Comment = "", Synonym = "Период регистрации времени")]
        public DateTime ПериодРегистрацииВремени {get; set;}
        [Description1C8(Name = "ОплаченоДней", Comment = "", Synonym = "Оплачено дней")]
        // Format 7.2
        public decimal ОплаченоДней {get; set;}
        [Description1C8(Name = "ОплаченоЧасов", Comment = "", Synonym = "Оплачено часов")]
        // Format 7.2
        public decimal ОплаченоЧасов {get; set;}
        [Description1C8(Name = "ДокументОснование", Comment = "", Synonym = "Документ основание")]
        public Documents.НазначениеПлановогоНачисления ДокументОснование {get; set;}
        [Description1C8(Name = "ПериодДействия", Comment = "", Synonym = "Период действия")]
        public DateTime ПериодДействия {get; set;}
    }
    [Description1C8(Name = "РаспределениеПоТерриториямУсловиямТруда", Comment = "", Synonym = "Распределение по территориям и условиям труда")]
    [Table("NachyslenyeZarplaty_RaspredelenyePoTerrytoryiamUslovyiamTruda")]
    public class НачислениеЗарплаты_РаспределениеПоТерриториямУсловиямТруда
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ИдентификаторСтроки", Comment = "", Synonym = "Идентификатор строки")]
        // Format 7.0
        public long ИдентификаторСтроки {get; set;}
        [Description1C8(Name = "Территория", Comment = "", Synonym = "Территория")]
        public Catalogs.ТерриторииВыполненияРабот Территория {get; set;}
        [Description1C8(Name = "УсловияТруда", Comment = "", Synonym = "Условия труда")]
        public Catalogs.УсловияТруда УсловияТруда {get; set;}
        [Description1C8(Name = "ДоляРаспределения", Comment = "", Synonym = "Доля распределения")]
        // Format 15.4
        public decimal ДоляРаспределения {get; set;}
        [Description1C8(Name = "Результат", Comment = "", Synonym = "Результат")]
        // Format 15.2
        public decimal Результат {get; set;}
        [Description1C8(Name = "ИдентификаторСтрокиПоказателей", Comment = "", Synonym = "Идентификатор строки показателей")]
        // Format 7.0
        public long ИдентификаторСтрокиПоказателей {get; set;}
    }
    [Description1C8(Name = "ПособияПерерасчет", Comment = "", Synonym = "Перерасчет пособий")]
    [Table("NachyslenyeZarplaty_PosobyiaPereraschet")]
    public class НачислениеЗарплаты_ПособияПерерасчет
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "ВидЗанятости", Comment = "", Synonym = "Вид занятости")]
        public Enums.ВидыЗанятости ВидЗанятости {get; set;}
        [Description1C8(Name = "ДатаНачала", Comment = "", Synonym = "Дата начала")]
        public DateTime ДатаНачала {get; set;}
        [Description1C8(Name = "ДатаОкончания", Comment = "", Synonym = "Дата окончания")]
        public DateTime ДатаОкончания {get; set;}
        [Description1C8(Name = "Начисление", Comment = "", Synonym = "Начисление")]
        public ПланВидовРасчета.Начисления Начисление {get; set;}
        [Description1C8(Name = "Результат", Comment = "", Synonym = "Результат")]
        // Format 13.2
        public decimal Результат {get; set;}
        [Description1C8(Name = "РезультатВТомЧислеЗаСчетФБ", Comment = "", Synonym = "В том числе")]
        // Format 15.2
        public decimal РезультатВТомЧислеЗаСчетФБ {get; set;}
        [Description1C8(Name = "ФиксСтрока", Comment = "", Synonym = "Фикс строка")]
        public bool ФиксСтрока {get; set;}
        [Description1C8(Name = "ФиксЗаполнение", Comment = "", Synonym = "Фиксировано заполнение")]
        public bool ФиксЗаполнение {get; set;}
        [Description1C8(Name = "ФиксРасчетВремени", Comment = "", Synonym = "Фиксирован расчет времени")]
        public bool ФиксРасчетВремени {get; set;}
        [Description1C8(Name = "ФиксРасчет", Comment = "", Synonym = "Фиксирован расчет")]
        public bool ФиксРасчет {get; set;}
        [Description1C8(Name = "РасчетнаяБазаЗаЕдиницуНормыВремени", Comment = "Расчетная база на единицу нормы времени для расчета сторно-записей", Synonym = "Расчетная база за единицу нормы времени")]
        // Format 15.2
        public decimal РасчетнаяБазаЗаЕдиницуНормыВремени {get; set;}
        [Description1C8(Name = "ИдентификаторСтрокиВидаРасчета", Comment = "", Synonym = "Идентификатор строки вида расчета")]
        // Format 7.0
        public long ИдентификаторСтрокиВидаРасчета {get; set;}
        [Description1C8(Name = "ОплаченоДней", Comment = "", Synonym = "Оплачено дней")]
        // Format 7.2
        public decimal ОплаченоДней {get; set;}
        [Description1C8(Name = "ОплаченоЧасов", Comment = "", Synonym = "Оплачено часов")]
        // Format 7.2
        public decimal ОплаченоЧасов {get; set;}
        [Description1C8(Name = "СуммаВсегоПоУходуЗаПервымРебенком", Comment = "", Synonym = "Сумма пособия по уходу за первым ребенком, всего")]
        // Format 15.2
        public decimal СуммаВсегоПоУходуЗаПервымРебенком {get; set;}
        [Description1C8(Name = "СуммаСверхНормПоУходуЗаПервымРебенком", Comment = "", Synonym = "Сумма пособия по уходу за первым ребенком, сверх норм")]
        // Format 15.2
        public decimal СуммаСверхНормПоУходуЗаПервымРебенком {get; set;}
        [Description1C8(Name = "СуммаВсегоПоУходуЗаВторымРебенком", Comment = "", Synonym = "Сумма пособия по уходу за вторым ребенком, всего")]
        // Format 15.2
        public decimal СуммаВсегоПоУходуЗаВторымРебенком {get; set;}
        [Description1C8(Name = "СуммаСверхНормПоУходуЗаВторымРебенком", Comment = "", Synonym = "Сумма пособия по уходу за вторым ребенком, сверх норм")]
        // Format 15.2
        public decimal СуммаСверхНормПоУходуЗаВторымРебенком {get; set;}
        [Description1C8(Name = "ЛьготаПоПособию", Comment = "", Synonym = "Льгота по пособию")]
        public Enums.ОснованияЛьготПоПособию ЛьготаПоПособию {get; set;}
        [Description1C8(Name = "СтраховойСлучай", Comment = "", Synonym = "Страховой случай")]
        public Documents.ОтпускПоУходуЗаРебенком СтраховойСлучай {get; set;}
        [Description1C8(Name = "КоличествоДетей", Comment = "", Synonym = "Количество детей")]
        // Format 2.0
        public long КоличествоДетей {get; set;}
        [Description1C8(Name = "КоличествоПервыхДетей", Comment = "", Synonym = "Количество первых детей")]
        // Format 1.0
        public long КоличествоПервыхДетей {get; set;}
        [Description1C8(Name = "ФиксСторно", Comment = "", Synonym = "Не рассчитываемая сторно-запись")]
        public bool ФиксСторно {get; set;}
        [Description1C8(Name = "Сторно", Comment = "", Synonym = "Сторно")]
        public bool Сторно {get; set;}
        [Description1C8(Name = "СторнируемыйДокумент", Comment = "Документ, который зарегистрировал сторнируемое начисление", Synonym = "Сторнируемый документ")]
        public Documents.СторнированиеНачислений СторнируемыйДокумент {get; set;}
        [Description1C8(Name = "ПериодДействия", Comment = "", Synonym = "Период действия")]
        public DateTime ПериодДействия {get; set;}
    }
    [Description1C8(Name = "ВзносыФОТ", Comment = "", Synonym = "Взносы ФОТ")]
    [Table("NachyslenyeZarplaty_VznosyFOT")]
    public class НачислениеЗарплаты_ВзносыФОТ
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "ДатаПолученияДохода", Comment = "", Synonym = "Дата получения дохода")]
        public DateTime ДатаПолученияДохода {get; set;}
        [Description1C8(Name = "ВидЕСВ", Comment = "", Synonym = "Вид ЕСВ")]
        public Enums.ВидыЕСВ ВидЕСВ {get; set;}
        [Description1C8(Name = "КатегорияЕСВ", Comment = "", Synonym = "Категория ЕСВ")]
        public Catalogs.КатегорииЗастрахованныхЛицЕСВ КатегорияЕСВ {get; set;}
        [Description1C8(Name = "ДатаНачала", Comment = "Период параметров налога начало", Synonym = "Дата начала")]
        public DateTime ДатаНачала {get; set;}
        [Description1C8(Name = "ДатаОкончания", Comment = "Период параметров налога окончания", Synonym = "Дата окончания")]
        public DateTime ДатаОкончания {get; set;}
        [Description1C8(Name = "Налог", Comment = "", Synonym = "Налог")]
        public Catalogs.Налоги Налог {get; set;}
        [Description1C8(Name = "СтатьяНалоговойДекларации", Comment = "", Synonym = "Статья налоговой декларации")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяНалоговойДекларации {get; set;}
        [Description1C8(Name = "База", Comment = "", Synonym = "База")]
        // Format 16.2
        public decimal База {get; set;}
        [Description1C8(Name = "БазаОтпускные", Comment = "", Synonym = "База (отпускные)")]
        // Format 16.2
        public decimal БазаОтпускные {get; set;}
        [Description1C8(Name = "БазаВзноса", Comment = "База налога с учетом ограничений", Synonym = "База взноса")]
        // Format 16.2
        public decimal БазаВзноса {get; set;}
        [Description1C8(Name = "БазаДоначисление", Comment = "", Synonym = "База (доначисление)")]
        // Format 16.2
        public decimal БазаДоначисление {get; set;}
        [Description1C8(Name = "Результат", Comment = "", Synonym = "Результат")]
        // Format 16.6
        public decimal Результат {get; set;}
        [Description1C8(Name = "РезультатДоначисление", Comment = "", Synonym = "Результат (доначисление)")]
        // Format 16.2
        public decimal РезультатДоначисление {get; set;}
        [Description1C8(Name = "Предел", Comment = "", Synonym = "Предел")]
        // Format 15.3
        public decimal Предел {get; set;}
        [Description1C8(Name = "Ставка", Comment = "", Synonym = "Ставка")]
        // Format 10.4
        public decimal Ставка {get; set;}
        [Description1C8(Name = "МинимальнаяБаза", Comment = "", Synonym = "Минимальная база")]
        // Format 15.3
        public decimal МинимальнаяБаза {get; set;}
        [Description1C8(Name = "БазаВычет", Comment = "База (вычет)", Synonym = "База (вычет)")]
        // Format 16.2
        public decimal БазаВычет {get; set;}
        [Description1C8(Name = "КоэффициентСтавки", Comment = "", Synonym = "Коэффициент ставки")]
        // Format 10.4
        public decimal КоэффициентСтавки {get; set;}
        [Description1C8(Name = "ТипНачисления", Comment = "", Synonym = "Тип начисления")]
        // Format 2.0
        public long ТипНачисления {get; set;}
        [Description1C8(Name = "СтавкаПолная", Comment = "", Synonym = "Ставка полная")]
        // Format 10.4
        public decimal СтавкаПолная {get; set;}
        [Description1C8(Name = "РезультатПолная", Comment = "", Synonym = "Результат по полн. ставке")]
        // Format 16.2
        public decimal РезультатПолная {get; set;}
    }
}
