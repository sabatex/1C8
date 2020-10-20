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
    public class ВидыДокументовВводДанныхДляРасчетаЗарплаты:CatalogItem
    {
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
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "ЗаполнятьСписокОбъектов", Comment = "", Synonym = "Заполнять список объектов автоматически")]
        public bool ЗаполнятьСписокОбъектов {get; set;}
        [Description1C8(Name = "ПоказыватьПодразделение", Comment = "", Synonym = "Показывать подразделение в документах")]
        public bool ПоказыватьПодразделение {get; set;}
        [Description1C8(Name = "ПроверятьЗаполнениеПодразделения", Comment = "", Synonym = "Подразделение обязательно для заполнения")]
        public bool ПроверятьЗаполнениеПодразделения {get; set;}
        [Description1C8(Name = "СпособПримененияЗначенийПоказателей", Comment = "", Synonym = "Способ применения значений показателей")]
        public Enums.СпособыПримененияЗначенийПоказателейРасчетаЗарплаты СпособПримененияЗначенийПоказателей {get; set;}
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
        #region tables
        [Description1C8(Name = "Показатели", Comment = "", Synonym = "Показатели")]
        public List<ВидыДокументовВводДанныхДляРасчетаЗарплаты_Показатели> ВидыДокументовВводДанныхДляРасчетаЗарплатыПоказатели {get;set;}
        [Description1C8(Name = "ВидыВремени", Comment = "", Synonym = "Виды времени")]
        public List<ВидыДокументовВводДанныхДляРасчетаЗарплаты_ВидыВремени> ВидыДокументовВводДанныхДляРасчетаЗарплатыВидыВремени {get;set;}
        [Description1C8(Name = "ВидыРабот", Comment = "", Synonym = "Виды работ")]
        public List<ВидыДокументовВводДанныхДляРасчетаЗарплаты_ВидыРабот> ВидыДокументовВводДанныхДляРасчетаЗарплатыВидыРабот {get;set;}
        [Description1C8(Name = "ВнешниеПечатныеФормы", Comment = "", Synonym = "Внешние печатные формы")]
        public List<ВидыДокументовВводДанныхДляРасчетаЗарплаты_ВнешниеПечатныеФормы> ВидыДокументовВводДанныхДляРасчетаЗарплатыВнешниеПечатныеФормы {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Показатели", Comment = "", Synonym = "Показатели")]
    [Table("VydyDokumentovVvodDannykhDliaRaschetaZarplaty_Pokazately")]
    public class ВидыДокументовВводДанныхДляРасчетаЗарплаты_Показатели
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Показатель", Comment = "", Synonym = "Показатель")]
        public Catalogs.ПоказателиРасчетаЗарплаты Показатель {get; set;}
    }
    [Description1C8(Name = "ВидыВремени", Comment = "", Synonym = "Виды времени")]
    [Table("VydyDokumentovVvodDannykhDliaRaschetaZarplaty_VydyVremeny")]
    public class ВидыДокументовВводДанныхДляРасчетаЗарплаты_ВидыВремени
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ВидВремени", Comment = "", Synonym = "Вид времени")]
        public Catalogs.ВидыИспользованияРабочегоВремени ВидВремени {get; set;}
    }
    [Description1C8(Name = "ВидыРабот", Comment = "", Synonym = "Виды работ")]
    [Table("VydyDokumentovVvodDannykhDliaRaschetaZarplaty_VydyRabot")]
    public class ВидыДокументовВводДанныхДляРасчетаЗарплаты_ВидыРабот
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ВидРабот", Comment = "", Synonym = "Вид работ")]
        public Catalogs.ВидыРаботСотрудников ВидРабот {get; set;}
    }
    [Description1C8(Name = "ВнешниеПечатныеФормы", Comment = "", Synonym = "Внешние печатные формы")]
    [Table("VydyDokumentovVvodDannykhDliaRaschetaZarplaty_VneshnyePechatnyeFormy")]
    public class ВидыДокументовВводДанныхДляРасчетаЗарплаты_ВнешниеПечатныеФормы
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ПечатнаяФорма", Comment = "", Synonym = "Печатная форма")]
        public Catalogs.ДополнительныеОтчетыИОбработки ПечатнаяФорма {get; set;}
    }
}
