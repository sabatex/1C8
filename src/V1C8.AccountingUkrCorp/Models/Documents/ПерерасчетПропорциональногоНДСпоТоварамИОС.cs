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
    [Table("PereraschetProportsyonalnohoNDSpoTovaramYOS")]
    [Description1C8(Name = "ПерерасчетПропорциональногоНДСпоТоварамИОС", Comment = "(регл)", Synonym = "Перерасчет пропорционального НДС по товарам и ОС")]
    public class ПерерасчетПропорциональногоНДСпоТоварамИОС:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "(Общ)", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "(Общ)", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "СчетДт", Comment = "(Регл)", Synonym = "Счет списания")]
        public ПланСчетов.Хозрасчетный СчетДт {get; set;}
        [Description1C8(Name = "СубконтоДт1", Comment = "(Регл)", Synonym = "Субконто дебета 1")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоДт1 {get; set;}
        [Description1C8(Name = "СубконтоДт2", Comment = "(Регл)", Synonym = "Субконто дебета 2")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоДт2 {get; set;}
        [Description1C8(Name = "СубконтоДт3", Comment = "(Регл)", Synonym = "Субконто дебета 3")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоДт3 {get; set;}
        [Description1C8(Name = "НалоговоеНазначениеДоходовИЗатрат", Comment = "", Synonym = "Налоговое назначение затрат")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначениеДоходовИЗатрат {get; set;}
        [Description1C8(Name = "СчетНДС", Comment = "(Регл)", Synonym = "Счет НДС")]
        public ПланСчетов.Хозрасчетный СчетНДС {get; set;}
        [Description1C8(Name = "СубконтоКт1", Comment = "(Регл)", Synonym = "Субконто 1")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоКт1 {get; set;}
        [Description1C8(Name = "СубконтоКт2", Comment = "(Регл)", Synonym = "Субконто 2")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоКт2 {get; set;}
        [Description1C8(Name = "СубконтоКт3", Comment = "(Регл)", Synonym = "Субконто 3")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоКт3 {get; set;}
        [Description1C8(Name = "РучнаяКорректировка", Comment = "", Synonym = "Ручная корректировка")]
        public bool РучнаяКорректировка {get; set;}
        [Description1C8(Name = "СуммаВсехОпераций", Comment = "", Synonym = "Сумма всех операций")]
        // Format 15.0
        public long СуммаВсехОпераций {get; set;}
        [Description1C8(Name = "СуммаОблагаемыхОпераций", Comment = "", Synonym = "Сумма облагаемых операций")]
        // Format 15.0
        public long СуммаОблагаемыхОпераций {get; set;}
        [Description1C8(Name = "Коэффициент", Comment = "в процентах", Synonym = "Доля использования (%)")]
        // Format 6.2
        public decimal Коэффициент {get; set;}
        [Description1C8(Name = "СуммаПоставки", Comment = "", Synonym = "Сумма поставки (без НДС)")]
        // Format 15.2
        public decimal СуммаПоставки {get; set;}
        [Description1C8(Name = "НДСПоставки", Comment = "", Synonym = "НДС поставки")]
        // Format 15.2
        public decimal НДСПоставки {get; set;}
        [Description1C8(Name = "НДСПропорциональноКредитДоПерерасчета", Comment = "", Synonym = "НДС пропорционально включен в кредит")]
        // Format 15.2
        public decimal НДСПропорциональноКредитДоПерерасчета {get; set;}
        [Description1C8(Name = "НДСПропорциональноКредит", Comment = "", Synonym = "НДС пропорционально перерасчитанный")]
        // Format 15.2
        public decimal НДСПропорциональноКредит {get; set;}
        [Description1C8(Name = "СуммаКорректировкиНДС", Comment = "", Synonym = "Сумма корректировки кредита")]
        // Format 15.2
        public decimal СуммаКорректировкиНДС {get; set;}
        [Description1C8(Name = "СуммаКорректировкиНДСПоАвансамПоставщикамИОС", Comment = "", Synonym = "Корректировка НДС, учтенная в активах")]
        // Format 15.2
        public decimal СуммаКорректировкиНДСПоАвансамПоставщикамИОС {get; set;}
        [Description1C8(Name = "СуммаКорректировкиБУ", Comment = "", Synonym = "Сумма корректировки затрат (БУ)")]
        // Format 15.2
        public decimal СуммаКорректировкиБУ {get; set;}
        [Description1C8(Name = "СуммаКорректировкиНУ", Comment = "", Synonym = "Сумма корректировки затрат (НУ)")]
        // Format 15.2
        public decimal СуммаКорректировкиНУ {get; set;}
        [Description1C8(Name = "ФормироватьДокументУстановкиКоэффициентаНаСледующийГод", Comment = "", Synonym = "Формировать (перезаполнять) документ установки коэффициента пропорционального отнесения кредита по НДС на следующий год")]
        public bool ФормироватьДокументУстановкиКоэффициентаНаСледующийГод {get; set;}
        [Description1C8(Name = "УдалитьПересчетКредитаПоТоварам", Comment = "", Synonym = "(не используется) Пересчет кредита по товарам (услугам)")]
        public bool УдалитьПересчетКредитаПоТоварам {get; set;}
        [Description1C8(Name = "СчетКорректировкиНДС", Comment = "(Регл)", Synonym = "Счет корректировки НДС")]
        public ПланСчетов.Хозрасчетный СчетКорректировкиНДС {get; set;}
        [Description1C8(Name = "СтатьяОС", Comment = "", Synonym = "Статья затрат по пересчету амортизации ОС")]
        public Catalogs.СтатьиЗатрат СтатьяОС {get; set;}
        [Description1C8(Name = "СтатьяНМА", Comment = "", Synonym = "Статья затрат по пересчету амортизации НМА")]
        public Catalogs.СтатьиЗатрат СтатьяНМА {get; set;}
        [Description1C8(Name = "СтатьяМНМА", Comment = "", Synonym = "Статья затрат по пересчету амортизации МНМА")]
        public Catalogs.СтатьиЗатрат СтатьяМНМА {get; set;}
        [Description1C8(Name = "СпецРежимНалогообложения", Comment = "", Synonym = "Спец режим налогообложения")]
        // Format 1.0
        public long СпецРежимНалогообложения {get; set;}
        [Description1C8(Name = "СуммаВсехОпераций2года", Comment = "", Synonym = "Сумма всех операций за 2 года")]
        // Format 15.0
        public long СуммаВсехОпераций2года {get; set;}
        [Description1C8(Name = "СуммаВсехОпераций3Года", Comment = "", Synonym = "Сумма всех операций за 3 года")]
        // Format 15.0
        public long СуммаВсехОпераций3Года {get; set;}
        [Description1C8(Name = "СуммаОблагаемыхОпераций2Года", Comment = "", Synonym = "Сумма облагаемых операций за 2 года")]
        // Format 15.0
        public long СуммаОблагаемыхОпераций2Года {get; set;}
        [Description1C8(Name = "СуммаОблагаемыхОпераций3Года", Comment = "", Synonym = "Сумма облагаемых операций за 3 года")]
        // Format 15.0
        public long СуммаОблагаемыхОпераций3Года {get; set;}
        [Description1C8(Name = "Коэффициент2Года", Comment = "в процентах", Synonym = "Доля использования (%) за 2 года")]
        // Format 6.2
        public decimal Коэффициент2Года {get; set;}
        [Description1C8(Name = "Коэффициент3Года", Comment = "в процентах", Synonym = "Доля использования (%) за 3 года")]
        // Format 6.2
        public decimal Коэффициент3Года {get; set;}
        [Description1C8(Name = "СчетНДСУсловнаяПродажа", Comment = "(Регл)", Synonym = "Счет НДС (условная продажа)")]
        public ПланСчетов.Хозрасчетный СчетНДСУсловнаяПродажа {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "АвансыПоставщикам", Comment = "", Synonym = "Авансы поставщикам")]
        public List<ПерерасчетПропорциональногоНДСпоТоварамИОС_АвансыПоставщикам> ПерерасчетПропорциональногоНДСпоТоварамИОСАвансыПоставщикам {get;set;}
        [Description1C8(Name = "ПараметрыПерерасчетаОС", Comment = "", Synonym = "Параметры перерасчета ОС")]
        public List<ПерерасчетПропорциональногоНДСпоТоварамИОС_ПараметрыПерерасчетаОС> ПерерасчетПропорциональногоНДСпоТоварамИОСПараметрыПерерасчетаОС {get;set;}
        [Description1C8(Name = "Остатки15Счета", Comment = "", Synonym = "Остатки счета 15")]
        public List<ПерерасчетПропорциональногоНДСпоТоварамИОС_Остатки15Счета> ПерерасчетПропорциональногоНДСпоТоварамИОСОстатки15Счета {get;set;}
        [Description1C8(Name = "НалоговыеДокументы", Comment = "", Synonym = "Налоговые документы")]
        public List<ПерерасчетПропорциональногоНДСпоТоварамИОС_НалоговыеДокументы> ПерерасчетПропорциональногоНДСпоТоварамИОСНалоговыеДокументы {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "АвансыПоставщикам", Comment = "", Synonym = "Авансы поставщикам")]
    [Table("PereraschetProportsyonalnohoNDSpoTovaramYOS_AvansyPostavshchykam")]
    public class ПерерасчетПропорциональногоНДСпоТоварамИОС_АвансыПоставщикам
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Контрагент", Comment = "(Общ)", Synonym = "Контрагент")]
        public Catalogs.Контрагенты Контрагент {get; set;}
        [Description1C8(Name = "ДоговорКонтрагента", Comment = "", Synonym = "Договор контрагента")]
        public Catalogs.ДоговорыКонтрагентов ДоговорКонтрагента {get; set;}
        [Description1C8(Name = "Сделка", Comment = "(Общ)", Synonym = "Документ расчетов")]
        public Documents.ПлатежныйОрдерСписаниеДенежныхСредств Сделка {get; set;}
        [Description1C8(Name = "РасчетыВозврат", Comment = "(Нал)", Synonym = "Расчеты возврат")]
        public Enums.РасчетыВозврат РасчетыВозврат {get; set;}
        [Description1C8(Name = "СтавкаНДС", Comment = "", Synonym = "% НДС")]
        public Enums.СтавкиНДС СтавкаНДС {get; set;}
        [Description1C8(Name = "СуммаАванса", Comment = "", Synonym = "Сумма аванса")]
        // Format 15.2
        public decimal СуммаАванса {get; set;}
        [Description1C8(Name = "НДСПоставки", Comment = "", Synonym = "НДС поставки")]
        // Format 15.2
        public decimal НДСПоставки {get; set;}
        [Description1C8(Name = "НДСПропорциональноКредитДоПерерасчета", Comment = "", Synonym = "НДС пропорционально включен в кредит")]
        // Format 15.2
        public decimal НДСПропорциональноКредитДоПерерасчета {get; set;}
        [Description1C8(Name = "НДСПропорциональноКредит", Comment = "", Synonym = "НДС пропорционально перерасчитанный")]
        // Format 15.2
        public decimal НДСПропорциональноКредит {get; set;}
        [Description1C8(Name = "СуммаКорректировкиНДС", Comment = "", Synonym = "Сумма корректировки кредита")]
        // Format 15.2
        public decimal СуммаКорректировкиНДС {get; set;}
        [Description1C8(Name = "СчетУчетаНДС", Comment = "", Synonym = "Счет НДС по договору")]
        public ПланСчетов.Хозрасчетный СчетУчетаНДС {get; set;}
        [Description1C8(Name = "Амортизируется", Comment = "", Synonym = "Амортизируется")]
        public bool Амортизируется {get; set;}
    }
    [Description1C8(Name = "ПараметрыПерерасчетаОС", Comment = "", Synonym = "Параметры перерасчета ОС")]
    [Table("PereraschetProportsyonalnohoNDSpoTovaramYOS_ParametryPereraschetaOS")]
    public class ПерерасчетПропорциональногоНДСпоТоварамИОС_ПараметрыПерерасчетаОС
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "НеоборотныйАктив", Comment = "", Synonym = "Необоротный актив")]
        public Catalogs.ОсновныеСредства НеоборотныйАктив {get; set;}
        [Description1C8(Name = "ДатаНачалаИспользования", Comment = "", Synonym = "Дата начала использования")]
        public DateTime ДатаНачалаИспользования {get; set;}
        [Description1C8(Name = "ДатаФормированияКредита", Comment = "", Synonym = "Дата формирования кредита")]
        public DateTime ДатаФормированияКредита {get; set;}
        [Description1C8(Name = "СуммаВсехОпераций", Comment = "", Synonym = "Сумма всех операций")]
        // Format 15.2
        public decimal СуммаВсехОпераций {get; set;}
        [Description1C8(Name = "СуммаОблагаемыхОпераций", Comment = "", Synonym = "Сумма облагаемых операций")]
        // Format 15.2
        public decimal СуммаОблагаемыхОпераций {get; set;}
        [Description1C8(Name = "Коэффициент", Comment = "в процентах", Synonym = "Доля использования")]
        // Format 6.2
        public decimal Коэффициент {get; set;}
        [Description1C8(Name = "СуммаПоставки", Comment = "", Synonym = "Сумма поставки (без НДС)")]
        // Format 15.2
        public decimal СуммаПоставки {get; set;}
        [Description1C8(Name = "НДСПоставки", Comment = "", Synonym = "НДС поставки")]
        // Format 15.2
        public decimal НДСПоставки {get; set;}
        [Description1C8(Name = "НДСПропорциональноКредитДоПерерасчета", Comment = "", Synonym = "НДС пропорционально включен в кредит")]
        // Format 15.2
        public decimal НДСПропорциональноКредитДоПерерасчета {get; set;}
        [Description1C8(Name = "НДСПропорциональноКредит", Comment = "", Synonym = "НДС пропорционально перерасчитанный")]
        // Format 15.2
        public decimal НДСПропорциональноКредит {get; set;}
        [Description1C8(Name = "СуммаКорректировкиНДС", Comment = "", Synonym = "Сумма корректировки кредита")]
        // Format 15.2
        public decimal СуммаКорректировкиНДС {get; set;}
        [Description1C8(Name = "СуммаКорректировкиБУ", Comment = "", Synonym = "Сумма корректировки затрат (БУ)")]
        // Format 15.2
        public decimal СуммаКорректировкиБУ {get; set;}
        [Description1C8(Name = "СуммаКорректировкиНУ", Comment = "", Synonym = "Сумма корректировки затрат (НУ)")]
        // Format 15.2
        public decimal СуммаКорректировкиНУ {get; set;}
        [Description1C8(Name = "СтоимостьНУ", Comment = "(Регл)", Synonym = "Стоимость (НУ)")]
        // Format 15.2
        public decimal СтоимостьНУ {get; set;}
        [Description1C8(Name = "СтоимостьБУ", Comment = "(Регл)", Synonym = "Стоимость (БУ)")]
        // Format 15.2
        public decimal СтоимостьБУ {get; set;}
        [Description1C8(Name = "АмортизацияБУ", Comment = "(Регл)", Synonym = "Амортизация (БУ)")]
        // Format 15.2
        public decimal АмортизацияБУ {get; set;}
        [Description1C8(Name = "АмортизацияНУ", Comment = "(Регл)", Synonym = "Амортизация (НУ)")]
        // Format 15.2
        public decimal АмортизацияНУ {get; set;}
        [Description1C8(Name = "ОССписан", Comment = "", Synonym = "Списан")]
        public bool ОССписан {get; set;}
    }
    [Description1C8(Name = "Остатки15Счета", Comment = "", Synonym = "Остатки счета 15")]
    [Table("PereraschetProportsyonalnohoNDSpoTovaramYOS_Ostatky15Scheta")]
    public class ПерерасчетПропорциональногоНДСпоТоварамИОС_Остатки15Счета
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Счет", Comment = "", Synonym = "Счет")]
        public ПланСчетов.Хозрасчетный Счет {get; set;}
        [Description1C8(Name = "НеоборотныйАктив", Comment = "", Synonym = "Необоротный актив")]
        public Catalogs.БиологическиеАктивы НеоборотныйАктив {get; set;}
        [Description1C8(Name = "НоменклатурнаяПозиция", Comment = "", Synonym = "Номенклатурная позиция")]
        [StringLength(1)]
        public string НоменклатурнаяПозиция {get; set;}
        [Description1C8(Name = "Склад", Comment = "", Synonym = "Склад")]
        public Catalogs.Склады Склад {get; set;}
        [Description1C8(Name = "Партия", Comment = "", Synonym = "Документ поступления")]
        public Documents.СторнированиеНачислений Партия {get; set;}
        [Description1C8(Name = "Коэффициент", Comment = "в процентах", Synonym = "Доля использования")]
        // Format 6.2
        public decimal Коэффициент {get; set;}
        [Description1C8(Name = "СуммаОстаток", Comment = "", Synonym = "Сумма (включая пропорц. НДС)")]
        // Format 15.2
        public decimal СуммаОстаток {get; set;}
        [Description1C8(Name = "СуммаПоставки", Comment = "", Synonym = "Сумма поставки (без НДС)")]
        // Format 15.2
        public decimal СуммаПоставки {get; set;}
        [Description1C8(Name = "НДСПоставки", Comment = "", Synonym = "НДС поставки")]
        // Format 15.2
        public decimal НДСПоставки {get; set;}
        [Description1C8(Name = "НДСПропорциональноКредитДоПерерасчета", Comment = "", Synonym = "НДС пропорционально включен в кредит")]
        // Format 15.2
        public decimal НДСПропорциональноКредитДоПерерасчета {get; set;}
        [Description1C8(Name = "НДСПропорциональноКредит", Comment = "", Synonym = "НДС пропорционально перерасчитанный")]
        // Format 15.2
        public decimal НДСПропорциональноКредит {get; set;}
        [Description1C8(Name = "СуммаКорректировкиНДС", Comment = "", Synonym = "Сумма корректировки кредита")]
        // Format 15.2
        public decimal СуммаКорректировкиНДС {get; set;}
        [Description1C8(Name = "КорректироватьПоНУ", Comment = "", Synonym = "Корректировать по НУ")]
        public bool КорректироватьПоНУ {get; set;}
    }
    [Description1C8(Name = "НалоговыеДокументы", Comment = "", Synonym = "Налоговые документы")]
    [Table("PereraschetProportsyonalnohoNDSpoTovaramYOS_NalohovyeDokumenty")]
    public class ПерерасчетПропорциональногоНДСпоТоварамИОС_НалоговыеДокументы
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Период", Comment = "", Synonym = "Период")]
        public DateTime Период {get; set;}
        [Description1C8(Name = "НН", Comment = "", Synonym = "Сводная налоговая накладная на усл. продажу за период")]
        public Documents.НалоговаяНакладная НН {get; set;}
        [Description1C8(Name = "П2", Comment = "", Synonym = "Корректировка к Сводной налоговой накладной")]
        public Documents.Приложение2КНалоговойНакладной П2 {get; set;}
    }
}
