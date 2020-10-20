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
    [Table("PrykhodnyiKassovyiOrder")]
    [Description1C8(Name = "ПриходныйКассовыйОрдер", Comment = "(Общ)", Synonym = "Приходный кассовый ордер")]
    public class ПриходныйКассовыйОрдер:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "ВидОперации", Comment = "", Synonym = "Вид операции")]
        public Enums.ВидыОперацийПКО ВидОперации {get; set;}
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "СуммаДокумента", Comment = "Сумма в валюте документа, налоги включены согласно флагам", Synonym = "Сумма")]
        // Format 15.2
        public decimal СуммаДокумента {get; set;}
        [Description1C8(Name = "ВалютаДокумента", Comment = "(Общ)", Synonym = "Валюта")]
        public Catalogs.Валюты ВалютаДокумента {get; set;}
        [Description1C8(Name = "СчетКасса", Comment = "(бух)", Synonym = "Счет учета")]
        public ПланСчетов.Хозрасчетный СчетКасса {get; set;}
        [Description1C8(Name = "Контрагент", Comment = "(Общ)", Synonym = "Плательщик")]
        public Catalogs.Склады Контрагент {get; set;}
        [Description1C8(Name = "ВыручкаСНТТ", Comment = "", Synonym = "Неавтоматизированная торговая точка")]
        public bool ВыручкаСНТТ {get; set;}
        [Description1C8(Name = "СчетУчетаРасчетовСКонтрагентом", Comment = "", Synonym = "Счет расчетов")]
        public ПланСчетов.Хозрасчетный СчетУчетаРасчетовСКонтрагентом {get; set;}
        [Description1C8(Name = "СубконтоКт1", Comment = "(Регл)", Synonym = "Субконто Кт1")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоКт1 {get; set;}
        [Description1C8(Name = "СубконтоКт2", Comment = "(Регл)", Synonym = "Субконто Кт2")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоКт2 {get; set;}
        [Description1C8(Name = "СубконтоКт3", Comment = "(Регл)", Synonym = "Субконто Кт3")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоКт3 {get; set;}
        [Description1C8(Name = "ПринятоОт", Comment = "(Общ)", Synonym = "Принято от")]
        [StringLength(250)]
        public string ПринятоОт {get; set;}
        [Description1C8(Name = "Основание", Comment = "(Общ)", Synonym = "Основание")]
        [StringLength(250)]
        public string Основание {get; set;}
        [Description1C8(Name = "Приложение", Comment = "(Общ)", Synonym = "Приложение")]
        [StringLength(250)]
        public string Приложение {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "(Общ)", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "ДоговорКонтрагента", Comment = "(Общ)", Synonym = "Договор")]
        public Catalogs.ДоговорыКонтрагентов ДоговорКонтрагента {get; set;}
        [Description1C8(Name = "ДокументОснование", Comment = "(Общ)", Synonym = "Документ основание")]
        public Документ.ПередачаОС ДокументОснование {get; set;}
        [Description1C8(Name = "СчетОрганизации", Comment = "(Регл) Банковский счет организации", Synonym = "Счет организации")]
        public Catalogs.БанковскиеСчета СчетОрганизации {get; set;}
        [Description1C8(Name = "СтатьяДвиженияДенежныхСредств", Comment = "(Регл)", Synonym = "Статья движения ден.средств")]
        public Catalogs.СтатьиДвиженияДенежныхСредств СтатьяДвиженияДенежныхСредств {get; set;}
        [Description1C8(Name = "СтавкаНДС", Comment = "(Общ)", Synonym = "% НДС")]
        public Enums.СтавкиНДС СтавкаНДС {get; set;}
        [Description1C8(Name = "НомерОрдера", Comment = "(Регл)", Synonym = "Номер ордера")]
        [StringLength(10)]
        public string НомерОрдера {get; set;}
        [Description1C8(Name = "НазначениеДенежныхСредств", Comment = "(Регл)", Synonym = "Назначение денежных средств")]
        public Catalogs.НазначенияНаличныхДенежныхСредств НазначениеДенежныхСредств {get; set;}
        [Description1C8(Name = "СчетВычетаИзДоходовРозничныхПродаж", Comment = "(Регл)", Synonym = "Счет вычета из доходов розничных продаж")]
        public ПланСчетов.Хозрасчетный СчетВычетаИзДоходовРозничныхПродаж {get; set;}
        [Description1C8(Name = "СтатьяДоходов", Comment = "(Регл)", Synonym = "Статья доходов")]
        public Catalogs.СтатьиДоходов СтатьяДоходов {get; set;}
        [Description1C8(Name = "СуммаПродаж", Comment = "(Общ) Сумма в валюте документа, налоги включены согласно флагам", Synonym = "Сумма продаж")]
        // Format 15.2
        public decimal СуммаПродаж {get; set;}
        [Description1C8(Name = "СуммаВозврата", Comment = "(Общ) Сумма в валюте документа, налоги включены согласно флагам", Synonym = "Сумма возврата")]
        // Format 15.2
        public decimal СуммаВозврата {get; set;}
        [Description1C8(Name = "СтатьяДекларацииПоЕдиномуНалогу", Comment = "(Регл)", Synonym = "Ст. декл. по ед. налогу")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяДекларацииПоЕдиномуНалогу {get; set;}
        [Description1C8(Name = "ОбособленноеПодразделениеОрганизации", Comment = "", Synonym = "Обособленное подразделение организации")]
        public Catalogs.ОбособленныеПодразделенияОрганизаций ОбособленноеПодразделениеОрганизации {get; set;}
        [Description1C8(Name = "ПоОбособленномуПодразделению", Comment = "", Synonym = "По обособленному подразделению")]
        public bool ПоОбособленномуПодразделению {get; set;}
        [Description1C8(Name = "НалоговоеНазначениеПриПрочемПоступлении", Comment = "", Synonym = "Налоговое назначение при прочем поступлении")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначениеПриПрочемПоступлении {get; set;}
        [Description1C8(Name = "РучнаяКорректировка", Comment = "", Synonym = "Ручная корректировка")]
        public bool РучнаяКорректировка {get; set;}
        [Description1C8(Name = "СуммаБезналичнойОплаты", Comment = "", Synonym = "Сумма безналичной оплаты")]
        // Format 15.2
        public decimal СуммаБезналичнойОплаты {get; set;}
        [Description1C8(Name = "ВыводитьНаПечатьСуммуНДС", Comment = "", Synonym = "Выводить на печать сумму НДС")]
        public bool ВыводитьНаПечатьСуммуНДС {get; set;}
        [Description1C8(Name = "СчетУчетаАкцизногоНалога", Comment = "", Synonym = "Счет акциза")]
        public ПланСчетов.Хозрасчетный СчетУчетаАкцизногоНалога {get; set;}
        [Description1C8(Name = "ДоговорЗаймаСотруднику", Comment = "", Synonym = "Договор займа сотруднику")]
        public Документ.ДоговорЗаймаСотруднику ДоговорЗаймаСотруднику {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "РасшифровкаПлатежа", Comment = "(Общ)", Synonym = "Расшифровка платежа")]
        public List<ПриходныйКассовыйОрдер_РасшифровкаПлатежа> ПриходныйКассовыйОрдерРасшифровкаПлатежа {get;set;}
        [Description1C8(Name = "ПриемРозничнойВыручки", Comment = "(Общ)", Synonym = "Прием розничной выручки")]
        public List<ПриходныйКассовыйОрдер_ПриемРозничнойВыручки> ПриходныйКассовыйОрдерПриемРозничнойВыручки {get;set;}
        [Description1C8(Name = "Оплата", Comment = "", Synonym = "Оплата")]
        public List<ПриходныйКассовыйОрдер_Оплата> ПриходныйКассовыйОрдерОплата {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "РасшифровкаПлатежа", Comment = "(Общ)", Synonym = "Расшифровка платежа")]
    [Table("PrykhodnyiKassovyiOrder_RasshyfrovkaPlatezha")]
    public class ПриходныйКассовыйОрдер_РасшифровкаПлатежа
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ДоговорКонтрагента", Comment = "(Общ)", Synonym = "Договор")]
        public Catalogs.ДоговорыКонтрагентов ДоговорКонтрагента {get; set;}
        [Description1C8(Name = "Сделка", Comment = "(Общ)", Synonym = "Документ расчетов")]
        public Документ.ПлатежныйОрдерСписаниеДенежныхСредств Сделка {get; set;}
        [Description1C8(Name = "СуммаПлатежа", Comment = "(Общ)", Synonym = "Сумма")]
        // Format 15.2
        public decimal СуммаПлатежа {get; set;}
        [Description1C8(Name = "КурсВзаиморасчетов", Comment = "(Общ) Курс валюты взаиморасчетов по договору или валюты взаиморасчетов с подотчетником", Synonym = "Курс")]
        // Format 10.4
        public decimal КурсВзаиморасчетов {get; set;}
        [Description1C8(Name = "СуммаВзаиморасчетов", Comment = "(Общ)", Synonym = "Сумма взаиморасчетов")]
        // Format 15.2
        public decimal СуммаВзаиморасчетов {get; set;}
        [Description1C8(Name = "СтавкаНДС", Comment = "(Общ)", Synonym = "% НДС")]
        public Enums.СтавкиНДС СтавкаНДС {get; set;}
        [Description1C8(Name = "СуммаНДС", Comment = "(Общ)", Synonym = "Сумма НДС")]
        // Format 15.2
        public decimal СуммаНДС {get; set;}
        [Description1C8(Name = "СтатьяДвиженияДенежныхСредств", Comment = "(Регл)", Synonym = "Статья движения денежных средств")]
        public Catalogs.СтатьиДвиженияДенежныхСредств СтатьяДвиженияДенежныхСредств {get; set;}
        [Description1C8(Name = "СчетУчетаРасчетовСКонтрагентом", Comment = "(Регл)", Synonym = "Счет расчетов")]
        public ПланСчетов.Хозрасчетный СчетУчетаРасчетовСКонтрагентом {get; set;}
        [Description1C8(Name = "СчетУчетаРасчетовПоАвансам", Comment = "(Регл)", Synonym = "Счет авансов")]
        public ПланСчетов.Хозрасчетный СчетУчетаРасчетовПоАвансам {get; set;}
        [Description1C8(Name = "КратностьВзаиморасчетов", Comment = "(Общ)", Synonym = "Кратность взаиморасчетов")]
        // Format 10.0
        public long КратностьВзаиморасчетов {get; set;}
        [Description1C8(Name = "ЗаТару", Comment = "", Synonym = "Тара")]
        public bool ЗаТару {get; set;}
        [Description1C8(Name = "СтатьяДекларацииПоЕдиномуНалогу", Comment = "(Регл)", Synonym = "Ст. декл. по ед. налогу")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяДекларацииПоЕдиномуНалогу {get; set;}
        [Description1C8(Name = "ДокументПередачиОС", Comment = "(Регл)", Synonym = "Документ передачи ОС")]
        public Документ.ПередачаОС ДокументПередачиОС {get; set;}
        [Description1C8(Name = "ОстаточнаяСтоимостьОС", Comment = "(Регл)", Synonym = "Остаточная стоимость основных средств")]
        // Format 15.2
        public decimal ОстаточнаяСтоимостьОС {get; set;}
        [Description1C8(Name = "СчетУчетаНДС", Comment = "(Регл)", Synonym = "Счет НДС")]
        public ПланСчетов.Хозрасчетный СчетУчетаНДС {get; set;}
        [Description1C8(Name = "СчетУчетаНДСПодтвержденный", Comment = "", Synonym = "Счет НДС подтв.")]
        public ПланСчетов.Хозрасчетный СчетУчетаНДСПодтвержденный {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        [Description1C8(Name = "СуммаНДСПропорциональноКредит", Comment = "", Synonym = "Сумма НДС (проп.)")]
        // Format 15.2
        public decimal СуммаНДСПропорциональноКредит {get; set;}
        [Description1C8(Name = "Амортизируется", Comment = "Поставка Основных фондов. Используется для запонения Приложения 5 к Декларации по НДС (с 2008 г) только для приобретения", Synonym = "ОФ")]
        public bool Амортизируется {get; set;}
        [Description1C8(Name = "ВозвратАвансаДо01042011НУ", Comment = "", Synonym = "Аванс до НКУ")]
        public bool ВозвратАвансаДо01042011НУ {get; set;}
        [Description1C8(Name = "СтатьяПоВозвратуАвансаДо2011НУ", Comment = "", Synonym = "Статья по возврату аванса (НУ)")]
        public Catalogs.СтатьиДоходов СтатьяПоВозвратуАвансаДо2011НУ {get; set;}
        [Description1C8(Name = "СуммаВДВРПоАвансуДо01042011", Comment = "", Synonym = "Сумма ВР до НКУ")]
        // Format 15.2
        public decimal СуммаВДВРПоАвансуДо01042011 {get; set;}
    }
    [Description1C8(Name = "ПриемРозничнойВыручки", Comment = "(Общ)", Synonym = "Прием розничной выручки")]
    [Table("PrykhodnyiKassovyiOrder_PryemRoznychnoiVyruchky")]
    public class ПриходныйКассовыйОрдер_ПриемРозничнойВыручки
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Возврат", Comment = "", Synonym = "Возврат")]
        public bool Возврат {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "СтавкаНДС", Comment = "", Synonym = "% НДС")]
        public Enums.СтавкиНДС СтавкаНДС {get; set;}
        [Description1C8(Name = "СуммаНДС", Comment = "(Общ)", Synonym = "Сумма НДС")]
        // Format 15.2
        public decimal СуммаНДС {get; set;}
        [Description1C8(Name = "СчетУчетаНДС", Comment = "", Synonym = "Счет НДС")]
        public ПланСчетов.Хозрасчетный СчетУчетаНДС {get; set;}
        [Description1C8(Name = "СхемаРеализации", Comment = "", Synonym = "Схема реализации")]
        public Catalogs.СхемыРеализации СхемаРеализации {get; set;}
        [Description1C8(Name = "НоменклатурнаяГруппа", Comment = "(Общ)", Synonym = "Номенклатурная группа")]
        public Catalogs.НоменклатурныеГруппы НоменклатурнаяГруппа {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        [Description1C8(Name = "НалоговоеНазначениеДоходовИЗатрат", Comment = "", Synonym = "Налоговое назначение доходов и затрат")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначениеДоходовИЗатрат {get; set;}
        [Description1C8(Name = "СтатьяДекларацииПоАкцизномуНалогу", Comment = "", Synonym = "Ст. дек. акцизного налога")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяДекларацииПоАкцизномуНалогу {get; set;}
        [Description1C8(Name = "СуммаАкцизногоНалога", Comment = "(Общ)", Synonym = "Сумма акциза")]
        // Format 15.2
        public decimal СуммаАкцизногоНалога {get; set;}
        [Description1C8(Name = "ПодакцизныеТоварыДляКоммерческогоИспользования", Comment = "", Synonym = "Для комм. использования")]
        public bool ПодакцизныеТоварыДляКоммерческогоИспользования {get; set;}
    }
    [Description1C8(Name = "Оплата", Comment = "", Synonym = "Оплата")]
    [Table("PrykhodnyiKassovyiOrder_Oplata")]
    public class ПриходныйКассовыйОрдер_Оплата
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ВидОплаты", Comment = "", Synonym = "Вид оплаты")]
        public Catalogs.ВидыОплатОрганизаций ВидОплаты {get; set;}
        [Description1C8(Name = "Контрагент", Comment = "", Synonym = "Контрагент")]
        public Catalogs.Контрагенты Контрагент {get; set;}
        [Description1C8(Name = "ДоговорКонтрагента", Comment = "", Synonym = "Договор")]
        public Catalogs.ДоговорыКонтрагентов ДоговорКонтрагента {get; set;}
        [Description1C8(Name = "СчетДеньгиВПути", Comment = "", Synonym = "Счет деньги в пути")]
        public ПланСчетов.Хозрасчетный СчетДеньгиВПути {get; set;}
        [Description1C8(Name = "СуммаОплаты", Comment = "", Synonym = "Сумма оплаты")]
        // Format 15.2
        public decimal СуммаОплаты {get; set;}
    }
}
