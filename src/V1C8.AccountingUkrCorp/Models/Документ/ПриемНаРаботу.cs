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
    [Table("PryemNaRabotu")]
    [Description1C8(Name = "ПриемНаРаботу", Comment = "", Synonym = "Прием на работу")]
    public class ПриемНаРаботу:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "Должность", Comment = "", Synonym = "Должность")]
        public Catalogs.Должности Должность {get; set;}
        [Description1C8(Name = "ДолжностьПоШтатномуРасписанию", Comment = "", Synonym = "Должность по штатному расписанию")]
        public Catalogs.ШтатноеРасписание ДолжностьПоШтатномуРасписанию {get; set;}
        [Description1C8(Name = "ДатаПриема", Comment = "", Synonym = "Дата приема")]
        public DateTime ДатаПриема {get; set;}
        [Description1C8(Name = "КоличествоСтавок", Comment = "", Synonym = "Колич. ставок")]
        // Format 22.20
        public decimal КоличествоСтавок {get; set;}
        [Description1C8(Name = "ВидЗанятости", Comment = "", Synonym = "Вид занятости")]
        public Enums.ВидыЗанятости ВидЗанятости {get; set;}
        [Description1C8(Name = "ДлительностьИспытательногоСрока", Comment = "", Synonym = "Испыт. срок (мес)")]
        // Format 4.1
        public decimal ДлительностьИспытательногоСрока {get; set;}
        [Description1C8(Name = "ГрафикРаботы", Comment = "", Synonym = "График работы")]
        public Catalogs.ГрафикиРаботыСотрудников ГрафикРаботы {get; set;}
        [Description1C8(Name = "СпособРасчетаАванса", Comment = "", Synonym = "Способ расчета аванса")]
        public Enums.СпособыРасчетаАванса СпособРасчетаАванса {get; set;}
        [Description1C8(Name = "Аванс", Comment = "", Synonym = "Аванс")]
        // Format 15.2
        public decimal Аванс {get; set;}
        [Description1C8(Name = "УсловияПриема", Comment = "", Synonym = "Условия приема")]
        public string УсловияПриема {get; set;}
        [Description1C8(Name = "Руководитель", Comment = "", Synonym = "Руководитель")]
        public Catalogs.ФизическиеЛица Руководитель {get; set;}
        [Description1C8(Name = "ДолжностьРуководителя", Comment = "", Synonym = "Должность")]
        public Catalogs.Должности ДолжностьРуководителя {get; set;}
        [Description1C8(Name = "НачисленияУтверждены", Comment = "", Synonym = "Начисления утверждены")]
        public bool НачисленияУтверждены {get; set;}
        [Description1C8(Name = "СпособОтраженияЗарплатыВБухучете", Comment = "", Synonym = "Способ отражения")]
        public Catalogs.СпособыОтраженияЗарплатыВБухУчете СпособОтраженияЗарплатыВБухучете {get; set;}
        [Description1C8(Name = "СтатьяФинансирования", Comment = "", Synonym = "Финансирование")]
        public Catalogs.СтатьиФинансированияЗарплата СтатьяФинансирования {get; set;}
        [Description1C8(Name = "ИсправленныйДокумент", Comment = "", Synonym = "Исправленный документ")]
        public Документ.ПриемНаРаботу ИсправленныйДокумент {get; set;}
        [Description1C8(Name = "ПорядокРасчетаСтоимостиЕдиницыВремени", Comment = "", Synonym = "Порядок расчета стоимости единицы времени")]
        public Enums.ПорядокРасчетаСтоимостиЕдиницыВремениОплатыТруда ПорядокРасчетаСтоимостиЕдиницыВремени {get; set;}
        [Description1C8(Name = "СовокупнаяТарифнаяСтавка", Comment = "", Synonym = "Совокупная тарифная ставка")]
        // Format 15.2
        public decimal СовокупнаяТарифнаяСтавка {get; set;}
        [Description1C8(Name = "ВидТарифнойСтавки", Comment = "", Synonym = "Вид тарифной ставки")]
        public Enums.ВидыТарифныхСтавок ВидТарифнойСтавки {get; set;}
        [Description1C8(Name = "РазрядКатегория", Comment = "", Synonym = "Разряд (категория)")]
        public Catalogs.РазрядыКатегорииДолжностей РазрядКатегория {get; set;}
        [Description1C8(Name = "ВидДоговора", Comment = "", Synonym = "Вид договора")]
        public Enums.ВидыДоговоровССотрудниками ВидДоговора {get; set;}
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
        [StringLength(300)]
        public string СрокЗаключенияДоговора {get; set;}
        [Description1C8(Name = "ОснованиеПредставителяНанимателя", Comment = "", Synonym = "Основание представителя нанимателя")]
        public string ОснованиеПредставителяНанимателя {get; set;}
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
        [Description1C8(Name = "Территория", Comment = "", Synonym = "Территория")]
        public Catalogs.ТерриторииВыполненияРабот Территория {get; set;}
        [Description1C8(Name = "БронированиеПозиции", Comment = "", Synonym = "Бронирование позиции")]
        public bool БронированиеПозиции {get; set;}
        [Description1C8(Name = "РазрешениеНаРаботу", Comment = "", Synonym = "Разрешение на работу")]
        [StringLength(1000)]
        public string РазрешениеНаРаботу {get; set;}
        [Description1C8(Name = "РазрешениеНаПроживание", Comment = "", Synonym = "Разрешение на проживание")]
        [StringLength(1000)]
        public string РазрешениеНаПроживание {get; set;}
        [Description1C8(Name = "УсловияОказанияМедпомощи", Comment = "", Synonym = "Условия оказания медпомощи")]
        [StringLength(1000)]
        public string УсловияОказанияМедпомощи {get; set;}
        [Description1C8(Name = "ПКУ", Comment = "", Synonym = "ПКУ")]
        public Catalogs.РазрядыКатегорииДолжностей ПКУ {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "КатегорияЕСВ", Comment = "", Synonym = "Категория ЕСВ")]
        public Catalogs.КатегорииЗастрахованныхЛицЕСВ КатегорияЕСВ {get; set;}
        [Description1C8(Name = "ПринятНаНовоеРабочееМесто", Comment = "", Synonym = "Принят на новое рабочее место")]
        public bool ПринятНаНовоеРабочееМесто {get; set;}
        [Description1C8(Name = "ДатаСозданияРабочегоМеста", Comment = "", Synonym = "Дата создания рабочего места")]
        public DateTime ДатаСозданияРабочегоМеста {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Начисления", Comment = "", Synonym = "Начисления")]
        public List<ПриемНаРаботу_Начисления> ПриемНаРаботуНачисления {get;set;}
        [Description1C8(Name = "Показатели", Comment = "", Synonym = "Показатели")]
        public List<ПриемНаРаботу_Показатели> ПриемНаРаботуПоказатели {get;set;}
        [Description1C8(Name = "ЕжегодныеОтпуска", Comment = "", Synonym = "Ежегодные отпуска")]
        public List<ПриемНаРаботу_ЕжегодныеОтпуска> ПриемНаРаботуЕжегодныеОтпуска {get;set;}
        [Description1C8(Name = "Льготы", Comment = "", Synonym = "Льготы")]
        public List<ПриемНаРаботу_Льготы> ПриемНаРаботуЛьготы {get;set;}
        [Description1C8(Name = "ДополнительныеРеквизиты", Comment = "", Synonym = "Дополнительные реквизиты")]
        public List<ПриемНаРаботу_ДополнительныеРеквизиты> ПриемНаРаботуДополнительныеРеквизиты {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Начисления", Comment = "", Synonym = "Начисления")]
    [Table("PryemNaRabotu_Nachyslenyia")]
    public class ПриемНаРаботу_Начисления
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Начисление", Comment = "", Synonym = "Начисление")]
        public ПланВидовРасчета.Начисления Начисление {get; set;}
        [Description1C8(Name = "ИдентификаторСтрокиВидаРасчета", Comment = "", Synonym = "Идентификатор строки вида расчета")]
        // Format 7.0
        public long ИдентификаторСтрокиВидаРасчета {get; set;}
        [Description1C8(Name = "Размер", Comment = "", Synonym = "Размер")]
        // Format 15.2
        public decimal Размер {get; set;}
    }
    [Description1C8(Name = "Показатели", Comment = "", Synonym = "Показатели")]
    [Table("PryemNaRabotu_Pokazately")]
    public class ПриемНаРаботу_Показатели
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
    }
    [Description1C8(Name = "ЕжегодныеОтпуска", Comment = "", Synonym = "Ежегодные отпуска")]
    [Table("PryemNaRabotu_EzhehodnyeOtpuska")]
    public class ПриемНаРаботу_ЕжегодныеОтпуска
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ВидЕжегодногоОтпуска", Comment = "", Synonym = "Вид ежегодного отпуска")]
        public Catalogs.ВидыОтпусков ВидЕжегодногоОтпуска {get; set;}
        [Description1C8(Name = "КоличествоДнейВГод", Comment = "", Synonym = "Количество дней в год")]
        // Format 2.0
        public long КоличествоДнейВГод {get; set;}
    }
    [Description1C8(Name = "Льготы", Comment = "", Synonym = "Льготы")]
    [Table("PryemNaRabotu_Lhoty")]
    public class ПриемНаРаботу_Льготы
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Льгота", Comment = "", Synonym = "Льгота")]
        public ПланВидовРасчета.Начисления Льгота {get; set;}
        [Description1C8(Name = "ИдентификаторСтрокиВидаРасчета", Comment = "", Synonym = "Идентификатор строки вида расчета")]
        // Format 7.0
        public long ИдентификаторСтрокиВидаРасчета {get; set;}
        [Description1C8(Name = "Размер", Comment = "", Synonym = "Размер")]
        // Format 15.2
        public decimal Размер {get; set;}
    }
    [Description1C8(Name = "ДополнительныеРеквизиты", Comment = "", Synonym = "Дополнительные реквизиты")]
    [Table("PryemNaRabotu_DopolnytelnyeRekvyzyty")]
    public class ПриемНаРаботу_ДополнительныеРеквизиты
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
