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
    [Table("HTDYmport")]
    [Description1C8(Name = "ГТДИмпорт", Comment = "", Synonym = "ГТД по импорту")]
    public class ГТДИмпорт:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Контрагент", Comment = "", Synonym = "Таможня")]
        public Catalogs.Контрагенты Контрагент {get; set;}
        [Description1C8(Name = "ДоговорКонтрагента", Comment = "", Synonym = "Договор с таможней")]
        public Catalogs.ДоговорыКонтрагентов ДоговорКонтрагента {get; set;}
        [Description1C8(Name = "ВалютаДокумента", Comment = "", Synonym = "Валюта")]
        public Catalogs.Валюты ВалютаДокумента {get; set;}
        [Description1C8(Name = "КурсДокумента", Comment = "", Synonym = "Курс документа")]
        // Format 10.4
        public decimal КурсДокумента {get; set;}
        [Description1C8(Name = "КратностьДокумента", Comment = "", Synonym = "Кратность документа")]
        // Format 10.0
        public long КратностьДокумента {get; set;}
        [Description1C8(Name = "КурсВзаиморасчетов", Comment = "", Synonym = "Курс взаиморасчетов")]
        // Format 10.4
        public decimal КурсВзаиморасчетов {get; set;}
        [Description1C8(Name = "КратностьВзаиморасчетов", Comment = "", Synonym = "Кратность взаиморасчетов")]
        // Format 10.0
        public long КратностьВзаиморасчетов {get; set;}
        [Description1C8(Name = "НомерГТД", Comment = "", Synonym = "Номер ГТД")]
        [StringLength(21)]
        public string НомерГТД {get; set;}
        [Description1C8(Name = "ТаможенныйСбор", Comment = "", Synonym = "Таможенный сбор")]
        // Format 15.2
        public decimal ТаможенныйСбор {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "ПоставщикТоваров", Comment = "", Synonym = "Поставщик товаров")]
        public Catalogs.Контрагенты ПоставщикТоваров {get; set;}
        [Description1C8(Name = "ДоговорПоставщикаТоваров", Comment = "", Synonym = "Договор поставщика")]
        public Catalogs.ДоговорыКонтрагентов ДоговорПоставщикаТоваров {get; set;}
        [Description1C8(Name = "СчетУчетаАкциза", Comment = "", Synonym = "Счет акциза")]
        public ПланСчетов.Хозрасчетный СчетУчетаАкциза {get; set;}
        [Description1C8(Name = "СчетУчетаПошлины", Comment = "", Synonym = "Счет пошлины")]
        public ПланСчетов.Хозрасчетный СчетУчетаПошлины {get; set;}
        [Description1C8(Name = "СчетУчетаРасчетовПоАвансам", Comment = "", Synonym = "Счет расчетов по авансам")]
        public ПланСчетов.Хозрасчетный СчетУчетаРасчетовПоАвансам {get; set;}
        [Description1C8(Name = "АкцизСубконто1", Comment = "", Synonym = "Субконто 1")]
        public Catalogs.ВидыНалоговойДеятельности АкцизСубконто1 {get; set;}
        [Description1C8(Name = "АкцизСубконто2", Comment = "", Synonym = "Субконто 2")]
        public Catalogs.ВидыНалоговойДеятельности АкцизСубконто2 {get; set;}
        [Description1C8(Name = "АкцизСубконто3", Comment = "", Synonym = "Субконто 3")]
        public Catalogs.ВидыНалоговойДеятельности АкцизСубконто3 {get; set;}
        [Description1C8(Name = "ПошлинаСубконто1", Comment = "", Synonym = "Субконто 1")]
        public Catalogs.ВидыНалоговойДеятельности ПошлинаСубконто1 {get; set;}
        [Description1C8(Name = "ПошлинаСубконто2", Comment = "", Synonym = "Субконто 2")]
        public Catalogs.ВидыНалоговойДеятельности ПошлинаСубконто2 {get; set;}
        [Description1C8(Name = "ПошлинаСубконто3", Comment = "", Synonym = "Субконто 3")]
        public Catalogs.ВидыНалоговойДеятельности ПошлинаСубконто3 {get; set;}
        [Description1C8(Name = "ОформленНалоговыйВексельПоНДС", Comment = "", Synonym = "Вексель по НДС")]
        public bool ОформленНалоговыйВексельПоНДС {get; set;}
        [Description1C8(Name = "СчетУчетаВексель", Comment = "", Synonym = "Счет расчетов по векселю")]
        public ПланСчетов.Хозрасчетный СчетУчетаВексель {get; set;}
        [Description1C8(Name = "ВексельСубконто1", Comment = "", Synonym = "Субконто 1")]
        public Catalogs.ВидыНалоговойДеятельности ВексельСубконто1 {get; set;}
        [Description1C8(Name = "ВексельСубконто2", Comment = "", Synonym = "Субконто 2")]
        public Catalogs.ВидыНалоговойДеятельности ВексельСубконто2 {get; set;}
        [Description1C8(Name = "ВексельСубконто3", Comment = "", Synonym = "Субконто 3")]
        public Catalogs.ВидыНалоговойДеятельности ВексельСубконто3 {get; set;}
        [Description1C8(Name = "СчетУчетаНДС", Comment = "", Synonym = "Счет НДС")]
        public ПланСчетов.Хозрасчетный СчетУчетаНДС {get; set;}
        [Description1C8(Name = "НДССубконто1", Comment = "", Synonym = "Субконто 1")]
        public Catalogs.ВидыНалоговойДеятельности НДССубконто1 {get; set;}
        [Description1C8(Name = "НДССубконто2", Comment = "", Synonym = "Субконто 2")]
        public Catalogs.ВидыНалоговойДеятельности НДССубконто2 {get; set;}
        [Description1C8(Name = "НДССубконто3", Comment = "", Synonym = "Субконто 3")]
        public Catalogs.ВидыНалоговойДеятельности НДССубконто3 {get; set;}
        [Description1C8(Name = "ДатаВыдачиВекселя", Comment = "", Synonym = "Дата выдачи векселя")]
        public DateTime ДатаВыдачиВекселя {get; set;}
        [Description1C8(Name = "СчетУчетаРасчетовСКонтрагентом", Comment = "", Synonym = "Счет расчетов с таможней")]
        public ПланСчетов.Хозрасчетный СчетУчетаРасчетовСКонтрагентом {get; set;}
        [Description1C8(Name = "СчетЗатрат", Comment = "", Synonym = "Счет затрат")]
        public ПланСчетов.Хозрасчетный СчетЗатрат {get; set;}
        [Description1C8(Name = "ЗатратСубконто1", Comment = "", Synonym = "Субконто 1")]
        public Catalogs.ВидыНалоговойДеятельности ЗатратСубконто1 {get; set;}
        [Description1C8(Name = "ЗатратСубконто2", Comment = "", Synonym = "Субконто 2")]
        public Catalogs.ВидыНалоговойДеятельности ЗатратСубконто2 {get; set;}
        [Description1C8(Name = "ЗатратСубконто3", Comment = "", Synonym = "Субконто 3")]
        public Catalogs.ВидыНалоговойДеятельности ЗатратСубконто3 {get; set;}
        [Description1C8(Name = "РучнаяКорректировка", Comment = "", Synonym = "Ручная корректировка")]
        public bool РучнаяКорректировка {get; set;}
        [Description1C8(Name = "ВключаетсяВУточняющийРасчет", Comment = "", Synonym = "Включается в уточняющий расчет к декларации по НДС")]
        public bool ВключаетсяВУточняющийРасчет {get; set;}
        [Description1C8(Name = "СпецРежимНалогообложения", Comment = "", Synonym = "Спец режим")]
        // Format 1.0
        public long СпецРежимНалогообложения {get; set;}
        [Description1C8(Name = "УточняемыйПериод", Comment = "", Synonym = "Уточняемый период")]
        public DateTime УточняемыйПериод {get; set;}
        [Description1C8(Name = "НалоговоеНазначениеДоходовИЗатрат", Comment = "", Synonym = "Налоговое назначение затрат")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначениеДоходовИЗатрат {get; set;}
        [Description1C8(Name = "СуммаНДСПропорциональноВсего", Comment = "", Synonym = "Сумма НДС (пропорционально, вся)")]
        // Format 15.2
        public decimal СуммаНДСПропорциональноВсего {get; set;}
        [Description1C8(Name = "СуммаНДСПропорциональноКредит", Comment = "", Synonym = "Сумма НДС (пропорционально, в кредит)")]
        // Format 15.2
        public decimal СуммаНДСПропорциональноКредит {get; set;}
        [Description1C8(Name = "ЭлектронныйДокумент", Comment = "", Synonym = "Документ оформлен в электронном виде")]
        public bool ЭлектронныйДокумент {get; set;}
        [Description1C8(Name = "СчетНДСУсловнаяПродажа", Comment = "(Регл)", Synonym = "Счет НДС (условная продажа)")]
        public ПланСчетов.Хозрасчетный СчетНДСУсловнаяПродажа {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Разделы", Comment = "", Synonym = "Разделы")]
        public List<ГТДИмпорт_Разделы> ГТДИмпортРазделы {get;set;}
        [Description1C8(Name = "Оборудование", Comment = "(Общ)", Synonym = "Оборудование")]
        public List<ГТДИмпорт_Оборудование> ГТДИмпортОборудование {get;set;}
        [Description1C8(Name = "Товары", Comment = "", Synonym = "Товары")]
        public List<ГТДИмпорт_Товары> ГТДИмпортТовары {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Разделы", Comment = "", Synonym = "Разделы")]
    [Table("HTDYmport_Razdely")]
    public class ГТДИмпорт_Разделы
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ТаможеннаяСтоимость", Comment = "", Synonym = "Таможенная стоимость")]
        // Format 15.2
        public decimal ТаможеннаяСтоимость {get; set;}
        [Description1C8(Name = "СтавкаПошлины", Comment = "", Synonym = "Ставка пошлины")]
        // Format 5.2
        public decimal СтавкаПошлины {get; set;}
        [Description1C8(Name = "СуммаПошлины", Comment = "", Synonym = "Сумма пошлины")]
        // Format 15.2
        public decimal СуммаПошлины {get; set;}
        [Description1C8(Name = "СтавкаНДС", Comment = "", Synonym = "% НДС")]
        public Enums.СтавкиНДС СтавкаНДС {get; set;}
        [Description1C8(Name = "СуммаНДС", Comment = "", Synonym = "Сумма НДС")]
        // Format 15.2
        public decimal СуммаНДС {get; set;}
        [Description1C8(Name = "СтавкаАкциза", Comment = "", Synonym = "Ставка акциза")]
        // Format 5.2
        public decimal СтавкаАкциза {get; set;}
        [Description1C8(Name = "СуммаАкциза", Comment = "", Synonym = "Сумма акциза")]
        // Format 15.2
        public decimal СуммаАкциза {get; set;}
    }
    [Description1C8(Name = "Оборудование", Comment = "(Общ)", Synonym = "Оборудование")]
    [Table("HTDYmport_Oborudovanye")]
    public class ГТДИмпорт_Оборудование
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "НомерРаздела", Comment = "", Synonym = "Номер раздела")]
        // Format 2.0
        public long НомерРаздела {get; set;}
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
        [Description1C8(Name = "ФактурнаяСтоимость", Comment = "Суммарная стоимость позиции по документам поставщика в валюте документа", Synonym = "Фактурная стоимость")]
        // Format 15.2
        public decimal ФактурнаяСтоимость {get; set;}
        [Description1C8(Name = "ДокументПартии", Comment = "", Synonym = "Документ партии")]
        public Документ.ПоступлениеТоваровУслуг ДокументПартии {get; set;}
        [Description1C8(Name = "СуммаПошлины", Comment = "", Synonym = "Сумма пошлины")]
        // Format 15.2
        public decimal СуммаПошлины {get; set;}
        [Description1C8(Name = "СуммаАкциза", Comment = "", Synonym = "Сумма акциза")]
        // Format 15.2
        public decimal СуммаАкциза {get; set;}
        [Description1C8(Name = "СуммаНДС", Comment = "", Synonym = "Сумма НДС")]
        // Format 15.2
        public decimal СуммаНДС {get; set;}
        [Description1C8(Name = "СчетУчетаБУ", Comment = "", Synonym = "Счет учета")]
        public ПланСчетов.Хозрасчетный СчетУчетаБУ {get; set;}
        [Description1C8(Name = "СчетУчетаНДС", Comment = "", Synonym = "Счет НДС")]
        public ПланСчетов.Хозрасчетный СчетУчетаНДС {get; set;}
        [Description1C8(Name = "СтатьяДекларацииНДСНалоговыйКредит", Comment = "", Synonym = "Статья декларации НДС (н/к)")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяДекларацииНДСНалоговыйКредит {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
    }
    [Description1C8(Name = "Товары", Comment = "", Synonym = "Товары")]
    [Table("HTDYmport_Tovary")]
    public class ГТДИмпорт_Товары
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
        [Description1C8(Name = "ФактурнаяСтоимость", Comment = "", Synonym = "Фактурная стоимость")]
        // Format 15.2
        public decimal ФактурнаяСтоимость {get; set;}
        [Description1C8(Name = "СуммаПошлины", Comment = "", Synonym = "Сумма пошлины")]
        // Format 15.2
        public decimal СуммаПошлины {get; set;}
        [Description1C8(Name = "СуммаНДС", Comment = "", Synonym = "Сумма НДС")]
        // Format 15.2
        public decimal СуммаНДС {get; set;}
        [Description1C8(Name = "ДокументПартии", Comment = "", Synonym = "Документ партии")]
        public Документ.ПоступлениеТоваровУслуг ДокументПартии {get; set;}
        [Description1C8(Name = "СуммаАкциза", Comment = "", Synonym = "Сумма акциза")]
        // Format 15.2
        public decimal СуммаАкциза {get; set;}
        [Description1C8(Name = "НомерРаздела", Comment = "", Synonym = "Номер раздела")]
        // Format 2.0
        public long НомерРаздела {get; set;}
        [Description1C8(Name = "СчетУчетаБУ", Comment = "", Synonym = "Счет учета")]
        public ПланСчетов.Хозрасчетный СчетУчетаБУ {get; set;}
        [Description1C8(Name = "СчетУчетаНДС", Comment = "", Synonym = "Счет НДС")]
        public ПланСчетов.Хозрасчетный СчетУчетаНДС {get; set;}
        [Description1C8(Name = "СтатьяДекларацииНДСНалоговыйКредит", Comment = "", Synonym = "Статья декларации НДС (н/к)")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяДекларацииНДСНалоговыйКредит {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
    }
}
