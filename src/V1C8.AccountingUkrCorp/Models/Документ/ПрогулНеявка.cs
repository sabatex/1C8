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
    [Table("ProhulNeiavka")]
    [Description1C8(Name = "ПрогулНеявка", Comment = "", Synonym = "Прогул, неявка")]
    public class ПрогулНеявка:CatalogItem
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
        [Description1C8(Name = "СостояниеСотрудника", Comment = "", Synonym = "Состояние сотрудника")]
        public Enums.СостоянияСотрудника СостояниеСотрудника {get; set;}
        [Description1C8(Name = "ВидОтсутствия", Comment = "", Synonym = "Вид неявки")]
        public ПланВидовРасчета.Начисления ВидОтсутствия {get; set;}
        [Description1C8(Name = "ДатаНачала", Comment = "", Synonym = "Дата начала")]
        public DateTime ДатаНачала {get; set;}
        [Description1C8(Name = "ДатаОкончания", Comment = "", Synonym = "Дата окончания")]
        public DateTime ДатаОкончания {get; set;}
        [Description1C8(Name = "ДатаОтсутствия", Comment = "", Synonym = "Дата отсутствия")]
        public DateTime ДатаОтсутствия {get; set;}
        [Description1C8(Name = "Начислено", Comment = "", Synonym = "Начислено")]
        // Format 13.2
        public decimal Начислено {get; set;}
        [Description1C8(Name = "ОтсутствиеВТечениеЧастиСмены", Comment = "", Synonym = "Отсутствие в течение части смены")]
        public bool ОтсутствиеВТечениеЧастиСмены {get; set;}
        [Description1C8(Name = "ЧасовОтсутствия", Comment = "", Synonym = "Часов отсутствия")]
        // Format 4.2
        public decimal ЧасовОтсутствия {get; set;}
        [Description1C8(Name = "ВидВремениЗамещаемый", Comment = "", Synonym = "Вид времени замещаемый")]
        public Catalogs.ВидыИспользованияРабочегоВремени ВидВремениЗамещаемый {get; set;}
        [Description1C8(Name = "ИсправленныйДокумент", Comment = "", Synonym = "Исправленный документ")]
        public Документ.ПрогулНеявка ИсправленныйДокумент {get; set;}
        [Description1C8(Name = "ПерерасчетВыполнен", Comment = "", Synonym = "Перерасчет выполнен")]
        public bool ПерерасчетВыполнен {get; set;}
        [Description1C8(Name = "Рассчитал", Comment = "", Synonym = "Рассчитал")]
        public Catalogs.Пользователи Рассчитал {get; set;}
        [Description1C8(Name = "ПредставлениеПериода", Comment = "", Synonym = "Представление периода")]
        [StringLength(19)]
        public string ПредставлениеПериода {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "УдалитьПодразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций УдалитьПодразделение {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Начисления", Comment = "", Synonym = "Начисления")]
        public List<ПрогулНеявка_Начисления> ПрогулНеявкаНачисления {get;set;}
        [Description1C8(Name = "НачисленияПерерасчет", Comment = "", Synonym = "Начисления перерасчет")]
        public List<ПрогулНеявка_НачисленияПерерасчет> ПрогулНеявкаНачисленияПерерасчет {get;set;}
        [Description1C8(Name = "Показатели", Comment = "", Synonym = "Показатели")]
        public List<ПрогулНеявка_Показатели> ПрогулНеявкаПоказатели {get;set;}
        [Description1C8(Name = "РаспределениеРезультатовНачислений", Comment = "", Synonym = "Распределение результатов начислений")]
        public List<ПрогулНеявка_РаспределениеРезультатовНачислений> ПрогулНеявкаРаспределениеРезультатовНачислений {get;set;}
        [Description1C8(Name = "РаспределениеПоТерриториямУсловиямТруда", Comment = "", Synonym = "Распределение по территориям и условиям труда")]
        public List<ПрогулНеявка_РаспределениеПоТерриториямУсловиямТруда> ПрогулНеявкаРаспределениеПоТерриториямУсловиямТруда {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Начисления", Comment = "", Synonym = "Начисления")]
    [Table("ProhulNeiavka_Nachyslenyia")]
    public class ПрогулНеявка_Начисления
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
        [Description1C8(Name = "Должность", Comment = "", Synonym = "Должность")]
        public Catalogs.Должности Должность {get; set;}
    }
    [Description1C8(Name = "НачисленияПерерасчет", Comment = "", Synonym = "Начисления перерасчет")]
    [Table("ProhulNeiavka_NachyslenyiaPereraschet")]
    public class ПрогулНеявка_НачисленияПерерасчет
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
        [Description1C8(Name = "Должность", Comment = "", Synonym = "Должность")]
        public Catalogs.Должности Должность {get; set;}
    }
    [Description1C8(Name = "Показатели", Comment = "", Synonym = "Показатели")]
    [Table("ProhulNeiavka_Pokazately")]
    public class ПрогулНеявка_Показатели
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
    [Table("ProhulNeiavka_RaspredelenyeRezultatovNachyslenyi")]
    public class ПрогулНеявка_РаспределениеРезультатовНачислений
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
    [Description1C8(Name = "РаспределениеПоТерриториямУсловиямТруда", Comment = "", Synonym = "Распределение по территориям и условиям труда")]
    [Table("ProhulNeiavka_RaspredelenyePoTerrytoryiamUslovyiamTruda")]
    public class ПрогулНеявка_РаспределениеПоТерриториямУсловиямТруда
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
