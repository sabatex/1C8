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
    [Table("AvansovyiOtchet")]
    [Description1C8(Name = "АвансовыйОтчет", Comment = "", Synonym = "Авансовый отчет")]
    public class АвансовыйОтчет:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "ВалютаДокумента", Comment = "", Synonym = "Валюта")]
        public Catalogs.Валюты ВалютаДокумента {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "КурсДокумента", Comment = "", Synonym = "Курс документа")]
        // Format 10.4
        public decimal КурсДокумента {get; set;}
        [Description1C8(Name = "КратностьДокумента", Comment = "", Synonym = "Кратность документа")]
        // Format 10.0
        public long КратностьДокумента {get; set;}
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Склад", Comment = "", Synonym = "Склад")]
        public Catalogs.Склады Склад {get; set;}
        [Description1C8(Name = "СуммаВключаетНДС", Comment = "", Synonym = "Сумма включает НДС")]
        public bool СуммаВключаетНДС {get; set;}
        [Description1C8(Name = "СуммаДокумента", Comment = "", Synonym = "Сумма")]
        // Format 15.2
        public decimal СуммаДокумента {get; set;}
        [Description1C8(Name = "ТипЦен", Comment = "", Synonym = "Тип цен")]
        public Catalogs.ТипыЦенНоменклатуры ТипЦен {get; set;}
        [Description1C8(Name = "УдалитьУчитыватьНДС", Comment = "(Общ)", Synonym = "(не используется) Учитывать НДС")]
        public bool УдалитьУчитыватьНДС {get; set;}
        [Description1C8(Name = "ФизЛицо", Comment = "", Synonym = "Подотчетное лицо")]
        public Catalogs.ФизическиеЛица ФизЛицо {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "НазначениеАванса", Comment = "", Synonym = "Назначение")]
        [StringLength(100)]
        public string НазначениеАванса {get; set;}
        [Description1C8(Name = "РучнаяКорректировка", Comment = "", Synonym = "Ручная корректировка")]
        public bool РучнаяКорректировка {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ВыданныеАвансы", Comment = "", Synonym = "Выданные авансы")]
        public List<АвансовыйОтчет_ВыданныеАвансы> АвансовыйОтчетВыданныеАвансы {get;set;}
        [Description1C8(Name = "Товары", Comment = "", Synonym = "Товары")]
        public List<АвансовыйОтчет_Товары> АвансовыйОтчетТовары {get;set;}
        [Description1C8(Name = "ВозвратнаяТара", Comment = "", Synonym = "Возвратная тара")]
        public List<АвансовыйОтчет_ВозвратнаяТара> АвансовыйОтчетВозвратнаяТара {get;set;}
        [Description1C8(Name = "ОплатаПоставщикам", Comment = "", Synonym = "Оплата поставщикам")]
        public List<АвансовыйОтчет_ОплатаПоставщикам> АвансовыйОтчетОплатаПоставщикам {get;set;}
        [Description1C8(Name = "Прочее", Comment = "", Synonym = "Прочее")]
        public List<АвансовыйОтчет_Прочее> АвансовыйОтчетПрочее {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ВыданныеАвансы", Comment = "", Synonym = "Выданные авансы")]
    [Table("AvansovyiOtchet_VydannyeAvansy")]
    public class АвансовыйОтчет_ВыданныеАвансы
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ДокументАванса", Comment = "", Synonym = "Документ аванса")]
        public Documents.ПлатежныйОрдерСписаниеДенежныхСредств ДокументАванса {get; set;}
        [Description1C8(Name = "УдалитьСумма", Comment = "Погашаемая отчетом сумма аванса в валюте взаиморасчетов с подотчетником", Synonym = "(не используется) Израсходовано")]
        // Format 15.2
        public decimal УдалитьСумма {get; set;}
    }
    [Description1C8(Name = "Товары", Comment = "", Synonym = "Товары")]
    [Table("AvansovyiOtchet_Tovary")]
    public class АвансовыйОтчет_Товары
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ВидДокВходящий", Comment = "", Synonym = "Вид вход. документа")]
        [StringLength(50)]
        public string ВидДокВходящий {get; set;}
        [Description1C8(Name = "НомерВходящегоДокумента", Comment = "", Synonym = "Номер документа сторонней организации")]
        [StringLength(10)]
        public string НомерВходящегоДокумента {get; set;}
        [Description1C8(Name = "ДатаВходящегоДокумента", Comment = "", Synonym = "Дата вход. документа")]
        public DateTime ДатаВходящегоДокумента {get; set;}
        [Description1C8(Name = "Контрагент", Comment = "", Synonym = "Контрагент")]
        public Catalogs.Контрагенты Контрагент {get; set;}
        [Description1C8(Name = "Номенклатура", Comment = "", Synonym = "Номенклатура")]
        public Catalogs.Номенклатура Номенклатура {get; set;}
        [Description1C8(Name = "ЕдиницаИзмерения", Comment = "", Synonym = "Единица измерения")]
        public Catalogs.КлассификаторЕдиницИзмерения ЕдиницаИзмерения {get; set;}
        [Description1C8(Name = "Коэффициент", Comment = "", Synonym = "Коэффициент")]
        // Format 10.3
        public decimal Коэффициент {get; set;}
        [Description1C8(Name = "Количество", Comment = "", Synonym = "Количество")]
        // Format 15.3
        public decimal Количество {get; set;}
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
        [Description1C8(Name = "СуммаНДСПропорциональноКредит", Comment = "", Synonym = "Сумма НДС (пропорционально, в кредит)")]
        // Format 15.2
        public decimal СуммаНДСПропорциональноКредит {get; set;}
        [Description1C8(Name = "СчетУчетаБУ", Comment = "", Synonym = "Счет учета")]
        public ПланСчетов.Хозрасчетный СчетУчетаБУ {get; set;}
        [Description1C8(Name = "СчетУчетаНДС", Comment = "", Synonym = "Счет НДС")]
        public ПланСчетов.Хозрасчетный СчетУчетаНДС {get; set;}
        [Description1C8(Name = "ДоговорКонтрагента", Comment = "", Synonym = "Договор")]
        public Catalogs.ДоговорыКонтрагентов ДоговорКонтрагента {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение (НДС)")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        [Description1C8(Name = "Сделка", Comment = "", Synonym = "Документ расчетов")]
        public Documents.ПлатежныйОрдерСписаниеДенежныхСредств Сделка {get; set;}
        [Description1C8(Name = "СтатьяДекларацииПоЕдиномуНалогу", Comment = "", Synonym = "Ст. декл. по ед. налогу")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяДекларацииПоЕдиномуНалогу {get; set;}
    }
    [Description1C8(Name = "ВозвратнаяТара", Comment = "", Synonym = "Возвратная тара")]
    [Table("AvansovyiOtchet_VozvratnaiaTara")]
    public class АвансовыйОтчет_ВозвратнаяТара
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
        [Description1C8(Name = "Контрагент", Comment = "", Synonym = "Контрагент")]
        public Catalogs.Контрагенты Контрагент {get; set;}
        [Description1C8(Name = "ДоговорКонтрагента", Comment = "", Synonym = "Договор")]
        public Catalogs.ДоговорыКонтрагентов ДоговорКонтрагента {get; set;}
        [Description1C8(Name = "ВидДокВходящий", Comment = "", Synonym = "Вид вход. документа")]
        [StringLength(50)]
        public string ВидДокВходящий {get; set;}
        [Description1C8(Name = "ДатаВходящегоДокумента", Comment = "", Synonym = "Дата вход. документа")]
        public DateTime ДатаВходящегоДокумента {get; set;}
        [Description1C8(Name = "НомерВходящегоДокумента", Comment = "", Synonym = "Номер документа сторонней организации")]
        [StringLength(10)]
        public string НомерВходящегоДокумента {get; set;}
        [Description1C8(Name = "СчетУчетаБУ", Comment = "", Synonym = "Счет учета")]
        public ПланСчетов.Хозрасчетный СчетУчетаБУ {get; set;}
        [Description1C8(Name = "СчетУчетаРасчетовПоТаре", Comment = "", Synonym = "Счет расчетов по таре")]
        public ПланСчетов.Хозрасчетный СчетУчетаРасчетовПоТаре {get; set;}
        [Description1C8(Name = "СчетУчетаРасчетовПоТареПоАвансам", Comment = "", Synonym = "Счет расчетов по таре по авансам")]
        public ПланСчетов.Хозрасчетный СчетУчетаРасчетовПоТареПоАвансам {get; set;}
        [Description1C8(Name = "Сделка", Comment = "", Synonym = "Документ расчетов")]
        public Documents.ПлатежныйОрдерСписаниеДенежныхСредств Сделка {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение (НДС)")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
    }
    [Description1C8(Name = "ОплатаПоставщикам", Comment = "", Synonym = "Оплата поставщикам")]
    [Table("AvansovyiOtchet_OplataPostavshchykam")]
    public class АвансовыйОтчет_ОплатаПоставщикам
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Контрагент", Comment = "", Synonym = "Контрагент")]
        public Catalogs.Контрагенты Контрагент {get; set;}
        [Description1C8(Name = "ДоговорКонтрагента", Comment = "", Synonym = "Договор")]
        public Catalogs.ДоговорыКонтрагентов ДоговорКонтрагента {get; set;}
        [Description1C8(Name = "Сделка", Comment = "", Synonym = "Документ расчетов")]
        public Documents.ПлатежныйОрдерСписаниеДенежныхСредств Сделка {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "КурсВзаиморасчетов", Comment = "", Synonym = "Курс взаиморасчетов")]
        // Format 10.4
        public decimal КурсВзаиморасчетов {get; set;}
        [Description1C8(Name = "КратностьВзаиморасчетов", Comment = "", Synonym = "Кратность взаиморасчетов")]
        // Format 10.0
        public long КратностьВзаиморасчетов {get; set;}
        [Description1C8(Name = "СуммаВзаиморасчетов", Comment = "", Synonym = "Сумма взаиморасчетов")]
        // Format 15.2
        public decimal СуммаВзаиморасчетов {get; set;}
        [Description1C8(Name = "ВидДокВходящий", Comment = "", Synonym = "Вид вход. документа")]
        [StringLength(50)]
        public string ВидДокВходящий {get; set;}
        [Description1C8(Name = "ДатаВходящегоДокумента", Comment = "", Synonym = "Дата вход. документа")]
        public DateTime ДатаВходящегоДокумента {get; set;}
        [Description1C8(Name = "НомерВходящегоДокумента", Comment = "", Synonym = "Номер документа сторонней организации")]
        [StringLength(10)]
        public string НомерВходящегоДокумента {get; set;}
        [Description1C8(Name = "Содержание", Comment = "", Synonym = "Содержание")]
        [StringLength(250)]
        public string Содержание {get; set;}
        [Description1C8(Name = "СчетУчетаРасчетовСКонтрагентом", Comment = "", Synonym = "Счет расчетов")]
        public ПланСчетов.Хозрасчетный СчетУчетаРасчетовСКонтрагентом {get; set;}
        [Description1C8(Name = "СчетУчетаРасчетовПоАвансам", Comment = "", Synonym = "Счет авансов")]
        public ПланСчетов.Хозрасчетный СчетУчетаРасчетовПоАвансам {get; set;}
        [Description1C8(Name = "СтавкаНДС", Comment = "", Synonym = "% НДС")]
        public Enums.СтавкиНДС СтавкаНДС {get; set;}
        [Description1C8(Name = "СуммаНДС", Comment = "", Synonym = "Сумма НДС")]
        // Format 15.2
        public decimal СуммаНДС {get; set;}
        [Description1C8(Name = "СтатьяДекларацииПоЕдиномуНалогу", Comment = "", Synonym = "Ст. декл. по ед. налогу")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяДекларацииПоЕдиномуНалогу {get; set;}
        [Description1C8(Name = "ЗаТару", Comment = "", Synonym = "Платеж за тару")]
        public bool ЗаТару {get; set;}
        [Description1C8(Name = "СчетУчетаНДС", Comment = "", Synonym = "Счет НДС (неподтвержденный)")]
        public ПланСчетов.Хозрасчетный СчетУчетаНДС {get; set;}
        [Description1C8(Name = "СчетУчетаНДСПодтвержденный", Comment = "", Synonym = "Счет НДС (нал. кредит/обяз.)")]
        public ПланСчетов.Хозрасчетный СчетУчетаНДСПодтвержденный {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение (НДС)")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        [Description1C8(Name = "Амортизируется", Comment = "Поставка Основных фондов. Исользуется для запонения Приложения 5 к Декларации по НДС (с 2008 г)", Synonym = "Поставка основных фондов")]
        public bool Амортизируется {get; set;}
        [Description1C8(Name = "СуммаНДСПропорциональноКредит", Comment = "", Synonym = "Сумма НДС (пропорционально, в кредит)")]
        // Format 15.2
        public decimal СуммаНДСПропорциональноКредит {get; set;}
    }
    [Description1C8(Name = "Прочее", Comment = "", Synonym = "Прочее")]
    [Table("AvansovyiOtchet_Prochee")]
    public class АвансовыйОтчет_Прочее
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ВидДокВходящий", Comment = "", Synonym = "Вид вход. документа")]
        [StringLength(50)]
        public string ВидДокВходящий {get; set;}
        [Description1C8(Name = "НомерВходящегоДокумента", Comment = "", Synonym = "Номер документа сторонней организации")]
        [StringLength(10)]
        public string НомерВходящегоДокумента {get; set;}
        [Description1C8(Name = "ДатаВходящегоДокумента", Comment = "", Synonym = "Дата вход. документа")]
        public DateTime ДатаВходящегоДокумента {get; set;}
        [Description1C8(Name = "Контрагент", Comment = "", Synonym = "Контрагент")]
        public Catalogs.Контрагенты Контрагент {get; set;}
        [Description1C8(Name = "Номенклатура", Comment = "", Synonym = "Номенклатура")]
        public Catalogs.Номенклатура Номенклатура {get; set;}
        [Description1C8(Name = "Содержание", Comment = "", Synonym = "Содержание")]
        [StringLength(1000)]
        public string Содержание {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "СтавкаНДС", Comment = "", Synonym = "% НДС")]
        public Enums.СтавкиНДС СтавкаНДС {get; set;}
        [Description1C8(Name = "СуммаНДС", Comment = "", Synonym = "Сумма НДС")]
        // Format 15.2
        public decimal СуммаНДС {get; set;}
        [Description1C8(Name = "СуммаНДСПропорциональноКредит", Comment = "", Synonym = "Сумма НДС (пропорционально, в кредит)")]
        // Format 15.2
        public decimal СуммаНДСПропорциональноКредит {get; set;}
        [Description1C8(Name = "СчетЗатрат", Comment = "", Synonym = "Счет затрат")]
        public ПланСчетов.Хозрасчетный СчетЗатрат {get; set;}
        [Description1C8(Name = "Субконто1", Comment = "", Synonym = "Субконто 1")]
        public Catalogs.ВидыНалоговойДеятельности Субконто1 {get; set;}
        [Description1C8(Name = "Субконто2", Comment = "", Synonym = "Субконто 2")]
        public Catalogs.ВидыНалоговойДеятельности Субконто2 {get; set;}
        [Description1C8(Name = "Субконто3", Comment = "", Synonym = "Субконто 3")]
        public Catalogs.ВидыНалоговойДеятельности Субконто3 {get; set;}
        [Description1C8(Name = "СчетУчетаНДС", Comment = "", Synonym = "Счет НДС")]
        public ПланСчетов.Хозрасчетный СчетУчетаНДС {get; set;}
        [Description1C8(Name = "ДоговорКонтрагента", Comment = "", Synonym = "Договор")]
        public Catalogs.ДоговорыКонтрагентов ДоговорКонтрагента {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение (НДС)")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        [Description1C8(Name = "НалоговоеНазначениеДоходовИЗатрат", Comment = "", Synonym = "Налоговое назначение (затрат)")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначениеДоходовИЗатрат {get; set;}
        [Description1C8(Name = "КоличествоСуток", Comment = "", Synonym = "Количество суток")]
        // Format 10.0
        public long КоличествоСуток {get; set;}
        [Description1C8(Name = "КомандировкаЗарубеж", Comment = "", Synonym = "Командировка зарубеж")]
        public bool КомандировкаЗарубеж {get; set;}
        [Description1C8(Name = "Сделка", Comment = "", Synonym = "Документ расчетов")]
        public Documents.ПлатежныйОрдерСписаниеДенежныхСредств Сделка {get; set;}
        [Description1C8(Name = "СтатьяДекларацииПоЕдиномуНалогу", Comment = "", Synonym = "Ст. декл. по ед. налогу")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяДекларацииПоЕдиномуНалогу {get; set;}
        [Description1C8(Name = "СуточныеДатаС", Comment = "", Synonym = "Суточные дата с")]
        public DateTime СуточныеДатаС {get; set;}
        [Description1C8(Name = "СуточныеДатаПо", Comment = "", Synonym = "Суточные дата по")]
        public DateTime СуточныеДатаПо {get; set;}
        [Description1C8(Name = "ЭтоСуточные", Comment = "", Synonym = "Это суточные")]
        public bool ЭтоСуточные {get; set;}
        [Description1C8(Name = "СуммаНУ", Comment = "Сумма НУ с учетом нормы", Synonym = "Сумма суточных (н/у)")]
        // Format 15.2
        public decimal СуммаНУ {get; set;}
    }
}
