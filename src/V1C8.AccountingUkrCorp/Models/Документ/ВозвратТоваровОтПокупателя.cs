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
    [Table("VozvratTovarovOtPokupatelia")]
    [Description1C8(Name = "ВозвратТоваровОтПокупателя", Comment = "", Synonym = "Возврат товаров от покупателя")]
    public class ВозвратТоваровОтПокупателя:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "ВидОперации", Comment = "", Synonym = "Вид операции")]
        public Enums.ВидыОперацийВозвратТоваровОтПокупателя ВидОперации {get; set;}
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Склад", Comment = "", Synonym = "Склад")]
        public Catalogs.Склады Склад {get; set;}
        [Description1C8(Name = "Контрагент", Comment = "", Synonym = "Контрагент")]
        public Catalogs.Контрагенты Контрагент {get; set;}
        [Description1C8(Name = "ДоговорКонтрагента", Comment = "", Synonym = "Договор")]
        public Catalogs.ДоговорыКонтрагентов ДоговорКонтрагента {get; set;}
        [Description1C8(Name = "Сделка", Comment = "", Synonym = "Документ расчетов")]
        public Документ.ПлатежныйОрдерСписаниеДенежныхСредств Сделка {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "ВалютаДокумента", Comment = "", Synonym = "Валюта")]
        public Catalogs.Валюты ВалютаДокумента {get; set;}
        [Description1C8(Name = "КурсВзаиморасчетов", Comment = "", Synonym = "Курс взаиморасчетов")]
        // Format 10.4
        public decimal КурсВзаиморасчетов {get; set;}
        [Description1C8(Name = "КратностьВзаиморасчетов", Comment = "", Synonym = "Кратность взаиморасчетов")]
        // Format 10.0
        public long КратностьВзаиморасчетов {get; set;}
        [Description1C8(Name = "СуммаВключаетНДС", Comment = "", Synonym = "Сумма включает НДС")]
        public bool СуммаВключаетНДС {get; set;}
        [Description1C8(Name = "СуммаДокумента", Comment = "", Synonym = "Сумма")]
        // Format 15.2
        public decimal СуммаДокумента {get; set;}
        [Description1C8(Name = "СчетУчетаРасчетовПоАвансам", Comment = "", Synonym = "Счет расчетов по авансам")]
        public ПланСчетов.Хозрасчетный СчетУчетаРасчетовПоАвансам {get; set;}
        [Description1C8(Name = "СчетУчетаРасчетовПоТаре", Comment = "", Synonym = "Счет расчетов по таре")]
        public ПланСчетов.Хозрасчетный СчетУчетаРасчетовПоТаре {get; set;}
        [Description1C8(Name = "СчетУчетаРасчетовСКонтрагентом", Comment = "", Synonym = "Счет расчетов")]
        public ПланСчетов.Хозрасчетный СчетУчетаРасчетовСКонтрагентом {get; set;}
        [Description1C8(Name = "ТипЦен", Comment = "", Synonym = "Тип цен")]
        public Catalogs.ТипыЦенНоменклатуры ТипЦен {get; set;}
        [Description1C8(Name = "УдалитьУчитыватьНДС", Comment = "", Synonym = "(не используется) Учитывать НДС")]
        public bool УдалитьУчитыватьНДС {get; set;}
        [Description1C8(Name = "СчетУчетаРасчетовПоТареПоАвансам", Comment = "(Регл)", Synonym = "Счет расчетов по таре по авансам")]
        public ПланСчетов.Хозрасчетный СчетУчетаРасчетовПоТареПоАвансам {get; set;}
        [Description1C8(Name = "АвторасчетНДС", Comment = "", Synonym = "Авторасчет НДС")]
        public bool АвторасчетНДС {get; set;}
        [Description1C8(Name = "ДокументОтгрузки", Comment = "", Synonym = "Документ отгрузки")]
        public Документ.ОтчетОРозничныхПродажах ДокументОтгрузки {get; set;}
        [Description1C8(Name = "РучнаяКорректировка", Comment = "", Synonym = "Ручная корректировка")]
        public bool РучнаяКорректировка {get; set;}
        [Description1C8(Name = "СчетУчетаНДС", Comment = "", Synonym = "Счет НДС (неподтвержденный)")]
        public ПланСчетов.Хозрасчетный СчетУчетаНДС {get; set;}
        [Description1C8(Name = "СчетУчетаНДСПодтвержденный", Comment = "", Synonym = "Счет НДС (нал. обязательства)")]
        public ПланСчетов.Хозрасчетный СчетУчетаНДСПодтвержденный {get; set;}
        [Description1C8(Name = "ЕстьАвансДо01042011", Comment = "", Synonym = "Есть валовые доходы (для исходной реализации), начисленные по авансу до 01.04.2011 г.")]
        public bool ЕстьАвансДо01042011 {get; set;}
        [Description1C8(Name = "СуммаВДВРПоАвансуДо01042011", Comment = "", Synonym = "Сумма валовых расходов, начисленных по авансу до 01.04.2011 р. (грн.)")]
        // Format 15.2
        public decimal СуммаВДВРПоАвансуДо01042011 {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Товары", Comment = "", Synonym = "Товары")]
        public List<ВозвратТоваровОтПокупателя_Товары> ВозвратТоваровОтПокупателяТовары {get;set;}
        [Description1C8(Name = "ВозвратнаяТара", Comment = "", Synonym = "Возвратная тара")]
        public List<ВозвратТоваровОтПокупателя_ВозвратнаяТара> ВозвратТоваровОтПокупателяВозвратнаяТара {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Товары", Comment = "", Synonym = "Товары")]
    [Table("VozvratTovarovOtPokupatelia_Tovary")]
    public class ВозвратТоваровОтПокупателя_Товары
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Номенклатура", Comment = "", Synonym = "Номенклатура")]
        public Catalogs.Номенклатура Номенклатура {get; set;}
        [Description1C8(Name = "Количество", Comment = "", Synonym = "Количество")]
        // Format 15.3
        public decimal Количество {get; set;}
        [Description1C8(Name = "ЕдиницаИзмерения", Comment = "", Synonym = "Единица измерения")]
        public Catalogs.КлассификаторЕдиницИзмерения ЕдиницаИзмерения {get; set;}
        [Description1C8(Name = "Коэффициент", Comment = "", Synonym = "Коэффициент")]
        // Format 10.3
        public decimal Коэффициент {get; set;}
        [Description1C8(Name = "Себестоимость", Comment = "", Synonym = "Себестоимость")]
        // Format 15.2
        public decimal Себестоимость {get; set;}
        [Description1C8(Name = "СебестоимостьНУ", Comment = "", Synonym = "Себестоимость (НУ)")]
        // Format 15.2
        public decimal СебестоимостьНУ {get; set;}
        [Description1C8(Name = "Цена", Comment = "", Synonym = "Цена")]
        // Format 15.2
        public decimal Цена {get; set;}
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
        [Description1C8(Name = "ПереданныеСчетУчетаБУ", Comment = "", Synonym = "Переданные, счет учета")]
        public ПланСчетов.Хозрасчетный ПереданныеСчетУчетаБУ {get; set;}
        [Description1C8(Name = "СхемаРеализации", Comment = "", Synonym = "Схема реализации")]
        public Catalogs.СхемыРеализации СхемаРеализации {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение (НДС)")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        [Description1C8(Name = "НалоговоеНазначениеДоходовИЗатрат", Comment = "", Synonym = "Налоговое назначение (доходов и затрат)")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначениеДоходовИЗатрат {get; set;}
        [Description1C8(Name = "СуммаБезСкидки", Comment = "", Synonym = "Сумма б/скидки")]
        // Format 15.2
        public decimal СуммаБезСкидки {get; set;}
        [Description1C8(Name = "СуммаСкидки", Comment = "", Synonym = "Скидка")]
        // Format 15.2
        public decimal СуммаСкидки {get; set;}
    }
    [Description1C8(Name = "ВозвратнаяТара", Comment = "", Synonym = "Возвратная тара")]
    [Table("VozvratTovarovOtPokupatelia_VozvratnaiaTara")]
    public class ВозвратТоваровОтПокупателя_ВозвратнаяТара
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Номенклатура", Comment = "", Synonym = "Номенклатура")]
        public Catalogs.Номенклатура Номенклатура {get; set;}
        [Description1C8(Name = "Количество", Comment = "", Synonym = "Количество")]
        // Format 15.3
        public decimal Количество {get; set;}
        [Description1C8(Name = "Цена", Comment = "", Synonym = "Цена")]
        // Format 15.2
        public decimal Цена {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "СчетУчетаБУ", Comment = "", Synonym = "Счет учета")]
        public ПланСчетов.Хозрасчетный СчетУчетаБУ {get; set;}
        [Description1C8(Name = "СхемаРеализации", Comment = "", Synonym = "Схема реализации")]
        public Catalogs.СхемыРеализации СхемаРеализации {get; set;}
        [Description1C8(Name = "Себестоимость", Comment = "", Synonym = "Себестоимость")]
        // Format 15.2
        public decimal Себестоимость {get; set;}
        [Description1C8(Name = "СебестоимостьНУ", Comment = "", Synonym = "Себестоимость (НУ)")]
        // Format 15.2
        public decimal СебестоимостьНУ {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение (НДС)")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        [Description1C8(Name = "НалоговоеНазначениеДоходовИЗатрат", Comment = "", Synonym = "Налоговое назначение (доходов и затрат)")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначениеДоходовИЗатрат {get; set;}
    }
}
