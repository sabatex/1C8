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
    [Table("OtpuskPoUkhoduZaRebenkom")]
    [Description1C8(Name = "ОтпускПоУходуЗаРебенком", Comment = "", Synonym = "Отпуск по уходу за ребенком")]
    public class ОтпускПоУходуЗаРебенком:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.ФизическиеЛица Сотрудник {get; set;}
        [Description1C8(Name = "ОсновнойСотрудник", Comment = "", Synonym = "Основной сотрудник")]
        public Catalogs.Сотрудники ОсновнойСотрудник {get; set;}
        [Description1C8(Name = "ДатаНачала", Comment = "", Synonym = "Дата начала")]
        public DateTime ДатаНачала {get; set;}
        [Description1C8(Name = "ДатаОкончания", Comment = "", Synonym = "Дата окончания")]
        public DateTime ДатаОкончания {get; set;}
        [Description1C8(Name = "ДатаОкончанияПособияДоТрехЛет", Comment = "", Synonym = "Дата окончания пособия до трех лет")]
        public DateTime ДатаОкончанияПособияДоТрехЛет {get; set;}
        [Description1C8(Name = "ВыплачиватьПособиеДоТрехЛет", Comment = "", Synonym = "Выплачивать пособие до трех лет")]
        public bool ВыплачиватьПособиеДоТрехЛет {get; set;}
        [Description1C8(Name = "ПособиеДоТрехЛет", Comment = "", Synonym = "Пособие до трех лет")]
        public ПланВидовРасчета.Начисления ПособиеДоТрехЛет {get; set;}
        [Description1C8(Name = "ИзменитьНачисления", Comment = "", Synonym = "Изменить начисления")]
        public bool ИзменитьНачисления {get; set;}
        [Description1C8(Name = "НеНачислятьЗарплатуИНеВыплачиватьАвансВоВремяОтпуска", Comment = "", Synonym = "Не начислять зарплату и не выплачивать аванс во время отпуска")]
        public bool НеНачислятьЗарплатуИНеВыплачиватьАвансВоВремяОтпуска {get; set;}
        [Description1C8(Name = "НачисленияУтверждены", Comment = "", Synonym = "Начисления утверждены")]
        public bool НачисленияУтверждены {get; set;}
        [Description1C8(Name = "ПериодРегистрации", Comment = "", Synonym = "Период регистрации")]
        public DateTime ПериодРегистрации {get; set;}
        [Description1C8(Name = "РассчитатьЗарплату", Comment = "", Synonym = "Рассчитать зарплату")]
        public bool РассчитатьЗарплату {get; set;}
        [Description1C8(Name = "ОсвобождатьСтавку", Comment = "", Synonym = "Освободить ставку на период отсутствия")]
        public bool ОсвобождатьСтавку {get; set;}
        [Description1C8(Name = "ПорядокВыплаты", Comment = "", Synonym = "Порядок выплаты")]
        public Enums.ХарактерВыплатыЗарплаты ПорядокВыплаты {get; set;}
        [Description1C8(Name = "ПланируемаяДатаВыплаты", Comment = "", Synonym = "Планируемая дата выплаты")]
        public DateTime ПланируемаяДатаВыплаты {get; set;}
        [Description1C8(Name = "Начислено", Comment = "", Synonym = "Начислено")]
        // Format 13.2
        public decimal Начислено {get; set;}
        [Description1C8(Name = "Удержано", Comment = "", Synonym = "Удержано")]
        // Format 13.2
        public decimal Удержано {get; set;}
        [Description1C8(Name = "ИсправленныйДокумент", Comment = "", Synonym = "Исправленный документ")]
        public Documents.ОтпускПоУходуЗаРебенком ИсправленныйДокумент {get; set;}
        [Description1C8(Name = "Руководитель", Comment = "", Synonym = "Руководитель")]
        public Catalogs.ФизическиеЛица Руководитель {get; set;}
        [Description1C8(Name = "ДолжностьРуководителя", Comment = "", Synonym = "Должность")]
        public Catalogs.Должности ДолжностьРуководителя {get; set;}
        [Description1C8(Name = "ИзменитьЛьготы", Comment = "", Synonym = "Изменить льготы")]
        public bool ИзменитьЛьготы {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "ВидОтпуска", Comment = "", Synonym = "Вид отпуска")]
        public Enums.КатегорииНачисленийИНеоплаченногоВремени ВидОтпуска {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Начисления", Comment = "", Synonym = "Начисления")]
        public List<ОтпускПоУходуЗаРебенком_Начисления> ОтпускПоУходуЗаРебенкомНачисления {get;set;}
        [Description1C8(Name = "Показатели", Comment = "", Synonym = "Показатели")]
        public List<ОтпускПоУходуЗаРебенком_Показатели> ОтпускПоУходуЗаРебенкомПоказатели {get;set;}
        [Description1C8(Name = "ПересчетТарифныхСтавок", Comment = "", Synonym = "Пересчет тарифных ставок")]
        public List<ОтпускПоУходуЗаРебенком_ПересчетТарифныхСтавок> ОтпускПоУходуЗаРебенкомПересчетТарифныхСтавок {get;set;}
        [Description1C8(Name = "ОплатаТруда", Comment = "", Synonym = "Оплата труда")]
        public List<ОтпускПоУходуЗаРебенком_ОплатаТруда> ОтпускПоУходуЗаРебенкомОплатаТруда {get;set;}
        [Description1C8(Name = "НДФЛ", Comment = "", Synonym = "НДФЛ")]
        public List<ОтпускПоУходуЗаРебенком_НДФЛ> ОтпускПоУходуЗаРебенкомНДФЛ {get;set;}
        [Description1C8(Name = "ПогашениеЗаймов", Comment = "", Synonym = "Погашение займов")]
        public List<ОтпускПоУходуЗаРебенком_ПогашениеЗаймов> ОтпускПоУходуЗаРебенкомПогашениеЗаймов {get;set;}
        [Description1C8(Name = "Удержания", Comment = "", Synonym = "Удержания")]
        public List<ОтпускПоУходуЗаРебенком_Удержания> ОтпускПоУходуЗаРебенкомУдержания {get;set;}
        [Description1C8(Name = "РаспределениеРезультатовНачислений", Comment = "", Synonym = "Распределение результатов начислений")]
        public List<ОтпускПоУходуЗаРебенком_РаспределениеРезультатовНачислений> ОтпускПоУходуЗаРебенкомРаспределениеРезультатовНачислений {get;set;}
        [Description1C8(Name = "РаспределениеРезультатовУдержаний", Comment = "", Synonym = "Распределение результатов удержаний")]
        public List<ОтпускПоУходуЗаРебенком_РаспределениеРезультатовУдержаний> ОтпускПоУходуЗаРебенкомРаспределениеРезультатовУдержаний {get;set;}
        [Description1C8(Name = "Льготы", Comment = "", Synonym = "Льготы")]
        public List<ОтпускПоУходуЗаРебенком_Льготы> ОтпускПоУходуЗаРебенкомЛьготы {get;set;}
        [Description1C8(Name = "ОплатаЛьгот", Comment = "", Synonym = "Оплата льгот")]
        public List<ОтпускПоУходуЗаРебенком_ОплатаЛьгот> ОтпускПоУходуЗаРебенкомОплатаЛьгот {get;set;}
        [Description1C8(Name = "ПериодыБолезниУходаЗаДетьми", Comment = "", Synonym = "Периоды болезни, ухода за детьми и пр.")]
        public List<ОтпускПоУходуЗаРебенком_ПериодыБолезниУходаЗаДетьми> ОтпускПоУходуЗаРебенкомПериодыБолезниУходаЗаДетьми {get;set;}
        [Description1C8(Name = "РаспределениеПоТерриториямУсловиямТруда", Comment = "", Synonym = "Распределение по территориям и условиям труда")]
        public List<ОтпускПоУходуЗаРебенком_РаспределениеПоТерриториямУсловиямТруда> ОтпускПоУходуЗаРебенкомРаспределениеПоТерриториямУсловиямТруда {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Начисления", Comment = "", Synonym = "Начисления")]
    [Table("OtpuskPoUkhoduZaRebenkom_Nachyslenyia")]
    public class ОтпускПоУходуЗаРебенком_Начисления
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Действие", Comment = "", Synonym = "Действие")]
        public Enums.ДействияСНачислениямиИУдержаниями Действие {get; set;}
        [Description1C8(Name = "Начисление", Comment = "", Synonym = "Начисление")]
        public ПланВидовРасчета.Начисления Начисление {get; set;}
        [Description1C8(Name = "РабочееМесто", Comment = "", Synonym = "Рабочее место")]
        public Catalogs.Сотрудники РабочееМесто {get; set;}
        [Description1C8(Name = "ИдентификаторСтрокиВидаРасчета", Comment = "", Synonym = "Идентификатор строки вида расчета")]
        // Format 7.0
        public long ИдентификаторСтрокиВидаРасчета {get; set;}
        [Description1C8(Name = "ДокументОснование", Comment = "", Synonym = "Документ основание")]
        public Documents.НазначениеПлановогоНачисления ДокументОснование {get; set;}
        [Description1C8(Name = "Размер", Comment = "", Synonym = "Вклад в ФОТ")]
        // Format 15.2
        public decimal Размер {get; set;}
    }
    [Description1C8(Name = "Показатели", Comment = "", Synonym = "Показатели")]
    [Table("OtpuskPoUkhoduZaRebenkom_Pokazately")]
    public class ОтпускПоУходуЗаРебенком_Показатели
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ИдентификаторСтрокиВидаРасчета", Comment = "", Synonym = "Идентификатор строки вида расчета")]
        // Format 7.0
        public long ИдентификаторСтрокиВидаРасчета {get; set;}
        [Description1C8(Name = "Показатель", Comment = "", Synonym = "Показатель")]
        public Catalogs.ПоказателиРасчетаЗарплаты Показатель {get; set;}
        [Description1C8(Name = "Значение", Comment = "", Synonym = "Значение")]
        // Format 15.4
        public decimal Значение {get; set;}
        [Description1C8(Name = "Действие", Comment = "", Synonym = "Действие")]
        public Enums.ДействияСНачислениямиИУдержаниями Действие {get; set;}
        [Description1C8(Name = "РабочееМесто", Comment = "", Synonym = "Рабочее место")]
        public Catalogs.Сотрудники РабочееМесто {get; set;}
    }
    [Description1C8(Name = "ПересчетТарифныхСтавок", Comment = "", Synonym = "Пересчет тарифных ставок")]
    [Table("OtpuskPoUkhoduZaRebenkom_PereschetTaryfnykhStavok")]
    public class ОтпускПоУходуЗаРебенком_ПересчетТарифныхСтавок
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "РабочееМесто", Comment = "", Synonym = "Рабочее место")]
        public Catalogs.Сотрудники РабочееМесто {get; set;}
        [Description1C8(Name = "ПорядокРасчетаСтоимостиЕдиницыВремени", Comment = "", Synonym = "Порядок расчета стоимости единицы времени")]
        public Enums.ПорядокРасчетаСтоимостиЕдиницыВремениОплатыТруда ПорядокРасчетаСтоимостиЕдиницыВремени {get; set;}
        [Description1C8(Name = "СовокупнаяТарифнаяСтавка", Comment = "", Synonym = "Совокупная тарифная ставка")]
        // Format 15.2
        public decimal СовокупнаяТарифнаяСтавка {get; set;}
        [Description1C8(Name = "ВидТарифнойСтавки", Comment = "", Synonym = "Вид тарифной ставки")]
        public Enums.ВидыТарифныхСтавок ВидТарифнойСтавки {get; set;}
    }
    [Description1C8(Name = "ОплатаТруда", Comment = "", Synonym = "Оплата труда")]
    [Table("OtpuskPoUkhoduZaRebenkom_OplataTruda")]
    public class ОтпускПоУходуЗаРебенком_ОплатаТруда
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Начисление", Comment = "", Synonym = "Начисление")]
        public ПланВидовРасчета.Начисления Начисление {get; set;}
        [Description1C8(Name = "ДатаНачала", Comment = "", Synonym = "Дата начала")]
        public DateTime ДатаНачала {get; set;}
        [Description1C8(Name = "ДатаОкончания", Comment = "", Synonym = "Дата окончания")]
        public DateTime ДатаОкончания {get; set;}
        [Description1C8(Name = "Результат", Comment = "", Synonym = "Результат")]
        // Format 13.2
        public decimal Результат {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "НормаДней", Comment = "", Synonym = "Норма дней")]
        // Format 7.2
        public decimal НормаДней {get; set;}
        [Description1C8(Name = "НормаЧасов", Comment = "", Synonym = "Норма часов")]
        // Format 7.2
        public decimal НормаЧасов {get; set;}
        [Description1C8(Name = "ОтработаноДней", Comment = "", Synonym = "Отработано дней")]
        // Format 7.2
        public decimal ОтработаноДней {get; set;}
        [Description1C8(Name = "ОтработаноЧасов", Comment = "", Synonym = "Отработано часов")]
        // Format 7.2
        public decimal ОтработаноЧасов {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "РасчетнаяБазаЗаЕдиницуНормыВремени", Comment = "Расчетная база на единицу нормы времени для расчета сторно-записей", Synonym = "Расчетная база за единицу нормы времени")]
        // Format 15.2
        public decimal РасчетнаяБазаЗаЕдиницуНормыВремени {get; set;}
        [Description1C8(Name = "ИдентификаторСтрокиВидаРасчета", Comment = "", Synonym = "Идентификатор строки вида расчета")]
        // Format 7.0
        public long ИдентификаторСтрокиВидаРасчета {get; set;}
        [Description1C8(Name = "ГрафикРаботы", Comment = "", Synonym = "График работы")]
        public Catalogs.ГрафикиРаботыСотрудников ГрафикРаботы {get; set;}
        [Description1C8(Name = "ВидУчетаВремени", Comment = "", Synonym = "Вид учета времени")]
        public Catalogs.ВидыИспользованияРабочегоВремени ВидУчетаВремени {get; set;}
        [Description1C8(Name = "ФиксСтрока", Comment = "", Synonym = "Фикс строка")]
        public bool ФиксСтрока {get; set;}
        [Description1C8(Name = "ФиксЗаполнение", Comment = "", Synonym = "Фиксировано заполнение")]
        public bool ФиксЗаполнение {get; set;}
        [Description1C8(Name = "ФиксРасчетВремени", Comment = "", Synonym = "Фиксирован расчет времени")]
        public bool ФиксРасчетВремени {get; set;}
        [Description1C8(Name = "ФиксРасчет", Comment = "", Synonym = "Фиксирован расчет")]
        public bool ФиксРасчет {get; set;}
        [Description1C8(Name = "ВремяВЧасах", Comment = "", Synonym = "Время в часах")]
        public bool ВремяВЧасах {get; set;}
        [Description1C8(Name = "ГрафикРаботыНорма", Comment = "", Synonym = "График работы норма")]
        public Catalogs.ГрафикиРаботыСотрудников ГрафикРаботыНорма {get; set;}
        [Description1C8(Name = "ПериодРегистрацииВремени", Comment = "", Synonym = "Период регистрации времени")]
        public DateTime ПериодРегистрацииВремени {get; set;}
        [Description1C8(Name = "СуммаВычета", Comment = "", Synonym = "Сумма вычета")]
        // Format 15.2
        public decimal СуммаВычета {get; set;}
        [Description1C8(Name = "КодВычета", Comment = "", Synonym = "Код вычета")]
        public Catalogs.ВидыЛьготПоНДФЛ КодВычета {get; set;}
        [Description1C8(Name = "ОплаченоДней", Comment = "", Synonym = "Оплачено дней")]
        // Format 15.2
        public decimal ОплаченоДней {get; set;}
        [Description1C8(Name = "ОплаченоЧасов", Comment = "", Synonym = "Оплачено часов")]
        // Format 15.2
        public decimal ОплаченоЧасов {get; set;}
        [Description1C8(Name = "ДокументОснование", Comment = "", Synonym = "Документ основание")]
        public Documents.НазначениеПлановогоНачисления ДокументОснование {get; set;}
        [Description1C8(Name = "ПериодДействия", Comment = "", Synonym = "Период действия")]
        public DateTime ПериодДействия {get; set;}
    }
    [Description1C8(Name = "НДФЛ", Comment = "", Synonym = "НДФЛ")]
    [Table("OtpuskPoUkhoduZaRebenkom_NDFL")]
    public class ОтпускПоУходуЗаРебенком_НДФЛ
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "МесяцНалоговогоПериода", Comment = "", Synonym = "Дата получения дохода")]
        public DateTime МесяцНалоговогоПериода {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ТерриторииВыполненияРабот Подразделение {get; set;}
        [Description1C8(Name = "Налог", Comment = "", Synonym = "Налог")]
        // Format 10.0
        public long Налог {get; set;}
        [Description1C8(Name = "ЗачтеноАвансовыхПлатежей", Comment = "", Synonym = "Зачтено авансов")]
        // Format 10.0
        public long ЗачтеноАвансовыхПлатежей {get; set;}
        [Description1C8(Name = "НалогКЗачетуВозврату", Comment = "", Synonym = "Налог к зачету возврату")]
        // Format 10.0
        public long НалогКЗачетуВозврату {get; set;}
        [Description1C8(Name = "ПримененныйВычетЛичный", Comment = "", Synonym = "Примененный вычет личный")]
        // Format 12.2
        public decimal ПримененныйВычетЛичный {get; set;}
        [Description1C8(Name = "ПримененныйВычетЛичныйКодВычета", Comment = "", Synonym = "Примененный вычет личный код вычета")]
        public Catalogs.ВидыЛьготПоНДФЛ ПримененныйВычетЛичныйКодВычета {get; set;}
        [Description1C8(Name = "ПримененныйВычетЛичныйКЗачетуВозврату", Comment = "", Synonym = "Размер")]
        // Format 12.2
        public decimal ПримененныйВычетЛичныйКЗачетуВозврату {get; set;}
        [Description1C8(Name = "ПримененныйВычетЛичныйКЗачетуВозвратуКодВычета", Comment = "", Synonym = "Код")]
        public Catalogs.ВидыЛьготПоНДФЛ ПримененныйВычетЛичныйКЗачетуВозвратуКодВычета {get; set;}
        [Description1C8(Name = "ИдентификаторСтрокиНДФЛ", Comment = "", Synonym = "Идентификатор строки НДФЛ")]
        // Format 7.0
        public long ИдентификаторСтрокиНДФЛ {get; set;}
        [Description1C8(Name = "ФиксСтрока", Comment = "", Synonym = "Фикс строка")]
        public bool ФиксСтрока {get; set;}
        [Description1C8(Name = "ФиксРасчет", Comment = "", Synonym = "Фиксирован расчет")]
        public bool ФиксРасчет {get; set;}
    }
    [Description1C8(Name = "ПогашениеЗаймов", Comment = "", Synonym = "Погашение займов")]
    [Table("OtpuskPoUkhoduZaRebenkom_PohashenyeZaimov")]
    public class ОтпускПоУходуЗаРебенком_ПогашениеЗаймов
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
    [Description1C8(Name = "Удержания", Comment = "", Synonym = "Удержания")]
    [Table("OtpuskPoUkhoduZaRebenkom_Uderzhanyia")]
    public class ОтпускПоУходуЗаРебенком_Удержания
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
        [Description1C8(Name = "ФиксРасчет", Comment = "", Synonym = "Фиксирован расчет")]
        public bool ФиксРасчет {get; set;}
        [Description1C8(Name = "Результат", Comment = "", Synonym = "Результат")]
        // Format 13.2
        public decimal Результат {get; set;}
        [Description1C8(Name = "ИдентификаторСтрокиВидаРасчета", Comment = "", Synonym = "Идентификатор строки вида расчета")]
        // Format 7.0
        public long ИдентификаторСтрокиВидаРасчета {get; set;}
        [Description1C8(Name = "ФиксЗаполнение", Comment = "", Synonym = "Фиксировано заполнение")]
        public bool ФиксЗаполнение {get; set;}
        [Description1C8(Name = "ФиксСтрока", Comment = "", Synonym = "Фикс строка")]
        public bool ФиксСтрока {get; set;}
    }
    [Description1C8(Name = "РаспределениеРезультатовНачислений", Comment = "", Synonym = "Распределение результатов начислений")]
    [Table("OtpuskPoUkhoduZaRebenkom_RaspredelenyeRezultatovNachyslenyi")]
    public class ОтпускПоУходуЗаРебенком_РаспределениеРезультатовНачислений
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
    [Table("OtpuskPoUkhoduZaRebenkom_RaspredelenyeRezultatovUderzhanyi")]
    public class ОтпускПоУходуЗаРебенком_РаспределениеРезультатовУдержаний
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
    [Description1C8(Name = "Льготы", Comment = "", Synonym = "Льготы")]
    [Table("OtpuskPoUkhoduZaRebenkom_Lhoty")]
    public class ОтпускПоУходуЗаРебенком_Льготы
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Действие", Comment = "", Synonym = "Действие")]
        public Enums.ДействияСНачислениямиИУдержаниями Действие {get; set;}
        [Description1C8(Name = "Льгота", Comment = "", Synonym = "Льгота")]
        public ПланВидовРасчета.Начисления Льгота {get; set;}
        [Description1C8(Name = "РабочееМесто", Comment = "", Synonym = "Рабочее место")]
        public Catalogs.Сотрудники РабочееМесто {get; set;}
        [Description1C8(Name = "ИдентификаторСтрокиВидаРасчета", Comment = "", Synonym = "Идентификатор строки вида расчета")]
        // Format 7.0
        public long ИдентификаторСтрокиВидаРасчета {get; set;}
        [Description1C8(Name = "ДокументОснование", Comment = "", Synonym = "Документ основание")]
        public Documents.НазначениеПлановогоНачисления ДокументОснование {get; set;}
        [Description1C8(Name = "Размер", Comment = "", Synonym = "Размер")]
        // Format 15.2
        public decimal Размер {get; set;}
    }
    [Description1C8(Name = "ОплатаЛьгот", Comment = "", Synonym = "Оплата льгот")]
    [Table("OtpuskPoUkhoduZaRebenkom_OplataLhot")]
    public class ОтпускПоУходуЗаРебенком_ОплатаЛьгот
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
    [Description1C8(Name = "ПериодыБолезниУходаЗаДетьми", Comment = "", Synonym = "Периоды болезни, ухода за детьми и пр.")]
    [Table("OtpuskPoUkhoduZaRebenkom_PeryodyBoleznyUkhodaZaDetmy")]
    public class ОтпускПоУходуЗаРебенком_ПериодыБолезниУходаЗаДетьми
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Начало", Comment = "", Synonym = "Начало")]
        public DateTime Начало {get; set;}
        [Description1C8(Name = "Окончание", Comment = "", Synonym = "Окончание")]
        public DateTime Окончание {get; set;}
        [Description1C8(Name = "Дни", Comment = "", Synonym = "Дни")]
        // Format 10.0
        public long Дни {get; set;}
        [Description1C8(Name = "ВидБолезниУходаЗаДетьми", Comment = "", Synonym = "Вид болезни, ухода за детьми и пр.")]
        [StringLength(100)]
        public string ВидБолезниУходаЗаДетьми {get; set;}
        [Description1C8(Name = "Источник", Comment = "", Synonym = "Источник")]
        public Enums.ИсточникиДанныхДляРасчетаСреднегоЗаработка Источник {get; set;}
        [Description1C8(Name = "УдалитьКорректировка", Comment = "", Synonym = "(Не используется) Корректировка")]
        public bool УдалитьКорректировка {get; set;}
    }
    [Description1C8(Name = "РаспределениеПоТерриториямУсловиямТруда", Comment = "", Synonym = "Распределение по территориям и условиям труда")]
    [Table("OtpuskPoUkhoduZaRebenkom_RaspredelenyePoTerrytoryiamUslovyiamTruda")]
    public class ОтпускПоУходуЗаРебенком_РаспределениеПоТерриториямУсловиямТруда
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
}
