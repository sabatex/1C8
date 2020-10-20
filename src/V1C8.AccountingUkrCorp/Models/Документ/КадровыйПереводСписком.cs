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
    [Table("KadrovyiPerevodSpyskom")]
    [Description1C8(Name = "КадровыйПереводСписком", Comment = "", Synonym = "Кадровый перевод списком")]
    public class КадровыйПереводСписком:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "ДатаСобытия", Comment = "", Synonym = "Дата события")]
        public DateTime ДатаСобытия {get; set;}
        [Description1C8(Name = "НачисленияУтверждены", Comment = "", Synonym = "Начисления утверждены")]
        public bool НачисленияУтверждены {get; set;}
        [Description1C8(Name = "ИсправленныйДокумент", Comment = "", Synonym = "Исправленный документ")]
        public Документ.КадровыйПереводСписком ИсправленныйДокумент {get; set;}
        [Description1C8(Name = "ВидДоговора", Comment = "", Synonym = "Вид договора")]
        public Enums.ВидыДоговоровССотрудниками ВидДоговора {get; set;}
        [Description1C8(Name = "ОснованиеПредставителяНанимателя", Comment = "", Synonym = "Основание представителя нанимателя")]
        public string ОснованиеПредставителяНанимателя {get; set;}
        [Description1C8(Name = "БронированиеПозиции", Comment = "", Synonym = "Бронирование позиции")]
        public bool БронированиеПозиции {get; set;}
        [Description1C8(Name = "Руководитель", Comment = "", Synonym = "Руководитель")]
        public Catalogs.ФизическиеЛица Руководитель {get; set;}
        [Description1C8(Name = "ДолжностьРуководителя", Comment = "", Synonym = "Должность")]
        public Catalogs.Должности ДолжностьРуководителя {get; set;}
        [Description1C8(Name = "КраткийСоставДокумента", Comment = "Краткий перечень сотрудников, включенных в документ", Synonym = "Сотрудники")]
        [StringLength(100)]
        public string КраткийСоставДокумента {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Сотрудники", Comment = "", Synonym = "Сотрудники")]
        public List<КадровыйПереводСписком_Сотрудники> КадровыйПереводСпискомСотрудники {get;set;}
        [Description1C8(Name = "Начисления", Comment = "", Synonym = "Начисления")]
        public List<КадровыйПереводСписком_Начисления> КадровыйПереводСпискомНачисления {get;set;}
        [Description1C8(Name = "Показатели", Comment = "", Synonym = "Показатели")]
        public List<КадровыйПереводСписком_Показатели> КадровыйПереводСпискомПоказатели {get;set;}
        [Description1C8(Name = "ЕжегодныеОтпуска", Comment = "", Synonym = "Ежегодные отпуска")]
        public List<КадровыйПереводСписком_ЕжегодныеОтпуска> КадровыйПереводСпискомЕжегодныеОтпуска {get;set;}
        [Description1C8(Name = "Льготы", Comment = "", Synonym = "Льготы")]
        public List<КадровыйПереводСписком_Льготы> КадровыйПереводСпискомЛьготы {get;set;}
        [Description1C8(Name = "КадровыйРезерв", Comment = "", Synonym = "Кадровый резерв")]
        public List<КадровыйПереводСписком_КадровыйРезерв> КадровыйПереводСпискомКадровыйРезерв {get;set;}
        [Description1C8(Name = "ДополнительныеРеквизиты", Comment = "", Synonym = "Дополнительные реквизиты")]
        public List<КадровыйПереводСписком_ДополнительныеРеквизиты> КадровыйПереводСпискомДополнительныеРеквизиты {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Сотрудники", Comment = "", Synonym = "Сотрудники")]
    [Table("KadrovyiPerevodSpyskom_Sotrudnyky")]
    public class КадровыйПереводСписком_Сотрудники
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "ДатаНачала", Comment = "", Synonym = "Дата перевода")]
        public DateTime ДатаНачала {get; set;}
        [Description1C8(Name = "ОбособленноеПодразделение", Comment = "", Synonym = "Обособленное подразделение")]
        public Catalogs.Организации ОбособленноеПодразделение {get; set;}
        [Description1C8(Name = "ДатаОкончания", Comment = "", Synonym = "Дата возврата")]
        public DateTime ДатаОкончания {get; set;}
        [Description1C8(Name = "Должность", Comment = "", Synonym = "Должность")]
        public Catalogs.Должности Должность {get; set;}
        [Description1C8(Name = "ДолжностьПоШтатномуРасписанию", Comment = "", Synonym = "Должность по штатному расписанию")]
        public Catalogs.ШтатноеРасписание ДолжностьПоШтатномуРасписанию {get; set;}
        [Description1C8(Name = "ВидЗанятости", Comment = "", Synonym = "Вид занятости")]
        public Enums.ВидыЗанятости ВидЗанятости {get; set;}
        [Description1C8(Name = "КоличествоСтавок", Comment = "", Synonym = "Колич. ставок")]
        // Format 22.20
        public decimal КоличествоСтавок {get; set;}
        [Description1C8(Name = "ГрафикРаботы", Comment = "", Synonym = "График работы")]
        public Catalogs.ГрафикиРаботыСотрудников ГрафикРаботы {get; set;}
        [Description1C8(Name = "ИзменитьПодразделениеИДолжность", Comment = "", Synonym = "Изменить подразделение и должность")]
        public bool ИзменитьПодразделениеИДолжность {get; set;}
        [Description1C8(Name = "ИзменитьГрафикРаботы", Comment = "", Synonym = "Изменить график работы")]
        public bool ИзменитьГрафикРаботы {get; set;}
        [Description1C8(Name = "ИзменитьНачисления", Comment = "", Synonym = "Изменить начисления")]
        public bool ИзменитьНачисления {get; set;}
        [Description1C8(Name = "ИзменитьЕжегодныеОтпуска", Comment = "", Synonym = "Изменить ежегодные отпуска")]
        public bool ИзменитьЕжегодныеОтпуска {get; set;}
        [Description1C8(Name = "ИзменитьАванс", Comment = "", Synonym = "Изменить аванс")]
        public bool ИзменитьАванс {get; set;}
        [Description1C8(Name = "СпособРасчетаАванса", Comment = "", Synonym = "Способ расчета аванса")]
        public Enums.СпособыРасчетаАванса СпособРасчетаАванса {get; set;}
        [Description1C8(Name = "Аванс", Comment = "", Synonym = "Аванс")]
        // Format 15.2
        public decimal Аванс {get; set;}
        [Description1C8(Name = "ПричинаПеревода", Comment = "", Synonym = "Причина перевода")]
        public string ПричинаПеревода {get; set;}
        [Description1C8(Name = "ОснованиеПеревода", Comment = "", Synonym = "Основание перевода")]
        [StringLength(254)]
        public string ОснованиеПеревода {get; set;}
        [Description1C8(Name = "СпособОтраженияЗарплатыВБухучете", Comment = "", Synonym = "Способ отражения")]
        public Catalogs.СпособыОтраженияЗарплатыВБухУчете СпособОтраженияЗарплатыВБухучете {get; set;}
        [Description1C8(Name = "СтатьяФинансирования", Comment = "", Synonym = "Финансирование")]
        public Catalogs.СтатьиФинансированияЗарплата СтатьяФинансирования {get; set;}
        [Description1C8(Name = "ПорядокРасчетаСтоимостиЕдиницыВремени", Comment = "", Synonym = "Порядок расчета стоимости единицы времени")]
        public Enums.ПорядокРасчетаСтоимостиЕдиницыВремениОплатыТруда ПорядокРасчетаСтоимостиЕдиницыВремени {get; set;}
        [Description1C8(Name = "СовокупнаяТарифнаяСтавка", Comment = "", Synonym = "Совокупная тарифная ставка")]
        // Format 15.2
        public decimal СовокупнаяТарифнаяСтавка {get; set;}
        [Description1C8(Name = "ВидТарифнойСтавки", Comment = "", Synonym = "Вид тарифной ставки")]
        public Enums.ВидыТарифныхСтавок ВидТарифнойСтавки {get; set;}
        [Description1C8(Name = "РазрядКатегория", Comment = "", Synonym = "Разряд (категория)")]
        public Catalogs.РазрядыКатегорииДолжностей РазрядКатегория {get; set;}
        [Description1C8(Name = "ИзменитьСведенияОДоговореКонтракте", Comment = "", Synonym = "Изменить сведения о договоре, контракте")]
        public bool ИзменитьСведенияОДоговореКонтракте {get; set;}
        [Description1C8(Name = "СменаВидаДоговора", Comment = "", Synonym = "Смена вида договора")]
        public bool СменаВидаДоговора {get; set;}
        [Description1C8(Name = "ТрудовойДоговорНомер", Comment = "", Synonym = "Номер")]
        [StringLength(13)]
        public string ТрудовойДоговорНомер {get; set;}
        [Description1C8(Name = "ТрудовойДоговорДата", Comment = "", Synonym = "Дата")]
        public DateTime ТрудовойДоговорДата {get; set;}
        [Description1C8(Name = "СрочныйДоговор", Comment = "", Synonym = "Срочный договор")]
        public bool СрочныйДоговор {get; set;}
        [Description1C8(Name = "ДатаЗавершенияТрудовогоДоговора", Comment = "", Synonym = "Дата завершения трудового договора")]
        public DateTime ДатаЗавершенияТрудовогоДоговора {get; set;}
        [Description1C8(Name = "ОснованиеСрочногоДоговора", Comment = "", Synonym = "Основание срочного договора")]
        public Catalogs.ОснованияЗаключенияСрочныхТрудовыхДоговоров ОснованиеСрочногоДоговора {get; set;}
        [Description1C8(Name = "СрокЗаключенияДоговора", Comment = "", Synonym = "Срок заключения договора")]
        [StringLength(100)]
        public string СрокЗаключенияДоговора {get; set;}
        [Description1C8(Name = "СпособПоступленияНаСлужбу", Comment = "", Synonym = "Способ поступления на службу")]
        [StringLength(10)]
        public string СпособПоступленияНаСлужбу {get; set;}
        [Description1C8(Name = "ПоступлениеНаСлужбуВпервые", Comment = "", Synonym = "Поступление на службу впервые")]
        public bool ПоступлениеНаСлужбуВпервые {get; set;}
        [Description1C8(Name = "ВидАктаГосоргана", Comment = "", Synonym = "Вид акта государственного органа")]
        [StringLength(100)]
        public string ВидАктаГосоргана {get; set;}
        [Description1C8(Name = "ОборудованиеРабочегоМеста", Comment = "", Synonym = "Оборудование рабочего места")]
        public string ОборудованиеРабочегоМеста {get; set;}
        [Description1C8(Name = "ИныеУсловияДоговора", Comment = "", Synonym = "Иные условия договора")]
        public string ИныеУсловияДоговора {get; set;}
        [Description1C8(Name = "Грейд", Comment = "", Synonym = "Грейд")]
        [StringLength(10)]
        public string Грейд {get; set;}
        [Description1C8(Name = "НаПериодПереводаСохранятьЛьготныйСтажПФР", Comment = "", Synonym = "На период перевода сохранять льготный стаж ПФР")]
        public bool НаПериодПереводаСохранятьЛьготныйСтажПФР {get; set;}
        [Description1C8(Name = "ИзменитьЛьготы", Comment = "", Synonym = "Изменить льготы")]
        public bool ИзменитьЛьготы {get; set;}
        [Description1C8(Name = "Территория", Comment = "", Synonym = "Территория")]
        public Catalogs.ТерриторииВыполненияРабот Территория {get; set;}
        [Description1C8(Name = "ПКУ", Comment = "", Synonym = "ПКУ")]
        public Catalogs.РазрядыКатегорииДолжностей ПКУ {get; set;}
        [Description1C8(Name = "КатегорияЕСВ", Comment = "", Synonym = "Категория ЕСВ")]
        public Catalogs.КатегорииЗастрахованныхЛицЕСВ КатегорияЕСВ {get; set;}
        [Description1C8(Name = "ИзменитьКатегорияЕСВ", Comment = "", Synonym = "Изменить категория ЕСВ")]
        public bool ИзменитьКатегорияЕСВ {get; set;}
        [Description1C8(Name = "ПринятНаНовоеРабочееМесто", Comment = "", Synonym = "Принят на новое рабочее место")]
        public bool ПринятНаНовоеРабочееМесто {get; set;}
        [Description1C8(Name = "ИзменениеДолжности", Comment = "", Synonym = "Изменение должности")]
        public bool ИзменениеДолжности {get; set;}
        [Description1C8(Name = "ПредыдущаяДолжность", Comment = "", Synonym = "Предыдущая должность")]
        public Catalogs.Должности ПредыдущаяДолжность {get; set;}
    }
    [Description1C8(Name = "Начисления", Comment = "", Synonym = "Начисления")]
    [Table("KadrovyiPerevodSpyskom_Nachyslenyia")]
    public class КадровыйПереводСписком_Начисления
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "Действие", Comment = "", Synonym = "Действие")]
        public Enums.ДействияСНачислениямиИУдержаниями Действие {get; set;}
        [Description1C8(Name = "Начисление", Comment = "", Synonym = "Начисление")]
        public ПланВидовРасчета.Начисления Начисление {get; set;}
        [Description1C8(Name = "ИдентификаторСтрокиВидаРасчета", Comment = "", Synonym = "Идентификатор строки вида расчета")]
        // Format 7.0
        public long ИдентификаторСтрокиВидаРасчета {get; set;}
        [Description1C8(Name = "ДокументОснование", Comment = "", Synonym = "Документ основание")]
        public Документ.НазначениеПлановогоНачисления ДокументОснование {get; set;}
        [Description1C8(Name = "Размер", Comment = "", Synonym = "Размер")]
        // Format 15.2
        public decimal Размер {get; set;}
        [Description1C8(Name = "ХарактерНачисления", Comment = "", Synonym = "Характер начисления")]
        public Enums.ХарактерПлановогоНачисления ХарактерНачисления {get; set;}
    }
    [Description1C8(Name = "Показатели", Comment = "", Synonym = "Показатели")]
    [Table("KadrovyiPerevodSpyskom_Pokazately")]
    public class КадровыйПереводСписком_Показатели
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
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
    }
    [Description1C8(Name = "ЕжегодныеОтпуска", Comment = "", Synonym = "Ежегодные отпуска")]
    [Table("KadrovyiPerevodSpyskom_EzhehodnyeOtpuska")]
    public class КадровыйПереводСписком_ЕжегодныеОтпуска
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "Действие", Comment = "", Synonym = "Действие")]
        public Enums.ДействияСЕжегоднымиОтпусками Действие {get; set;}
        [Description1C8(Name = "ВидЕжегодногоОтпуска", Comment = "", Synonym = "Вид ежегодного отпуска")]
        public Catalogs.ВидыОтпусков ВидЕжегодногоОтпуска {get; set;}
        [Description1C8(Name = "КоличествоДнейВГод", Comment = "", Synonym = "Количество дней в год")]
        // Format 2.0
        public long КоличествоДнейВГод {get; set;}
    }
    [Description1C8(Name = "Льготы", Comment = "", Synonym = "Льготы")]
    [Table("KadrovyiPerevodSpyskom_Lhoty")]
    public class КадровыйПереводСписком_Льготы
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "Льгота", Comment = "", Synonym = "Льгота")]
        public ПланВидовРасчета.Начисления Льгота {get; set;}
        [Description1C8(Name = "ИдентификаторСтрокиВидаРасчета", Comment = "", Synonym = "Идентификатор строки вида расчета")]
        // Format 7.0
        public long ИдентификаторСтрокиВидаРасчета {get; set;}
        [Description1C8(Name = "ДокументОснование", Comment = "", Synonym = "Документ основание")]
        public Документ.НазначениеПлановогоНачисления ДокументОснование {get; set;}
        [Description1C8(Name = "Размер", Comment = "", Synonym = "Размер")]
        // Format 15.2
        public decimal Размер {get; set;}
        [Description1C8(Name = "Действие", Comment = "", Synonym = "Действие")]
        public Enums.ДействияСНачислениямиИУдержаниями Действие {get; set;}
    }
    [Description1C8(Name = "КадровыйРезерв", Comment = "", Synonym = "Кадровый резерв")]
    [Table("KadrovyiPerevodSpyskom_KadrovyiRezerv")]
    public class КадровыйПереводСписком_КадровыйРезерв
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "ПозицияРезерва", Comment = "", Synonym = "Позиция резерва")]
        [StringLength(10)]
        public string ПозицияРезерва {get; set;}
        [Description1C8(Name = "ВидРезерва", Comment = "", Synonym = "Вид резерва")]
        [StringLength(10)]
        public string ВидРезерва {get; set;}
        [Description1C8(Name = "Действие", Comment = "", Synonym = "Действие")]
        [StringLength(10)]
        public string Действие {get; set;}
        [Description1C8(Name = "Статус", Comment = "", Synonym = "Статус")]
        public Enums.СостоянияСогласования Статус {get; set;}
    }
    [Description1C8(Name = "ДополнительныеРеквизиты", Comment = "", Synonym = "Дополнительные реквизиты")]
    [Table("KadrovyiPerevodSpyskom_DopolnytelnyeRekvyzyty")]
    public class КадровыйПереводСписком_ДополнительныеРеквизиты
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
}
