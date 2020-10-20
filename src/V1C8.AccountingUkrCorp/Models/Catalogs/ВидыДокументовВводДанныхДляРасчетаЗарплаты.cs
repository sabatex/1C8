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
    [Table("VydyDokumentovVvodDannykhDliaRaschetaZarplaty")]
    [Description1C8(Name = "ВидыДокументовВводДанныхДляРасчетаЗарплаты", Comment = "", Synonym = "Шаблоны ввода исходных данных")]
    public class ВидыДокументовВводДанныхДляРасчетаЗарплаты:EnumItem
    {
    #region Стандартні реквізити
    public Guid Id {get; set;}
    public bool IsFolder {get; set;}
    public bool DeletionMark {get; set;}
    public bool Predefined {get; set;}
    public string Code {get; set;}
    public string Description {get; set;}
    public Guid? Parent {get; set;}
    public Guid? Owner {get; set;}
    #endregion Стандартні реквізити
    #region реквізити
    [Description1C8(Name = "РеквизитДопУпорядочивания", Comment = "", Synonym = "Порядок")]
    // Format 5.0
    public long РеквизитДопУпорядочивания {get; set;}
    [Description1C8(Name = "ПредставлениеДокумента", Comment = "", Synonym = "Представление")]
    [StringLength(100)]
    public string ПредставлениеДокумента {get; set;}
    [Description1C8(Name = "Подсказка", Comment = "", Synonym = "Подсказка")]
    public string Подсказка {get; set;}
    [Description1C8(Name = "НесколькоОрганизаций", Comment = "", Synonym = "Несколько организаций")]
    public bool НесколькоОрганизаций {get; set;}
    [Description1C8(Name = "НесколькоПодразделений", Comment = "", Synonym = "Несколько подразделений")]
    public bool НесколькоПодразделений {get; set;}
    [Description1C8(Name = "НесколькоСотрудников", Comment = "", Synonym = "Несколько сотрудников")]
    public bool НесколькоСотрудников {get; set;}
    [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
    public DBNull Организация {get; set;}
    [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
    public DBNull Подразделение {get; set;}
    [Description1C8(Name = "ЗаполнятьСписокОбъектов", Comment = "", Synonym = "Заполнять список объектов автоматически")]
    public bool ЗаполнятьСписокОбъектов {get; set;}
    [Description1C8(Name = "ПоказыватьПодразделение", Comment = "", Synonym = "Показывать подразделение в документах")]
    public bool ПоказыватьПодразделение {get; set;}
    [Description1C8(Name = "ПроверятьЗаполнениеПодразделения", Comment = "", Synonym = "Подразделение обязательно для заполнения")]
    public bool ПроверятьЗаполнениеПодразделения {get; set;}
    [Description1C8(Name = "СпособПримененияЗначенийПоказателей", Comment = "", Synonym = "Способ применения значений показателей")]
    public DBNull СпособПримененияЗначенийПоказателей {get; set;}
    [Description1C8(Name = "ИспользоватьПериодОкончания", Comment = "", Synonym = "Использовать период окончания")]
    public bool ИспользоватьПериодОкончания {get; set;}
    [Description1C8(Name = "ЗначенияПоказателейВводятсяНаРазныеДаты", Comment = "", Synonym = "Значения показателей вводятся на разные даты")]
    public bool ЗначенияПоказателейВводятсяНаРазныеДаты {get; set;}
    [Description1C8(Name = "ВремяВводитсяСводно", Comment = "", Synonym = "Данные о времени вводятся сводно")]
    public bool ВремяВводитсяСводно {get; set;}
    [Description1C8(Name = "ВремяВводитсяЗаМесяц", Comment = "", Synonym = "Время вводится за месяц")]
    public bool ВремяВводитсяЗаМесяц {get; set;}
    [Description1C8(Name = "УдалитьИдентификаторОбъекта", Comment = "", Synonym = "(не использовать) Идентификатор объекта")]
    [StringLength(256)]
    public string УдалитьИдентификаторОбъекта {get; set;}
    [Description1C8(Name = "ВидыРаботЗаполняютсяВДокументе", Comment = "", Synonym = "Виды работ заполняются в документе")]
    public bool ВидыРаботЗаполняютсяВДокументе {get; set;}
    [Description1C8(Name = "ВыполненныеРаботыРаспределяютсяПоСотрудникам", Comment = "", Synonym = "Выполненные работы распределяются по сотрудникам")]
    public bool ВыполненныеРаботыРаспределяютсяПоСотрудникам {get; set;}
    [Description1C8(Name = "ВыполненныеРаботыРаспределяютсяСУчетомКоэффициентов", Comment = "", Synonym = "Выполненные работы распределяются с учетом коэффициентов")]
    public bool ВыполненныеРаботыРаспределяютсяСУчетомКоэффициентов {get; set;}
    [Description1C8(Name = "ВыполненныеРаботыРаспределяютсяСУчетомТарифныхСтавок", Comment = "", Synonym = "Выполненные работы распределяются с учетом тарифных ставок")]
    public bool ВыполненныеРаботыРаспределяютсяСУчетомТарифныхСтавок {get; set;}
    [Description1C8(Name = "ВыполненныеРаботыРаспределяютсяСУчетомОтработанногоВремени", Comment = "", Synonym = "Выполненные работы распределяются с учетом отработанного времени")]
    public bool ВыполненныеРаботыРаспределяютсяСУчетомОтработанногоВремени {get; set;}
    [Description1C8(Name = "ВыполненныеРаботыВводятсяСводно", Comment = "", Synonym = "Выполненные работы вводятся сводно")]
    public bool ВыполненныеРаботыВводятсяСводно {get; set;}
    [Description1C8(Name = "КраткийСостав", Comment = "", Synonym = "Краткий состав")]
    [StringLength(50)]
    public string КраткийСостав {get; set;}
    [Description1C8(Name = "НеИспользуется", Comment = "", Synonym = "Шаблон документа больше не используется")]
    public bool НеИспользуется {get; set;}
    #endregion реквізити
    }
}
