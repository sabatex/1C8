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
    [Table("OtchetORoznychnykhProdazhakh")]
    [Description1C8(Name = "ОтчетОРозничныхПродажах", Comment = "(Общ)", Synonym = "Отчет о розничных продажах")]
    public class ОтчетОРозничныхПродажах:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "ВидОперации", Comment = "", Synonym = "Вид операции")]
        public Enums.ВидыОперацийОтчетОРозничныхПродажах ВидОперации {get; set;}
        [Description1C8(Name = "Организация", Comment = "(Общ)", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "ИнвентаризацияТоваровНаСкладе", Comment = "(Общ)", Synonym = "Инвентаризация товаров на складе")]
        public Документ.ИнвентаризацияТоваровНаСкладе ИнвентаризацияТоваровНаСкладе {get; set;}
        [Description1C8(Name = "СчетКасса", Comment = "", Synonym = "Счет касса")]
        public ПланСчетов.Хозрасчетный СчетКасса {get; set;}
        [Description1C8(Name = "Склад", Comment = "(Общ)", Synonym = "Склад")]
        public Catalogs.Склады Склад {get; set;}
        [Description1C8(Name = "СтатьяДвиженияДенежныхСредств", Comment = "", Synonym = "Статья движения денежных средств")]
        public Catalogs.СтатьиДвиженияДенежныхСредств СтатьяДвиженияДенежныхСредств {get; set;}
        [Description1C8(Name = "ВалютаДокумента", Comment = "(Общ) Всегда гривня", Synonym = "Валюта")]
        public Catalogs.Валюты ВалютаДокумента {get; set;}
        [Description1C8(Name = "КурсДокумента", Comment = "", Synonym = "Курс документа")]
        // Format 10.4
        public decimal КурсДокумента {get; set;}
        [Description1C8(Name = "КратностьДокумента", Comment = "", Synonym = "Кратность документа")]
        // Format 10.0
        public long КратностьДокумента {get; set;}
        [Description1C8(Name = "СуммаДокумента", Comment = "(Общ) Сумма в валюте документа, налоги включены согласно флагам", Synonym = "Сумма")]
        // Format 15.2
        public decimal СуммаДокумента {get; set;}
        [Description1C8(Name = "ТипЦен", Comment = "(Общ)", Synonym = "Тип цен")]
        public Catalogs.ТипыЦенНоменклатуры ТипЦен {get; set;}
        [Description1C8(Name = "СуммаВключаетНДС", Comment = "(Общ)", Synonym = "Сумма включает НДС")]
        public bool СуммаВключаетНДС {get; set;}
        [Description1C8(Name = "УдалитьУчитыватьНДС", Comment = "(Общ)", Synonym = "(не используется) Учитывать НДС")]
        public bool УдалитьУчитыватьНДС {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "(Общ)", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "СчетДоходовРозничныхПродаж", Comment = "(Регл)", Synonym = "Счет доходов от розничных продаж")]
        public ПланСчетов.Хозрасчетный СчетДоходовРозничныхПродаж {get; set;}
        [Description1C8(Name = "СчетВычетаИзДоходовРозничныхПродаж", Comment = "(Регл)", Synonym = "Счет вычета из доходов розничных продаж")]
        public ПланСчетов.Хозрасчетный СчетВычетаИзДоходовРозничныхПродаж {get; set;}
        [Description1C8(Name = "АвторасчетНДС", Comment = "", Synonym = "Авторасчет НДС")]
        public bool АвторасчетНДС {get; set;}
        [Description1C8(Name = "СтатьяДекларацииПоЕдиномуНалогу", Comment = "(Регл)", Synonym = "Ст. декл. по ед. налогу")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяДекларацииПоЕдиномуНалогу {get; set;}
        [Description1C8(Name = "ОбособленноеПодразделениеОрганизации", Comment = "", Synonym = "Обособленное подразделение организации")]
        public Catalogs.ОбособленныеПодразделенияОрганизаций ОбособленноеПодразделениеОрганизации {get; set;}
        [Description1C8(Name = "ПоОбособленномуПодразделению", Comment = "", Synonym = "По обособленному подразделению")]
        public bool ПоОбособленномуПодразделению {get; set;}
        [Description1C8(Name = "РучнаяКорректировка", Comment = "", Synonym = "Ручная корректировка")]
        public bool РучнаяКорректировка {get; set;}
        [Description1C8(Name = "СчетУчетаНДС", Comment = "(Регл)", Synonym = "Счет НДС")]
        public ПланСчетов.Хозрасчетный СчетУчетаНДС {get; set;}
        [Description1C8(Name = "СчетУчетаАкцизногоНалога", Comment = "", Synonym = "Счет акциза")]
        public ПланСчетов.Хозрасчетный СчетУчетаАкцизногоНалога {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Товары", Comment = "(Общ)", Synonym = "Товары")]
        public List<ОтчетОРозничныхПродажах_Товары> ОтчетОРозничныхПродажахТовары {get;set;}
        [Description1C8(Name = "Оплата", Comment = "", Synonym = "Оплата")]
        public List<ОтчетОРозничныхПродажах_Оплата> ОтчетОРозничныхПродажахОплата {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Товары", Comment = "(Общ)", Synonym = "Товары")]
    [Table("OtchetORoznychnykhProdazhakh_Tovary")]
    public class ОтчетОРозничныхПродажах_Товары
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Номенклатура", Comment = "(Общ)", Synonym = "Номенклатура")]
        public Catalogs.Номенклатура Номенклатура {get; set;}
        [Description1C8(Name = "ЕдиницаИзмерения", Comment = "(Общ)", Synonym = "Единица измерения")]
        public Catalogs.КлассификаторЕдиницИзмерения ЕдиницаИзмерения {get; set;}
        [Description1C8(Name = "Коэффициент", Comment = "(Общ)", Synonym = "Коэффициент")]
        // Format 10.3
        public decimal Коэффициент {get; set;}
        [Description1C8(Name = "Количество", Comment = "(Общ)", Synonym = "Количество")]
        // Format 15.3
        public decimal Количество {get; set;}
        [Description1C8(Name = "Цена", Comment = "(Общ)", Synonym = "Цена")]
        // Format 15.2
        public decimal Цена {get; set;}
        [Description1C8(Name = "Сумма", Comment = "(Общ)", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "СтавкаНДС", Comment = "(Общ)", Synonym = "% НДС")]
        public Enums.СтавкиНДС СтавкаНДС {get; set;}
        [Description1C8(Name = "СуммаНДС", Comment = "(Общ)", Synonym = "Сумма НДС")]
        // Format 15.2
        public decimal СуммаНДС {get; set;}
        [Description1C8(Name = "СчетУчетаБУ", Comment = "(Регл)", Synonym = "Счет учета")]
        public ПланСчетов.Хозрасчетный СчетУчетаБУ {get; set;}
        [Description1C8(Name = "СхемаРеализации", Comment = "", Synonym = "Схема реализации")]
        public Catalogs.СхемыРеализации СхемаРеализации {get; set;}
        [Description1C8(Name = "ДокументПродажи", Comment = "", Synonym = "Документ продажи")]
        public Документ.ОтчетОРозничныхПродажах ДокументПродажи {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        [Description1C8(Name = "НалоговоеНазначениеДоходовИЗатрат", Comment = "", Synonym = "Налоговое назначение доходов и затрат")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначениеДоходовИЗатрат {get; set;}
        [Description1C8(Name = "ДокументОприходования", Comment = "", Synonym = "Документ оприходования")]
        public Документ.ОтчетПроизводстваЗаСмену ДокументОприходования {get; set;}
        [Description1C8(Name = "Себестоимость", Comment = "", Synonym = "Себестоимость")]
        // Format 15.2
        public decimal Себестоимость {get; set;}
        [Description1C8(Name = "СебестоимостьНУ", Comment = "", Synonym = "Себестоимость НУ")]
        // Format 15.2
        public decimal СебестоимостьНУ {get; set;}
        [Description1C8(Name = "СуммаБезСкидки", Comment = "(Общ)", Synonym = "Сумма без скидки")]
        // Format 15.2
        public decimal СуммаБезСкидки {get; set;}
        [Description1C8(Name = "СуммаСкидки", Comment = "(Общ)", Synonym = "Сумма скидки")]
        // Format 15.2
        public decimal СуммаСкидки {get; set;}
        [Description1C8(Name = "СтатьяДекларацииПоАкцизномуНалогу", Comment = "", Synonym = "Ст. дек. акцизного налога")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяДекларацииПоАкцизномуНалогу {get; set;}
        [Description1C8(Name = "СуммаАкцизногоНалога", Comment = "(Общ)", Synonym = "Сумма акциза")]
        // Format 15.2
        public decimal СуммаАкцизногоНалога {get; set;}
        [Description1C8(Name = "ПодакцизныеТоварыДляКоммерческогоИспользования", Comment = "", Synonym = "Для комм. использования")]
        public bool ПодакцизныеТоварыДляКоммерческогоИспользования {get; set;}
    }
    [Description1C8(Name = "Оплата", Comment = "", Synonym = "Оплата")]
    [Table("OtchetORoznychnykhProdazhakh_Oplata")]
    public class ОтчетОРозничныхПродажах_Оплата
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ВидОплаты", Comment = "", Synonym = "Вид оплаты")]
        public Catalogs.ВидыОплатОрганизаций ВидОплаты {get; set;}
        [Description1C8(Name = "Контрагент", Comment = "", Synonym = "Контрагент")]
        public Catalogs.Контрагенты Контрагент {get; set;}
        [Description1C8(Name = "ДоговорКонтрагента", Comment = "", Synonym = "Договор контрагента")]
        public Catalogs.ДоговорыКонтрагентов ДоговорКонтрагента {get; set;}
        [Description1C8(Name = "СчетДеньгиВПути", Comment = "", Synonym = "Счет деньги в пути")]
        public ПланСчетов.Хозрасчетный СчетДеньгиВПути {get; set;}
        [Description1C8(Name = "СуммаОплаты", Comment = "", Synonym = "Сумма оплаты")]
        // Format 15.2
        public decimal СуммаОплаты {get; set;}
    }
}
