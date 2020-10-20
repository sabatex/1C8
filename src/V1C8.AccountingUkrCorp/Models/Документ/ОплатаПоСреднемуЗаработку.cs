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
    [Table("OplataPoSrednemuZarabotku")]
    [Description1C8(Name = "ОплатаПоСреднемуЗаработку", Comment = "", Synonym = "Отсутствие с сохранением оплаты")]
    public class ОплатаПоСреднемуЗаработку:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "ПериодРегистрации", Comment = "", Synonym = "Период регистрации")]
        public DateTime ПериодРегистрации {get; set;}
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "ВидВремени", Comment = "", Synonym = "Вид времени")]
        public Catalogs.ВидыИспользованияРабочегоВремени ВидВремени {get; set;}
        [Description1C8(Name = "ВнутрисменноеОтсутствие", Comment = "", Synonym = "Отсутствие на неполный день (внутрисменное)")]
        public bool ВнутрисменноеОтсутствие {get; set;}
        [Description1C8(Name = "ВидРасчета", Comment = "", Synonym = "Вид расчета")]
        public ПланВидовРасчета.Начисления ВидРасчета {get; set;}
        [Description1C8(Name = "ПроцентОплаты", Comment = "Процент оплаты", Synonym = "Процент оплаты")]
        // Format 6.2
        public decimal ПроцентОплаты {get; set;}
        [Description1C8(Name = "ДатаНачала", Comment = "", Synonym = "Дата начала")]
        public DateTime ДатаНачала {get; set;}
        [Description1C8(Name = "ДатаОкончания", Comment = "", Synonym = "Дата окончания")]
        public DateTime ДатаОкончания {get; set;}
        [Description1C8(Name = "ДатаОтсутствия", Comment = "", Synonym = "Дата отсутствия")]
        public DateTime ДатаОтсутствия {get; set;}
        [Description1C8(Name = "ОплачиватьЧасов", Comment = "", Synonym = "Оплачивать часов")]
        // Format 7.2
        public decimal ОплачиватьЧасов {get; set;}
        [Description1C8(Name = "ДатаНачалаСобытия", Comment = "Дата начала события, оплачиваемого по среднему заработку", Synonym = "Дата начала периода сохранения среднего заработка")]
        public DateTime ДатаНачалаСобытия {get; set;}
        [Description1C8(Name = "ВидВремениЗамещаемый", Comment = "", Synonym = "Вид времени замещаемый")]
        public Catalogs.ВидыИспользованияРабочегоВремени ВидВремениЗамещаемый {get; set;}
        [Description1C8(Name = "ПериодРасчетаСреднегоЗаработкаНачало", Comment = "Дата начала расчетного периода", Synonym = "Период расчета среднего заработка начало")]
        public DateTime ПериодРасчетаСреднегоЗаработкаНачало {get; set;}
        [Description1C8(Name = "ПериодРасчетаСреднегоЗаработкаОкончание", Comment = "Дата окончания расчетного периода", Synonym = "Период расчета среднего заработка окончание")]
        public DateTime ПериодРасчетаСреднегоЗаработкаОкончание {get; set;}
        [Description1C8(Name = "ФиксПериодРасчетаСреднегоЗаработка", Comment = "", Synonym = "Фикс период расчета среднего заработка")]
        public bool ФиксПериодРасчетаСреднегоЗаработка {get; set;}
        [Description1C8(Name = "СреднийЗаработок", Comment = "", Synonym = "Средний заработок")]
        // Format 15.2
        public decimal СреднийЗаработок {get; set;}
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
        [Description1C8(Name = "ИсправленныйДокумент", Comment = "", Synonym = "Исправленный документ")]
        public Документ.ОплатаПоСреднемуЗаработку ИсправленныйДокумент {get; set;}
        [Description1C8(Name = "ДокументРассчитан", Comment = "", Synonym = "Документ рассчитан")]
        public bool ДокументРассчитан {get; set;}
        [Description1C8(Name = "Рассчитал", Comment = "", Synonym = "Рассчитал")]
        public Catalogs.Пользователи Рассчитал {get; set;}
        [Description1C8(Name = "ПредставлениеПериода", Comment = "", Synonym = "Представление периода")]
        [StringLength(19)]
        public string ПредставлениеПериода {get; set;}
        [Description1C8(Name = "Руководитель", Comment = "", Synonym = "Руководитель")]
        public Catalogs.ФизическиеЛица Руководитель {get; set;}
        [Description1C8(Name = "ДолжностьРуководителя", Comment = "", Synonym = "Должность")]
        public Catalogs.Должности ДолжностьРуководителя {get; set;}
        [Description1C8(Name = "ГлавныйБухгалтер", Comment = "", Synonym = "Главный бухгалтер")]
        public Catalogs.ФизическиеЛица ГлавныйБухгалтер {get; set;}
        [Description1C8(Name = "Бухгалтер", Comment = "", Synonym = "Бухгалтер")]
        public Catalogs.ФизическиеЛица Бухгалтер {get; set;}
        [Description1C8(Name = "Исполнитель", Comment = "", Synonym = "Исполнитель")]
        public Catalogs.ФизическиеЛица Исполнитель {get; set;}
        [Description1C8(Name = "ДолжностьИсполнителя", Comment = "", Synonym = "Должность")]
        public Catalogs.Должности ДолжностьИсполнителя {get; set;}
        [Description1C8(Name = "РасчетДенежногоСодержания", Comment = "", Synonym = "Расчет денежного содержания")]
        public bool РасчетДенежногоСодержания {get; set;}
        [Description1C8(Name = "СохраняемоеДенежноеСодержание", Comment = "", Synonym = "Сохраняемое денежное содержание")]
        // Format 13.2
        public decimal СохраняемоеДенежноеСодержание {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "ВидУчетаВремениДляСредней", Comment = "", Synonym = "Вид учета времени для средней")]
        public Enums.ВидыУчетаВремениДляСредней ВидУчетаВремениДляСредней {get; set;}
        [Description1C8(Name = "РучнаяКорректировкаСреднегоЗаработка", Comment = "", Synonym = "Ручная корректировка среднего заработка")]
        public bool РучнаяКорректировкаСреднегоЗаработка {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ДанныеОбИндексации", Comment = "", Synonym = "Данные об индексации")]
        public List<ОплатаПоСреднемуЗаработку_ДанныеОбИндексации> ОплатаПоСреднемуЗаработкуДанныеОбИндексации {get;set;}
        [Description1C8(Name = "Начисления", Comment = "", Synonym = "Начисления")]
        public List<ОплатаПоСреднемуЗаработку_Начисления> ОплатаПоСреднемуЗаработкуНачисления {get;set;}
        [Description1C8(Name = "НачисленияПерерасчет", Comment = "", Synonym = "Начисления перерасчет")]
        public List<ОплатаПоСреднемуЗаработку_НачисленияПерерасчет> ОплатаПоСреднемуЗаработкуНачисленияПерерасчет {get;set;}
        [Description1C8(Name = "НДФЛ", Comment = "", Synonym = "НДФЛ")]
        public List<ОплатаПоСреднемуЗаработку_НДФЛ> ОплатаПоСреднемуЗаработкуНДФЛ {get;set;}
        [Description1C8(Name = "ОтработанноеВремяДляСреднегоОбщий", Comment = "", Synonym = "Отработанное время для среднего общий")]
        public List<ОплатаПоСреднемуЗаработку_ОтработанноеВремяДляСреднегоОбщий> ОплатаПоСреднемуЗаработкуОтработанноеВремяДляСреднегоОбщий {get;set;}
        [Description1C8(Name = "Показатели", Comment = "", Synonym = "Показатели")]
        public List<ОплатаПоСреднемуЗаработку_Показатели> ОплатаПоСреднемуЗаработкуПоказатели {get;set;}
        [Description1C8(Name = "РаспределениеРезультатовНачислений", Comment = "", Synonym = "Распределение результатов начислений")]
        public List<ОплатаПоСреднемуЗаработку_РаспределениеРезультатовНачислений> ОплатаПоСреднемуЗаработкуРаспределениеРезультатовНачислений {get;set;}
        [Description1C8(Name = "РаспределениеРезультатовУдержаний", Comment = "", Synonym = "Распределение результатов удержаний")]
        public List<ОплатаПоСреднемуЗаработку_РаспределениеРезультатовУдержаний> ОплатаПоСреднемуЗаработкуРаспределениеРезультатовУдержаний {get;set;}
        [Description1C8(Name = "СреднийЗаработокОбщий", Comment = "", Synonym = "Средний заработок общий")]
        public List<ОплатаПоСреднемуЗаработку_СреднийЗаработокОбщий> ОплатаПоСреднемуЗаработкуСреднийЗаработокОбщий {get;set;}
        [Description1C8(Name = "Удержания", Comment = "", Synonym = "Удержания")]
        public List<ОплатаПоСреднемуЗаработку_Удержания> ОплатаПоСреднемуЗаработкуУдержания {get;set;}
        [Description1C8(Name = "ДенежноеСодержание", Comment = "", Synonym = "Денежное содержание")]
        public List<ОплатаПоСреднемуЗаработку_ДенежноеСодержание> ОплатаПоСреднемуЗаработкуДенежноеСодержание {get;set;}
        [Description1C8(Name = "ДенежноеСодержаниеФактическиеНачисления", Comment = "", Synonym = "Денежное содержание фактические начисления")]
        public List<ОплатаПоСреднемуЗаработку_ДенежноеСодержаниеФактическиеНачисления> ОплатаПоСреднемуЗаработкуДенежноеСодержаниеФактическиеНачисления {get;set;}
        [Description1C8(Name = "РаспределениеПоТерриториямУсловиямТруда", Comment = "", Synonym = "Распределение по территориям и условиям труда")]
        public List<ОплатаПоСреднемуЗаработку_РаспределениеПоТерриториямУсловиямТруда> ОплатаПоСреднемуЗаработкуРаспределениеПоТерриториямУсловиямТруда {get;set;}
        [Description1C8(Name = "ДополнительныеРеквизиты", Comment = "", Synonym = "Дополнительные реквизиты")]
        public List<ОплатаПоСреднемуЗаработку_ДополнительныеРеквизиты> ОплатаПоСреднемуЗаработкуДополнительныеРеквизиты {get;set;}
        [Description1C8(Name = "ВзносыФОТ", Comment = "", Synonym = "Взносы ФОТ")]
        public List<ОплатаПоСреднемуЗаработку_ВзносыФОТ> ОплатаПоСреднемуЗаработкуВзносыФОТ {get;set;}
        [Description1C8(Name = "Взносы", Comment = "", Synonym = "Взносы")]
        public List<ОплатаПоСреднемуЗаработку_Взносы> ОплатаПоСреднемуЗаработкуВзносы {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ДанныеОбИндексации", Comment = "", Synonym = "Данные об индексации")]
    [Table("OplataPoSrednemuZarabotku_DannyeObYndeksatsyy")]
    public class ОплатаПоСреднемуЗаработку_ДанныеОбИндексации
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "Период", Comment = "", Synonym = "Период")]
        public DateTime Период {get; set;}
        [Description1C8(Name = "КоэффициентИндексации", Comment = "", Synonym = "Коэффициент индексации")]
        // Format 9.8
        public decimal КоэффициентИндексации {get; set;}
    }
    [Description1C8(Name = "Начисления", Comment = "", Synonym = "Начисления")]
    [Table("OplataPoSrednemuZarabotku_Nachyslenyia")]
    public class ОплатаПоСреднемуЗаработку_Начисления
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
        [Description1C8(Name = "ОплаченоДней", Comment = "", Synonym = "Оплачено дней")]
        // Format 15.2
        public decimal ОплаченоДней {get; set;}
        [Description1C8(Name = "ОплаченоЧасов", Comment = "", Synonym = "Оплачено часов")]
        // Format 15.2
        public decimal ОплаченоЧасов {get; set;}
        [Description1C8(Name = "ПериодДействия", Comment = "", Synonym = "Период действия")]
        public DateTime ПериодДействия {get; set;}
    }
    [Description1C8(Name = "НачисленияПерерасчет", Comment = "", Synonym = "Начисления перерасчет")]
    [Table("OplataPoSrednemuZarabotku_NachyslenyiaPereraschet")]
    public class ОплатаПоСреднемуЗаработку_НачисленияПерерасчет
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
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
        [Description1C8(Name = "НормаДней", Comment = "", Synonym = "Норма дней")]
        // Format 7.2
        public decimal НормаДней {get; set;}
        [Description1C8(Name = "НормаЧасов", Comment = "", Synonym = "Норма часов")]
        // Format 7.2
        public decimal НормаЧасов {get; set;}
        [Description1C8(Name = "Сторно", Comment = "", Synonym = "Сторно")]
        public bool Сторно {get; set;}
        [Description1C8(Name = "СторнируемыйДокумент", Comment = "Документ, который зарегистрировал сторнируемое начисление", Synonym = "Сторнируемый документ")]
        public Документ.СторнированиеНачислений СторнируемыйДокумент {get; set;}
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
        [Description1C8(Name = "ФиксСтрока", Comment = "", Synonym = "Фикс строка")]
        public bool ФиксСтрока {get; set;}
        [Description1C8(Name = "ФиксЗаполнение", Comment = "", Synonym = "Фиксировано заполнение")]
        public bool ФиксЗаполнение {get; set;}
        [Description1C8(Name = "ФиксРасчетВремени", Comment = "", Synonym = "Фиксирован расчет времени")]
        public bool ФиксРасчетВремени {get; set;}
        [Description1C8(Name = "ФиксРасчет", Comment = "", Synonym = "Фиксирован расчет")]
        public bool ФиксРасчет {get; set;}
        [Description1C8(Name = "ФиксСторно", Comment = "", Synonym = "Не рассчитываемая сторно-запись")]
        public bool ФиксСторно {get; set;}
        [Description1C8(Name = "ГрафикРаботыНорма", Comment = "", Synonym = "График работы норма")]
        public Catalogs.ГрафикиРаботыСотрудников ГрафикРаботыНорма {get; set;}
        [Description1C8(Name = "ПериодРегистрацииВремени", Comment = "", Synonym = "Период регистрации времени")]
        public DateTime ПериодРегистрацииВремени {get; set;}
        [Description1C8(Name = "ВремяВЧасах", Comment = "", Synonym = "Время в часах")]
        public bool ВремяВЧасах {get; set;}
        [Description1C8(Name = "ВидУчетаВремени", Comment = "", Synonym = "Вид учета времени")]
        public Catalogs.ВидыИспользованияРабочегоВремени ВидУчетаВремени {get; set;}
        [Description1C8(Name = "ОплаченоДней", Comment = "", Synonym = "Оплачено дней")]
        // Format 15.2
        public decimal ОплаченоДней {get; set;}
        [Description1C8(Name = "ОплаченоЧасов", Comment = "", Synonym = "Оплачено часов")]
        // Format 15.2
        public decimal ОплаченоЧасов {get; set;}
        [Description1C8(Name = "РезультатВТомЧислеЗаСчетФБ", Comment = "", Synonym = "В том числе")]
        // Format 15.2
        public decimal РезультатВТомЧислеЗаСчетФБ {get; set;}
        [Description1C8(Name = "ДокументОснование", Comment = "", Synonym = "Документ основание")]
        public Документ.НазначениеПлановогоНачисления ДокументОснование {get; set;}
        [Description1C8(Name = "ПериодДействия", Comment = "", Synonym = "Период действия")]
        public DateTime ПериодДействия {get; set;}
    }
    [Description1C8(Name = "НДФЛ", Comment = "", Synonym = "НДФЛ")]
    [Table("OplataPoSrednemuZarabotku_NDFL")]
    public class ОплатаПоСреднемуЗаработку_НДФЛ
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
        [Description1C8(Name = "ИдентификаторСтрокиНДФЛ", Comment = "", Synonym = "Идентификатор строки НДФЛ")]
        // Format 7.0
        public long ИдентификаторСтрокиНДФЛ {get; set;}
        [Description1C8(Name = "ФиксСтрока", Comment = "", Synonym = "Фикс строка")]
        public bool ФиксСтрока {get; set;}
        [Description1C8(Name = "ФиксРасчет", Comment = "", Synonym = "Фиксирован расчет")]
        public bool ФиксРасчет {get; set;}
        [Description1C8(Name = "Доход", Comment = "ВидСтавки", Synonym = "Доход")]
        // Format 15.2
        public decimal Доход {get; set;}
        [Description1C8(Name = "ВидСтавки", Comment = "", Synonym = "Вид ставки")]
        public Enums.ВидыСтавокНДФЛ ВидСтавки {get; set;}
        [Description1C8(Name = "УвеличеннаяСтавка", Comment = "", Synonym = "Увеличенная ставка")]
        public Enums.ВидыСтавокНДФЛ УвеличеннаяСтавка {get; set;}
        [Description1C8(Name = "КодДохода", Comment = "", Synonym = "Код дохода")]
        public Catalogs.ВидыДоходовНДФЛ КодДохода {get; set;}
        [Description1C8(Name = "Льгота", Comment = "", Synonym = "Льгота")]
        public Catalogs.ВидыЛьготПоНДФЛ Льгота {get; set;}
        [Description1C8(Name = "КоличествоЛьгот", Comment = "", Synonym = "Количество льгот")]
        // Format 5.2
        public decimal КоличествоЛьгот {get; set;}
        [Description1C8(Name = "СуммаЛьготы", Comment = "", Synonym = "Сумма льготы")]
        // Format 15.2
        public decimal СуммаЛьготы {get; set;}
        [Description1C8(Name = "ДоходПолный", Comment = "", Synonym = "Доход полный")]
        // Format 15.2
        public decimal ДоходПолный {get; set;}
    }
    [Description1C8(Name = "ОтработанноеВремяДляСреднегоОбщий", Comment = "", Synonym = "Отработанное время для среднего общий")]
    [Table("OplataPoSrednemuZarabotku_OtrabotannoeVremiaDliaSrednehoObshchyi")]
    public class ОплатаПоСреднемуЗаработку_ОтработанноеВремяДляСреднегоОбщий
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "ПорядокРасчета", Comment = "", Synonym = "Порядок расчета")]
        public Enums.ПорядокРасчетаСреднегоЗаработкаОбщий ПорядокРасчета {get; set;}
        [Description1C8(Name = "Период", Comment = "", Synonym = "Период")]
        public DateTime Период {get; set;}
        [Description1C8(Name = "ОтработаноДней", Comment = "", Synonym = "Отработано дней")]
        // Format 7.2
        public decimal ОтработаноДней {get; set;}
        [Description1C8(Name = "ОтработаноДнейПятидневка", Comment = "", Synonym = "Отработано дней по пятидневке")]
        // Format 7.2
        public decimal ОтработаноДнейПятидневка {get; set;}
        [Description1C8(Name = "ОтработаноЧасов", Comment = "", Synonym = "Отработано часов")]
        // Format 7.2
        public decimal ОтработаноЧасов {get; set;}
        [Description1C8(Name = "ОтработаноДнейШестидневка", Comment = "", Synonym = "Отработано дней по шестидневке")]
        // Format 7.2
        public decimal ОтработаноДнейШестидневка {get; set;}
        [Description1C8(Name = "ОтработаноДнейКалендарных", Comment = "", Synonym = "Отработано дней календарных")]
        // Format 7.2
        public decimal ОтработаноДнейКалендарных {get; set;}
        [Description1C8(Name = "НормаДнейПроизводственныйКалендарь", Comment = "", Synonym = "Норма дней по производственному календарю")]
        // Format 7.2
        public decimal НормаДнейПроизводственныйКалендарь {get; set;}
        [Description1C8(Name = "ОтработаноЧасовПятидневка", Comment = "", Synonym = "Отработано часов по пятидневке")]
        // Format 5.2
        public decimal ОтработаноЧасовПятидневка {get; set;}
        [Description1C8(Name = "НормаЧасовПроизводственныйКалендарь", Comment = "", Synonym = "Норма часов по производственному календарю")]
        // Format 5.2
        public decimal НормаЧасовПроизводственныйКалендарь {get; set;}
        [Description1C8(Name = "УдалитьКорректировка", Comment = "", Synonym = "(Не используется) Корректировка")]
        public bool УдалитьКорректировка {get; set;}
        [Description1C8(Name = "Источник", Comment = "", Synonym = "Источник")]
        public Enums.ИсточникиДанныхДляРасчетаСреднегоЗаработка Источник {get; set;}
        [Description1C8(Name = "НормаДнейПоГрафикуСотрудника", Comment = "", Synonym = "Норма дней по графику сотрудника")]
        // Format 5.2
        public decimal НормаДнейПоГрафикуСотрудника {get; set;}
        [Description1C8(Name = "НормаЧасовПоГрафикуСотрудника", Comment = "", Synonym = "Норма часов по графику сотрудника")]
        // Format 5.2
        public decimal НормаЧасовПоГрафикуСотрудника {get; set;}
        [Description1C8(Name = "СреднемесячноеКоличествоДней", Comment = "", Synonym = "Среднемесячное количество дней")]
        // Format 5.2
        public decimal СреднемесячноеКоличествоДней {get; set;}
    }
    [Description1C8(Name = "Показатели", Comment = "", Synonym = "Показатели")]
    [Table("OplataPoSrednemuZarabotku_Pokazately")]
    public class ОплатаПоСреднемуЗаработку_Показатели
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
    [Description1C8(Name = "РаспределениеРезультатовНачислений", Comment = "", Synonym = "Распределение результатов начислений")]
    [Table("OplataPoSrednemuZarabotku_RaspredelenyeRezultatovNachyslenyi")]
    public class ОплатаПоСреднемуЗаработку_РаспределениеРезультатовНачислений
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
    [Table("OplataPoSrednemuZarabotku_RaspredelenyeRezultatovUderzhanyi")]
    public class ОплатаПоСреднемуЗаработку_РаспределениеРезультатовУдержаний
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
    [Description1C8(Name = "СреднийЗаработокОбщий", Comment = "", Synonym = "Средний заработок общий")]
    [Table("OplataPoSrednemuZarabotku_SrednyiZarabotokObshchyi")]
    public class ОплатаПоСреднемуЗаработку_СреднийЗаработокОбщий
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "ПорядокРасчета", Comment = "", Synonym = "Порядок расчета")]
        public Enums.ПорядокРасчетаСреднегоЗаработкаОбщий ПорядокРасчета {get; set;}
        [Description1C8(Name = "СоставнаяЧасть", Comment = "", Synonym = "Составная часть")]
        public Enums.УчетНачисленийВСреднемЗаработкеОбщий СоставнаяЧасть {get; set;}
        [Description1C8(Name = "СтатьяФинансирования", Comment = "", Synonym = "Статья финансирования")]
        public Catalogs.СтатьиФинансированияЗарплата СтатьяФинансирования {get; set;}
        [Description1C8(Name = "Период", Comment = "", Synonym = "Период")]
        public DateTime Период {get; set;}
        [Description1C8(Name = "Индексируется", Comment = "", Synonym = "Индексируется")]
        public bool Индексируется {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "УдалитьКорректировка", Comment = "", Synonym = "(Не используется) Корректировка")]
        public bool УдалитьКорректировка {get; set;}
        [Description1C8(Name = "Год", Comment = "", Synonym = "Год")]
        // Format 4.0
        public long Год {get; set;}
        [Description1C8(Name = "ДатаНачалаБазовогоПериода", Comment = "", Synonym = "Дата начала базового периода")]
        public DateTime ДатаНачалаБазовогоПериода {get; set;}
        [Description1C8(Name = "КоличествоМесяцев", Comment = "", Synonym = "Количество месяцев")]
        // Format 3.0
        public long КоличествоМесяцев {get; set;}
        [Description1C8(Name = "Источник", Comment = "", Synonym = "Источник")]
        public Enums.ИсточникиДанныхДляРасчетаСреднегоЗаработка Источник {get; set;}
    }
    [Description1C8(Name = "Удержания", Comment = "", Synonym = "Удержания")]
    [Table("OplataPoSrednemuZarabotku_Uderzhanyia")]
    public class ОплатаПоСреднемуЗаработку_Удержания
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
        public Документ.УдержаниеВСчетРасчетовПоПрочимОперациям ДокументОснование {get; set;}
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
    }
    [Description1C8(Name = "ДенежноеСодержание", Comment = "", Synonym = "Денежное содержание")]
    [Table("OplataPoSrednemuZarabotku_DenezhnoeSoderzhanye")]
    public class ОплатаПоСреднемуЗаработку_ДенежноеСодержание
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "Начисление", Comment = "", Synonym = "Начисление")]
        public ПланВидовРасчета.Начисления Начисление {get; set;}
        [Description1C8(Name = "СоставнаяЧасть", Comment = "", Synonym = "Составная часть")]
        public Enums.УчетНачисленийВСреднемЗаработкеОбщий СоставнаяЧасть {get; set;}
        [Description1C8(Name = "НазначениеРасчета", Comment = "", Synonym = "Назначение расчета")]
        [StringLength(10)]
        public string НазначениеРасчета {get; set;}
        [Description1C8(Name = "ИдентификаторСтрокиВидаРасчета", Comment = "", Synonym = "Идентификатор строки вида расчета")]
        // Format 7.0
        public long ИдентификаторСтрокиВидаРасчета {get; set;}
        [Description1C8(Name = "Результат", Comment = "", Synonym = "Результат")]
        // Format 15.2
        public decimal Результат {get; set;}
        [Description1C8(Name = "ФиксРасчет", Comment = "", Synonym = "Фикс расчет")]
        public bool ФиксРасчет {get; set;}
    }
    [Description1C8(Name = "ДенежноеСодержаниеФактическиеНачисления", Comment = "", Synonym = "Денежное содержание фактические начисления")]
    [Table("OplataPoSrednemuZarabotku_DenezhnoeSoderzhanyeFaktycheskyeNachyslenyia")]
    public class ОплатаПоСреднемуЗаработку_ДенежноеСодержаниеФактическиеНачисления
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "НазначениеРасчета", Comment = "", Synonym = "Назначение расчета")]
        [StringLength(10)]
        public string НазначениеРасчета {get; set;}
        [Description1C8(Name = "СоставнаяЧасть", Comment = "", Synonym = "Составная часть")]
        [StringLength(10)]
        public string СоставнаяЧасть {get; set;}
        [Description1C8(Name = "Период", Comment = "", Synonym = "Период")]
        public DateTime Период {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "Корректировка", Comment = "", Synonym = "Корректировка")]
        public bool Корректировка {get; set;}
    }
    [Description1C8(Name = "РаспределениеПоТерриториямУсловиямТруда", Comment = "", Synonym = "Распределение по территориям и условиям труда")]
    [Table("OplataPoSrednemuZarabotku_RaspredelenyePoTerrytoryiamUslovyiamTruda")]
    public class ОплатаПоСреднемуЗаработку_РаспределениеПоТерриториямУсловиямТруда
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
    [Description1C8(Name = "ДополнительныеРеквизиты", Comment = "", Synonym = "Дополнительные реквизиты")]
    [Table("OplataPoSrednemuZarabotku_DopolnytelnyeRekvyzyty")]
    public class ОплатаПоСреднемуЗаработку_ДополнительныеРеквизиты
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Свойство", Comment = "", Synonym = "Свойство")]
        public ПланВидовХарактеристик.ДополнительныеРеквизитыИСведения Свойство {get; set;}
        [Description1C8(Name = "Значение", Comment = "", Synonym = "Значение")]
        public Catalogs.Склады Значение {get; set;}
        [Description1C8(Name = "ТекстоваяСтрока", Comment = "", Synonym = "Текстовая строка")]
        public string ТекстоваяСтрока {get; set;}
    }
    [Description1C8(Name = "ВзносыФОТ", Comment = "", Synonym = "Взносы ФОТ")]
    [Table("OplataPoSrednemuZarabotku_VznosyFOT")]
    public class ОплатаПоСреднемуЗаработку_ВзносыФОТ
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
    [Description1C8(Name = "Взносы", Comment = "", Synonym = "Взносы")]
    [Table("OplataPoSrednemuZarabotku_Vznosy")]
    public class ОплатаПоСреднемуЗаработку_Взносы
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
