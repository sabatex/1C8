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
    [Table("PostuplenyeTovarovUsluh")]
    [Description1C8(Name = "ПоступлениеТоваровУслуг", Comment = "(Общ)", Synonym = "Поступление товаров и услуг")]
    public class ПоступлениеТоваровУслуг:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "ВидОперации", Comment = "(Общ)", Synonym = "Вид операции")]
        public Enums.ВидыОперацийПоступлениеТоваровУслуг ВидОперации {get; set;}
        [Description1C8(Name = "Организация", Comment = "(Общ)", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Склад", Comment = "(Общ)", Synonym = "Склад")]
        public Catalogs.Склады Склад {get; set;}
        [Description1C8(Name = "Контрагент", Comment = "(Общ)", Synonym = "Контрагент")]
        public Catalogs.Контрагенты Контрагент {get; set;}
        [Description1C8(Name = "ДоговорКонтрагента", Comment = "(Общ)", Synonym = "Договор")]
        public Catalogs.ДоговорыКонтрагентов ДоговорКонтрагента {get; set;}
        [Description1C8(Name = "СчетУчетаРасчетовСКонтрагентом", Comment = "(Регл)", Synonym = "Счет расчетов")]
        public ПланСчетов.Хозрасчетный СчетУчетаРасчетовСКонтрагентом {get; set;}
        [Description1C8(Name = "СчетУчетаРасчетовПоАвансам", Comment = "(Регл)", Synonym = "Счет расчетов по авансам")]
        public ПланСчетов.Хозрасчетный СчетУчетаРасчетовПоАвансам {get; set;}
        [Description1C8(Name = "СчетУчетаРасчетовПоТаре", Comment = "(Регл)", Synonym = "Счет расчетов по таре")]
        public ПланСчетов.Хозрасчетный СчетУчетаРасчетовПоТаре {get; set;}
        [Description1C8(Name = "ВалютаДокумента", Comment = "(Общ)", Synonym = "Валюта")]
        public Catalogs.Валюты ВалютаДокумента {get; set;}
        [Description1C8(Name = "НомерВходящегоДокумента", Comment = "(Общ)", Synonym = "Номер документа сторонней организации")]
        [StringLength(30)]
        public string НомерВходящегоДокумента {get; set;}
        [Description1C8(Name = "ДатаВходящегоДокумента", Comment = "(Общ)", Synonym = "Дата документа сторонней организации")]
        public DateTime ДатаВходящегоДокумента {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "(Общ)", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "КратностьВзаиморасчетов", Comment = "(Общ)", Synonym = "Кратность взаиморасчетов")]
        // Format 10.0
        public long КратностьВзаиморасчетов {get; set;}
        [Description1C8(Name = "КурсВзаиморасчетов", Comment = "(Общ)", Synonym = "Курс взаиморасчетов")]
        // Format 10.4
        public decimal КурсВзаиморасчетов {get; set;}
        [Description1C8(Name = "СуммаВключаетНДС", Comment = "(Общ)", Synonym = "Сумма включает НДС")]
        public bool СуммаВключаетНДС {get; set;}
        [Description1C8(Name = "СчетУчетаРасчетовПоТареПоАвансам", Comment = "(Регл)", Synonym = "Счет расчетов по таре по авансам")]
        public ПланСчетов.Хозрасчетный СчетУчетаРасчетовПоТареПоАвансам {get; set;}
        [Description1C8(Name = "СуммаДокумента", Comment = "(Общ) Сумма в валюте документа, налоги включены согласно флагам", Synonym = "Сумма")]
        // Format 15.2
        public decimal СуммаДокумента {get; set;}
        [Description1C8(Name = "ТипЦен", Comment = "(Общ)", Synonym = "Тип цен")]
        public Catalogs.ТипыЦенНоменклатуры ТипЦен {get; set;}
        [Description1C8(Name = "РучнаяКорректировка", Comment = "", Synonym = "Ручная корректировка")]
        public bool РучнаяКорректировка {get; set;}
        [Description1C8(Name = "Сделка", Comment = "(Общ)", Synonym = "Документ расчетов")]
        public Документ.ПлатежныйОрдерСписаниеДенежныхСредств Сделка {get; set;}
        [Description1C8(Name = "УдалитьУчитыватьНДС", Comment = "(Общ)", Synonym = "(не используется) Учитывать НДС")]
        public bool УдалитьУчитыватьНДС {get; set;}
        [Description1C8(Name = "СчетУчетаНДС", Comment = "(Регл)", Synonym = "Счет НДС")]
        public ПланСчетов.Хозрасчетный СчетУчетаНДС {get; set;}
        [Description1C8(Name = "СчетУчетаНДСПодтвержденный", Comment = "", Synonym = "Счет НДС подтвержденный")]
        public ПланСчетов.Хозрасчетный СчетУчетаНДСПодтвержденный {get; set;}
        [Description1C8(Name = "СуммаНДСПропорциональноВсего", Comment = "", Synonym = "Сумма НДС (пропорционально, вся)")]
        // Format 15.2
        public decimal СуммаНДСПропорциональноВсего {get; set;}
        [Description1C8(Name = "СуммаНДСПропорциональноКредит", Comment = "", Synonym = "Сумма НДС (пропорционально, в кредит)")]
        // Format 15.2
        public decimal СуммаНДСПропорциональноКредит {get; set;}
        [Description1C8(Name = "ЕстьАвансДо01042011", Comment = "", Synonym = "Есть валовые расходы, начисленные по авансу до 01.04.2011 р.")]
        public bool ЕстьАвансДо01042011 {get; set;}
        [Description1C8(Name = "СуммаВДВРПоАвансуДо01042011", Comment = "", Synonym = "Сумма валовых расходов, начисленных по авансу до 01.04.2011 р. (грн.)")]
        // Format 15.2
        public decimal СуммаВДВРПоАвансуДо01042011 {get; set;}
        [Description1C8(Name = "Звит1С_DOC_ID", Comment = "", Synonym = "ИД документа FREDO Звіт")]
        [StringLength(40)]
        public string Звит1С_DOC_ID {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Оборудование", Comment = "(Общ)", Synonym = "Оборудование")]
        public List<ПоступлениеТоваровУслуг_Оборудование> ПоступлениеТоваровУслугОборудование {get;set;}
        [Description1C8(Name = "ОбъектыСтроительства", Comment = "", Synonym = "Объекты строительства")]
        public List<ПоступлениеТоваровУслуг_ОбъектыСтроительства> ПоступлениеТоваровУслугОбъектыСтроительства {get;set;}
        [Description1C8(Name = "Товары", Comment = "(Общ)", Synonym = "Товары")]
        public List<ПоступлениеТоваровУслуг_Товары> ПоступлениеТоваровУслугТовары {get;set;}
        [Description1C8(Name = "Услуги", Comment = "(Общ)", Synonym = "Услуги")]
        public List<ПоступлениеТоваровУслуг_Услуги> ПоступлениеТоваровУслугУслуги {get;set;}
        [Description1C8(Name = "ВозвратнаяТара", Comment = "(Общ)", Synonym = "Возвратная тара")]
        public List<ПоступлениеТоваровУслуг_ВозвратнаяТара> ПоступлениеТоваровУслугВозвратнаяТара {get;set;}
        [Description1C8(Name = "БланкиСтрогогоУчета", Comment = "(Общ)", Synonym = "Бланки строгого учета")]
        public List<ПоступлениеТоваровУслуг_БланкиСтрогогоУчета> ПоступлениеТоваровУслугБланкиСтрогогоУчета {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Оборудование", Comment = "(Общ)", Synonym = "Оборудование")]
    [Table("PostuplenyeTovarovUsluh_Oborudovanye")]
    public class ПоступлениеТоваровУслуг_Оборудование
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
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение (НДС)")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
    }
    [Description1C8(Name = "ОбъектыСтроительства", Comment = "", Synonym = "Объекты строительства")]
    [Table("PostuplenyeTovarovUsluh_ObektyStroytelstva")]
    public class ПоступлениеТоваровУслуг_ОбъектыСтроительства
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ОбъектСтроительства", Comment = "", Synonym = "Объект строительства")]
        public Catalogs.ОбъектыСтроительства ОбъектСтроительства {get; set;}
        [Description1C8(Name = "СтатьяЗатрат", Comment = "", Synonym = "Статья затрат")]
        public Catalogs.СтатьиЗатрат СтатьяЗатрат {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "СтавкаНДС", Comment = "", Synonym = "% НДС")]
        public Enums.СтавкиНДС СтавкаНДС {get; set;}
        [Description1C8(Name = "СуммаНДС", Comment = "", Synonym = "Сумма НДС")]
        // Format 15.2
        public decimal СуммаНДС {get; set;}
        [Description1C8(Name = "СчетУчетаБУ", Comment = "", Synonym = "Счет учета")]
        public ПланСчетов.Хозрасчетный СчетУчетаБУ {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение (НДС)")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
    }
    [Description1C8(Name = "Товары", Comment = "(Общ)", Synonym = "Товары")]
    [Table("PostuplenyeTovarovUsluh_Tovary")]
    public class ПоступлениеТоваровУслуг_Товары
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
        [Description1C8(Name = "ЦенаВРознице", Comment = "(Общ)", Synonym = "Цена")]
        // Format 15.2
        public decimal ЦенаВРознице {get; set;}
        [Description1C8(Name = "СуммаВРознице", Comment = "(Общ)", Synonym = "Сумма в рознице")]
        // Format 15.2
        public decimal СуммаВРознице {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение (НДС)")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        [Description1C8(Name = "СтавкаНДСВРознице", Comment = "(Общ)", Synonym = "% НДС в рознице")]
        public Enums.СтавкиНДС СтавкаНДСВРознице {get; set;}
        [Description1C8(Name = "НаименованиеПоставщика", Comment = "", Synonym = "Наименование поставщика")]
        public string НаименованиеПоставщика {get; set;}
    }
    [Description1C8(Name = "Услуги", Comment = "(Общ)", Synonym = "Услуги")]
    [Table("PostuplenyeTovarovUsluh_Usluhy")]
    public class ПоступлениеТоваровУслуг_Услуги
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Номенклатура", Comment = "(Общ)", Synonym = "Номенклатура")]
        public Catalogs.Номенклатура Номенклатура {get; set;}
        [Description1C8(Name = "Содержание", Comment = "(Общ)", Synonym = "Содержание услуги, доп. сведения")]
        [StringLength(1000)]
        public string Содержание {get; set;}
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
        [Description1C8(Name = "СчетЗатрат", Comment = "(Регл)", Synonym = "Счет затрат")]
        public ПланСчетов.Хозрасчетный СчетЗатрат {get; set;}
        [Description1C8(Name = "Субконто1", Comment = "(Регл)", Synonym = "Субконто 1")]
        public Catalogs.ВидыНалоговойДеятельности Субконто1 {get; set;}
        [Description1C8(Name = "Субконто2", Comment = "(Регл)", Synonym = "Субконто 2")]
        public Catalogs.ВидыНалоговойДеятельности Субконто2 {get; set;}
        [Description1C8(Name = "Субконто3", Comment = "(Регл)", Synonym = "Субконто 3")]
        public Catalogs.ВидыНалоговойДеятельности Субконто3 {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение (НДС)")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        [Description1C8(Name = "НалоговоеНазначениеДоходовИЗатрат", Comment = "", Synonym = "Налоговое назначение (затрат)")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначениеДоходовИЗатрат {get; set;}
    }
    [Description1C8(Name = "ВозвратнаяТара", Comment = "(Общ)", Synonym = "Возвратная тара")]
    [Table("PostuplenyeTovarovUsluh_VozvratnaiaTara")]
    public class ПоступлениеТоваровУслуг_ВозвратнаяТара
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Номенклатура", Comment = "(Общ)", Synonym = "Номенклатура")]
        public Catalogs.Номенклатура Номенклатура {get; set;}
        [Description1C8(Name = "Количество", Comment = "(Общ)", Synonym = "Количество")]
        // Format 15.3
        public decimal Количество {get; set;}
        [Description1C8(Name = "Цена", Comment = "(Общ) Оценочная стоимость возвратной тары в валюте взаиморасчетов", Synonym = "Цена")]
        // Format 15.2
        public decimal Цена {get; set;}
        [Description1C8(Name = "Сумма", Comment = "(Общ)", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "СчетУчетаБУ", Comment = "(Регл)", Synonym = "Счет учета")]
        public ПланСчетов.Хозрасчетный СчетУчетаБУ {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение (НДС)")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
    }
    [Description1C8(Name = "БланкиСтрогогоУчета", Comment = "(Общ)", Synonym = "Бланки строгого учета")]
    [Table("PostuplenyeTovarovUsluh_BlankyStrohohoUcheta")]
    public class ПоступлениеТоваровУслуг_БланкиСтрогогоУчета
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Номенклатура", Comment = "(Общ)", Synonym = "Номенклатура")]
        public Catalogs.Номенклатура Номенклатура {get; set;}
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
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        [Description1C8(Name = "ЦенаНоминальная", Comment = "", Synonym = "Цена номинальная")]
        // Format 15.2
        public decimal ЦенаНоминальная {get; set;}
        [Description1C8(Name = "СуммаНоминальная", Comment = "", Synonym = "Сумма номинальная")]
        // Format 15.2
        public decimal СуммаНоминальная {get; set;}
        [Description1C8(Name = "СчетУчетаЗабалансовыйБУ", Comment = "", Synonym = "Счет учета забалансовый")]
        public ПланСчетов.Хозрасчетный СчетУчетаЗабалансовыйБУ {get; set;}
        [Description1C8(Name = "ЕдиницаИзмерения", Comment = "(Общ)", Synonym = "Единица измерения")]
        public Catalogs.КлассификаторЕдиницИзмерения ЕдиницаИзмерения {get; set;}
        [Description1C8(Name = "Коэффициент", Comment = "(Общ)", Synonym = "Коэффициент")]
        // Format 10.3
        public decimal Коэффициент {get; set;}
    }
}
