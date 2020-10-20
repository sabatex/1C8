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
    [Table("NalohovaiaNakladnaia")]
    [Description1C8(Name = "НалоговаяНакладная", Comment = "(Регл)", Synonym = "Налоговая накладная")]
    public class НалоговаяНакладная:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "ВидОперации", Comment = "", Synonym = "Вид операции")]
        public Enums.ВидыОперацийНалоговаяНакладная ВидОперации {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Контрагент", Comment = "(Общ)", Synonym = "Контрагент")]
        public Catalogs.Контрагенты Контрагент {get; set;}
        [Description1C8(Name = "ДоговорКонтрагента", Comment = "(Общ)", Synonym = "Договор")]
        public Catalogs.ДоговорыКонтрагентов ДоговорКонтрагента {get; set;}
        [Description1C8(Name = "ТипЦен", Comment = "(Общ)", Synonym = "Тип цен")]
        public Catalogs.ТипыЦенНоменклатуры ТипЦен {get; set;}
        [Description1C8(Name = "ВалютаДокумента", Comment = "(Общ)", Synonym = "Валюта")]
        public Catalogs.Валюты ВалютаДокумента {get; set;}
        [Description1C8(Name = "УдалитьУчитыватьНДС", Comment = "(Общ)", Synonym = "(не используется) Учитывать НДС")]
        public bool УдалитьУчитыватьНДС {get; set;}
        [Description1C8(Name = "СуммаВключаетНДС", Comment = "(Общ)", Synonym = "Сумма включает НДС")]
        public bool СуммаВключаетНДС {get; set;}
        [Description1C8(Name = "КурсВзаиморасчетов", Comment = "(Общ)", Synonym = "Курс взаиморасчетов")]
        // Format 10.4
        public decimal КурсВзаиморасчетов {get; set;}
        [Description1C8(Name = "СуммаДокумента", Comment = "(Общ) Сумма в валюте документа, налоги включены согласно флагам", Synonym = "Сумма")]
        // Format 15.2
        public decimal СуммаДокумента {get; set;}
        [Description1C8(Name = "СуммаНДСДокумента", Comment = "(Общ) Сумма НДС в валюте документа", Synonym = "Сумма НДС документа")]
        // Format 15.2
        public decimal СуммаНДСДокумента {get; set;}
        [Description1C8(Name = "КратностьВзаиморасчетов", Comment = "(Общ)", Synonym = "Кратность взаиморасчетов")]
        // Format 10.0
        public long КратностьВзаиморасчетов {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "(Общ)", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "ЛьготаНДС", Comment = "Льгота по НДС", Synonym = "Льгота по НДС")]
        [StringLength(128)]
        public string ЛьготаНДС {get; set;}
        [Description1C8(Name = "ДокументОснование", Comment = "", Synonym = "Документ-основание")]
        public Документ.СписаниеОС ДокументОснование {get; set;}
        [Description1C8(Name = "УсловиеПродажи", Comment = "Форма гражданско-правового соглашения", Synonym = "Условие продажи")]
        [StringLength(100)]
        public string УсловиеПродажи {get; set;}
        [Description1C8(Name = "ФормаРасчетов", Comment = "", Synonym = "Форма расчетов")]
        [StringLength(50)]
        public string ФормаРасчетов {get; set;}
        [Description1C8(Name = "СчетНДС", Comment = "(Регл)", Synonym = "Счет НДС")]
        public ПланСчетов.Хозрасчетный СчетНДС {get; set;}
        [Description1C8(Name = "СубконтоКт1", Comment = "(Регл)", Synonym = "Субконто 1")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоКт1 {get; set;}
        [Description1C8(Name = "СубконтоКт2", Comment = "(Регл)", Synonym = "Субконто 2")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоКт2 {get; set;}
        [Description1C8(Name = "СубконтоКт3", Comment = "(Регл)", Synonym = "Субконто 3")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоКт3 {get; set;}
        [Description1C8(Name = "КтоВыписалНалоговуюНакладную", Comment = "", Synonym = "Кто выписал налоговую накладную")]
        public Catalogs.ФизическиеЛица КтоВыписалНалоговуюНакладную {get; set;}
        [Description1C8(Name = "АвторасчетНДС", Comment = "", Synonym = "Авторасчет НДС")]
        public bool АвторасчетНДС {get; set;}
        [Description1C8(Name = "ПродажаНижеОбычнойЦены", Comment = "", Synonym = "Продажа ниже обычной цены")]
        public bool ПродажаНижеОбычнойЦены {get; set;}
        [Description1C8(Name = "ТекстДополненияКНаименованиюПриПродажеНижеОбычнойЦены", Comment = "", Synonym = "Текст дополнения к наименованию при продаже ниже обычной цены")]
        [StringLength(300)]
        public string ТекстДополненияКНаименованиюПриПродажеНижеОбычнойЦены {get; set;}
        [Description1C8(Name = "СчетДт", Comment = "(Регл)", Synonym = "Счет затрат (вычета из дохода)")]
        public ПланСчетов.Хозрасчетный СчетДт {get; set;}
        [Description1C8(Name = "СубконтоДт1", Comment = "(Регл)", Synonym = "Субконто 1")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоДт1 {get; set;}
        [Description1C8(Name = "СубконтоДт2", Comment = "(Регл)", Synonym = "Субконто 2")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоДт2 {get; set;}
        [Description1C8(Name = "СубконтоДт3", Comment = "(Регл)", Synonym = "Субконто 3")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоДт3 {get; set;}
        [Description1C8(Name = "РучнаяКорректировка", Comment = "", Synonym = "Ручная корректировка")]
        public bool РучнаяКорректировка {get; set;}
        [Description1C8(Name = "Сделка", Comment = "(Общ)", Synonym = "Документ расчетов")]
        public Документ.ПлатежныйОрдерСписаниеДенежныхСредств Сделка {get; set;}
        [Description1C8(Name = "СчетУчетаНДС", Comment = "(Регл)", Synonym = "Счет НДС (неподтвержденный)")]
        public ПланСчетов.Хозрасчетный СчетУчетаНДС {get; set;}
        [Description1C8(Name = "ДокументВводаНаОсновании", Comment = "(Общ)", Synonym = "Документ ввода на основании")]
        public Документ.СписаниеОС ДокументВводаНаОсновании {get; set;}
        [Description1C8(Name = "ВключаетсяВУточняющийРасчет", Comment = "", Synonym = "Включается в уточняющий расчет")]
        public bool ВключаетсяВУточняющийРасчет {get; set;}
        [Description1C8(Name = "ПодтверждаетсяГТД", Comment = "", Synonym = "Подтверждается ГТД")]
        public bool ПодтверждаетсяГТД {get; set;}
        [Description1C8(Name = "НомерГТД", Comment = "", Synonym = "Номер ГТД")]
        [StringLength(21)]
        public string НомерГТД {get; set;}
        [Description1C8(Name = "ВключенаВЕдиныйРеестрНалоговыхНакладных", Comment = "", Synonym = "Включена в Единый реестр налоговых накладных")]
        public bool ВключенаВЕдиныйРеестрНалоговыхНакладных {get; set;}
        [Description1C8(Name = "ТипПричиныНевыдачиПокупателю", Comment = "", Synonym = "Тип причины невыдачи накладной покупателю")]
        // Format 2.0
        public long ТипПричиныНевыдачиПокупателю {get; set;}
        [Description1C8(Name = "ВидДоговора", Comment = "", Synonym = "Вид договора")]
        public string ВидДоговора {get; set;}
        [Description1C8(Name = "СпецРежимНалогообложения", Comment = "", Synonym = "Спец режим налогообложения")]
        // Format 1.0
        public long СпецРежимНалогообложения {get; set;}
        [Description1C8(Name = "НалоговаяДляРезерваНомераПриПродажаНижеОбычнойЦены", Comment = "", Synonym = "Налоговая для резерва номера при продаже ниже обычной цены")]
        public Документ.НалоговаяНакладная НалоговаяДляРезерваНомераПриПродажаНижеОбычнойЦены {get; set;}
        [Description1C8(Name = "ОсновнаяНалоговаяПриРезервеНомераПриПродажаНижеОбычнойЦены", Comment = "", Synonym = "Основная налоговая при резерве номера при продаже ниже обычной цены")]
        public Документ.НалоговаяНакладная ОсновнаяНалоговаяПриРезервеНомераПриПродажаНижеОбычнойЦены {get; set;}
        [Description1C8(Name = "УточняемыйПериод", Comment = "", Synonym = "Уточняемый период")]
        public DateTime УточняемыйПериод {get; set;}
        [Description1C8(Name = "НалоговоеНазначениеДоходовИЗатрат", Comment = "", Synonym = "Налоговое назначение доходов и затрат")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначениеДоходовИЗатрат {get; set;}
        [Description1C8(Name = "ТребуетВключенияВЕдиныйРеестрНалоговыхНакладных", Comment = "", Synonym = "Подлежит включению в Единый реестр налоговых накладных")]
        public bool ТребуетВключенияВЕдиныйРеестрНалоговыхНакладных {get; set;}
        [Description1C8(Name = "УслугиНерезидентаДляНехозДеят", Comment = "", Synonym = "Услуги нерезидента предназначаются для нехоз. деятельности")]
        public bool УслугиНерезидентаДляНехозДеят {get; set;}
        [Description1C8(Name = "ОбособленноеПодразделение", Comment = "", Synonym = "Обособленное подразделение")]
        public Catalogs.ОбособленныеПодразделенияОрганизаций ОбособленноеПодразделение {get; set;}
        [Description1C8(Name = "ЭлектронныйДокумент", Comment = "", Synonym = "Электронный документ")]
        public bool ЭлектронныйДокумент {get; set;}
        [Description1C8(Name = "ЛьготаНДСОписание", Comment = "Льгота по НДС", Synonym = "Название операции (для приложения Д6)")]
        [StringLength(128)]
        public string ЛьготаНДСОписание {get; set;}
        [Description1C8(Name = "НомерДляРеестра", Comment = "", Synonym = "Номер в реестре")]
        [StringLength(13)]
        public string НомерДляРеестра {get; set;}
        [Description1C8(Name = "ДатаДляРеестра", Comment = "", Synonym = "Дата в реестре")]
        public DateTime ДатаДляРеестра {get; set;}
        [Description1C8(Name = "ТипПричиныНевыдачиПокупателюПриПродажеНижеОбычнойЦены", Comment = "", Synonym = "Тип причины невыдачи накладной покупателю (для накладной по 'обычным ценам')")]
        // Format 2.0
        public long ТипПричиныНевыдачиПокупателюПриПродажеНижеОбычнойЦены {get; set;}
        [Description1C8(Name = "ПоставкаДипПредставительству", Comment = "", Synonym = "Поставка дипломатическому представительству")]
        public bool ПоставкаДипПредставительству {get; set;}
        [Description1C8(Name = "Сводная", Comment = "", Synonym = "Сводная налоговая накладная")]
        public bool Сводная {get; set;}
        [Description1C8(Name = "КодПризнакаСводной", Comment = "", Synonym = "Код признака сводной налоговой накладной")]
        // Format 1.0
        public long КодПризнакаСводной {get; set;}
        [Description1C8(Name = "РеквизитыНомерСтрокиННАктуальны", Comment = "", Synonym = "Реквизиты номер строки НН актуальны")]
        public bool РеквизитыНомерСтрокиННАктуальны {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Товары", Comment = "(Общ)", Synonym = "Товары")]
        public List<НалоговаяНакладная_Товары> НалоговаяНакладнаяТовары {get;set;}
        [Description1C8(Name = "Услуги", Comment = "(Общ)", Synonym = "Услуги")]
        public List<НалоговаяНакладная_Услуги> НалоговаяНакладнаяУслуги {get;set;}
        [Description1C8(Name = "ОС", Comment = "(Общ)", Synonym = "ОС")]
        public List<НалоговаяНакладная_ОС> НалоговаяНакладнаяОС {get;set;}
        [Description1C8(Name = "НМА", Comment = "(Общ)", Synonym = "НМА")]
        public List<НалоговаяНакладная_НМА> НалоговаяНакладнаяНМА {get;set;}
        [Description1C8(Name = "ВозвратнаяТара", Comment = "(Общ)", Synonym = "Возвратная тара")]
        public List<НалоговаяНакладная_ВозвратнаяТара> НалоговаяНакладнаяВозвратнаяТара {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Товары", Comment = "(Общ)", Synonym = "Товары")]
    [Table("NalohovaiaNakladnaia_Tovary")]
    public class НалоговаяНакладная_Товары
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
        [Description1C8(Name = "СтавкаНДС", Comment = "(Общ)", Synonym = "% НДС")]
        public Enums.СтавкиНДС СтавкаНДС {get; set;}
        [Description1C8(Name = "СуммаНДС", Comment = "(Общ)", Synonym = "Сумма НДС")]
        // Format 15.2
        public decimal СуммаНДС {get; set;}
        [Description1C8(Name = "Сумма", Comment = "(Общ)", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "СчетУчетаНДС", Comment = "(Регл)", Synonym = "Счет учета НДС")]
        public ПланСчетов.Хозрасчетный СчетУчетаНДС {get; set;}
        [Description1C8(Name = "ДатаОтгрузкиОплаты", Comment = "", Synonym = "Дата отгрузки оплаты")]
        public DateTime ДатаОтгрузкиОплаты {get; set;}
        [Description1C8(Name = "СтатьяДекларацииНДСНалоговыеОбязательства", Comment = "", Synonym = "Статья декларации НДС (н/о)")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяДекларацииНДСНалоговыеОбязательства {get; set;}
        [Description1C8(Name = "ЦенаОбычная", Comment = "", Synonym = "Цена обычная (без НДС)")]
        // Format 15.2
        public decimal ЦенаОбычная {get; set;}
        [Description1C8(Name = "СуммаПревышения", Comment = "", Synonym = "Сумма превышения")]
        // Format 15.2
        public decimal СуммаПревышения {get; set;}
        [Description1C8(Name = "СуммаНДСПревышения", Comment = "", Synonym = "Сумма НДС превышения")]
        // Format 15.2
        public decimal СуммаНДСПревышения {get; set;}
        [Description1C8(Name = "СуммаБезСкидки", Comment = "(Общ)", Synonym = "Сумма без скидки")]
        // Format 15.2
        public decimal СуммаБезСкидки {get; set;}
        [Description1C8(Name = "СуммаСкидки", Comment = "(Общ)", Synonym = "Сумма скидки")]
        // Format 15.2
        public decimal СуммаСкидки {get; set;}
        [Description1C8(Name = "КодУКТВЭД", Comment = "", Synonym = "Код")]
        public Catalogs.КлассификаторУКТВЭД КодУКТВЭД {get; set;}
        [Description1C8(Name = "НомерГТД", Comment = "", Synonym = "Номер ГТД")]
        public Catalogs.НомераГТД НомерГТД {get; set;}
        [Description1C8(Name = "ОсновнаяНН", Comment = "", Synonym = "Основная НН")]
        public Документ.НалоговаяНакладная ОсновнаяНН {get; set;}
        [Description1C8(Name = "НомерСтрокиНН", Comment = "", Synonym = "Номер строки НН")]
        // Format 4.0
        public long НомерСтрокиНН {get; set;}
    }
    [Description1C8(Name = "Услуги", Comment = "(Общ)", Synonym = "Услуги")]
    [Table("NalohovaiaNakladnaia_Usluhy")]
    public class НалоговаяНакладная_Услуги
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Номенклатура", Comment = "(Общ)", Synonym = "Номенклатура")]
        public Catalogs.Номенклатура Номенклатура {get; set;}
        [Description1C8(Name = "Цена", Comment = "(Общ)", Synonym = "Цена")]
        // Format 15.2
        public decimal Цена {get; set;}
        [Description1C8(Name = "Содержание", Comment = "(Общ)", Synonym = "Содержание услуги, доп. сведения")]
        [StringLength(1000)]
        public string Содержание {get; set;}
        [Description1C8(Name = "СтавкаНДС", Comment = "(Общ)", Synonym = "% НДС")]
        public Enums.СтавкиНДС СтавкаНДС {get; set;}
        [Description1C8(Name = "СуммаНДС", Comment = "(Общ)", Synonym = "Сумма НДС")]
        // Format 15.2
        public decimal СуммаНДС {get; set;}
        [Description1C8(Name = "ДатаОтгрузкиОплаты", Comment = "", Synonym = "Дата отгрузки оплаты")]
        public DateTime ДатаОтгрузкиОплаты {get; set;}
        [Description1C8(Name = "СтатьяДекларацииНДСНалоговыеОбязательства", Comment = "", Synonym = "Статья декларации НДС (н/о)")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяДекларацииНДСНалоговыеОбязательства {get; set;}
        [Description1C8(Name = "ЦенаОбычная", Comment = "", Synonym = "Цена обычная (без НДС)")]
        // Format 15.2
        public decimal ЦенаОбычная {get; set;}
        [Description1C8(Name = "СуммаПревышения", Comment = "", Synonym = "Сумма превышения")]
        // Format 15.2
        public decimal СуммаПревышения {get; set;}
        [Description1C8(Name = "СуммаНДСПревышения", Comment = "", Synonym = "Сумма НДС превышения")]
        // Format 15.2
        public decimal СуммаНДСПревышения {get; set;}
        [Description1C8(Name = "СуммаБезСкидки", Comment = "(Общ)", Synonym = "Сумма без скидки")]
        // Format 15.2
        public decimal СуммаБезСкидки {get; set;}
        [Description1C8(Name = "СуммаСкидки", Comment = "(Общ)", Synonym = "Сумма скидки")]
        // Format 15.2
        public decimal СуммаСкидки {get; set;}
        [Description1C8(Name = "Количество", Comment = "(Общ)", Synonym = "Количество")]
        // Format 15.3
        public decimal Количество {get; set;}
        [Description1C8(Name = "Сумма", Comment = "(Общ)", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "КодУКТВЭД", Comment = "", Synonym = "Код")]
        public Catalogs.КлассификаторУКТВЭД КодУКТВЭД {get; set;}
        [Description1C8(Name = "ОсновнаяНН", Comment = "", Synonym = "Основная НН")]
        public Документ.НалоговаяНакладная ОсновнаяНН {get; set;}
        [Description1C8(Name = "НомерСтрокиНН", Comment = "", Synonym = "Номер строки НН")]
        // Format 4.0
        public long НомерСтрокиНН {get; set;}
    }
    [Description1C8(Name = "ОС", Comment = "(Общ)", Synonym = "ОС")]
    [Table("NalohovaiaNakladnaia_OS")]
    public class НалоговаяНакладная_ОС
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ОсновноеСредство", Comment = "(Общ)", Synonym = "Основное средство")]
        public Catalogs.ОсновныеСредства ОсновноеСредство {get; set;}
        [Description1C8(Name = "Сумма", Comment = "(Общ)", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "СтавкаНДС", Comment = "(Общ)", Synonym = "% НДС")]
        public Enums.СтавкиНДС СтавкаНДС {get; set;}
        [Description1C8(Name = "СуммаНДС", Comment = "(Общ)", Synonym = "Сумма НДС")]
        // Format 15.2
        public decimal СуммаНДС {get; set;}
        [Description1C8(Name = "ДатаОтгрузкиОплаты", Comment = "", Synonym = "Дата отгрузки оплаты")]
        public DateTime ДатаОтгрузкиОплаты {get; set;}
        [Description1C8(Name = "СтатьяДекларацииНДСНалоговыеОбязательства", Comment = "", Synonym = "Статья декларации НДС (н/о)")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяДекларацииНДСНалоговыеОбязательства {get; set;}
        [Description1C8(Name = "ЦенаОбычная", Comment = "", Synonym = "Цена обычная (без НДС)")]
        // Format 15.2
        public decimal ЦенаОбычная {get; set;}
        [Description1C8(Name = "СуммаПревышения", Comment = "", Synonym = "Сумма превышения")]
        // Format 15.2
        public decimal СуммаПревышения {get; set;}
        [Description1C8(Name = "СуммаНДСПревышения", Comment = "", Synonym = "Сумма НДС превышения")]
        // Format 15.2
        public decimal СуммаНДСПревышения {get; set;}
        [Description1C8(Name = "УДЛАИТЬСчетУчетаНДС", Comment = "(Регл)", Synonym = "УДЛАИТЬСчет учета НДС")]
        public ПланСчетов.Хозрасчетный УДЛАИТЬСчетУчетаНДС {get; set;}
        [Description1C8(Name = "КодУКТВЭД", Comment = "", Synonym = "Код")]
        public Catalogs.КлассификаторУКТВЭД КодУКТВЭД {get; set;}
        [Description1C8(Name = "НомерГТД", Comment = "", Synonym = "Номер ГТД")]
        public Catalogs.НомераГТД НомерГТД {get; set;}
        [Description1C8(Name = "Количество", Comment = "при частичной поставке", Synonym = "Количество")]
        // Format 15.3
        public decimal Количество {get; set;}
        [Description1C8(Name = "Цена", Comment = "при частичной поставке", Synonym = "Цена")]
        // Format 15.2
        public decimal Цена {get; set;}
        [Description1C8(Name = "НомерСтрокиНН", Comment = "", Synonym = "Номер строки НН")]
        // Format 4.0
        public long НомерСтрокиНН {get; set;}
    }
    [Description1C8(Name = "НМА", Comment = "(Общ)", Synonym = "НМА")]
    [Table("NalohovaiaNakladnaia_NMA")]
    public class НалоговаяНакладная_НМА
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "НематериальныйАктив", Comment = "(Регл)", Synonym = "Нематериальный актив")]
        public Catalogs.НематериальныеАктивы НематериальныйАктив {get; set;}
        [Description1C8(Name = "Сумма", Comment = "(Общ)", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "СтавкаНДС", Comment = "(Общ)", Synonym = "% НДС")]
        public Enums.СтавкиНДС СтавкаНДС {get; set;}
        [Description1C8(Name = "СуммаНДС", Comment = "(Общ)", Synonym = "Сумма НДС")]
        // Format 15.2
        public decimal СуммаНДС {get; set;}
        [Description1C8(Name = "ДатаОтгрузкиОплаты", Comment = "", Synonym = "Дата отгрузки оплаты")]
        public DateTime ДатаОтгрузкиОплаты {get; set;}
        [Description1C8(Name = "СтатьяДекларацииНДСНалоговыеОбязательства", Comment = "", Synonym = "Статья декларации НДС (н/о)")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяДекларацииНДСНалоговыеОбязательства {get; set;}
        [Description1C8(Name = "ЦенаОбычная", Comment = "", Synonym = "Цена обычная (без НДС)")]
        // Format 15.2
        public decimal ЦенаОбычная {get; set;}
        [Description1C8(Name = "СуммаПревышения", Comment = "", Synonym = "Сумма превышения")]
        // Format 15.2
        public decimal СуммаПревышения {get; set;}
        [Description1C8(Name = "СуммаНДСПревышения", Comment = "", Synonym = "Сумма НДС превышения")]
        // Format 15.2
        public decimal СуммаНДСПревышения {get; set;}
        [Description1C8(Name = "КодУКТВЭД", Comment = "", Synonym = "Код")]
        public Catalogs.КлассификаторУКТВЭД КодУКТВЭД {get; set;}
        [Description1C8(Name = "НомерГТД", Comment = "", Synonym = "Номер ГТД")]
        public Catalogs.НомераГТД НомерГТД {get; set;}
        [Description1C8(Name = "Количество", Comment = "при частичной поставке", Synonym = "Количество")]
        // Format 15.3
        public decimal Количество {get; set;}
        [Description1C8(Name = "Цена", Comment = "при частичной поставке", Synonym = "Цена")]
        // Format 15.2
        public decimal Цена {get; set;}
        [Description1C8(Name = "НомерСтрокиНН", Comment = "", Synonym = "Номер строки НН")]
        // Format 4.0
        public long НомерСтрокиНН {get; set;}
    }
    [Description1C8(Name = "ВозвратнаяТара", Comment = "(Общ)", Synonym = "Возвратная тара")]
    [Table("NalohovaiaNakladnaia_VozvratnaiaTara")]
    public class НалоговаяНакладная_ВозвратнаяТара
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
    }
}
