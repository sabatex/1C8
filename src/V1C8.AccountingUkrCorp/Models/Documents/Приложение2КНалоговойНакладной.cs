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
    [Table("Prylozhenye2KNalohovoiNakladnoi")]
    [Description1C8(Name = "Приложение2КНалоговойНакладной", Comment = "(Регл)", Synonym = "Приложение 2 к налоговой накладной")]
    public class Приложение2КНалоговойНакладной:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "ВидОперации", Comment = "", Synonym = "Вид операции")]
        public Enums.ВидыОперацийПриложение2КНалоговойНакладной ВидОперации {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Контрагент", Comment = "(Общ)", Synonym = "Контрагент")]
        public Catalogs.Контрагенты Контрагент {get; set;}
        [Description1C8(Name = "ДоговорКонтрагента", Comment = "(Общ)", Synonym = "Договор контрагента")]
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
        [Description1C8(Name = "НалоговаяНакладная", Comment = "", Synonym = "Налоговая накладная")]
        public Documents.НалоговаяНакладная НалоговаяНакладная {get; set;}
        [Description1C8(Name = "ДокументОснование", Comment = "", Synonym = "Документ-основание")]
        public Documents.ПлатежныйОрдерСписаниеДенежныхСредств ДокументОснование {get; set;}
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
        [Description1C8(Name = "РучнаяКорректировка", Comment = "", Synonym = "Ручная корректировка")]
        public bool РучнаяКорректировка {get; set;}
        [Description1C8(Name = "Сделка", Comment = "(Общ)", Synonym = "Документ расчетов")]
        public Documents.ПлатежныйОрдерСписаниеДенежныхСредств Сделка {get; set;}
        [Description1C8(Name = "СчетУчетаНДС", Comment = "(Регл)", Synonym = "Счет НДС (неподтвержденный)")]
        public ПланСчетов.Хозрасчетный СчетУчетаНДС {get; set;}
        [Description1C8(Name = "ВключаетсяВУточняющийРасчет", Comment = "", Synonym = "Включается в уточняющий расчет")]
        public bool ВключаетсяВУточняющийРасчет {get; set;}
        [Description1C8(Name = "ВидДоговора", Comment = "", Synonym = "Вид договора")]
        public string ВидДоговора {get; set;}
        [Description1C8(Name = "ТипПричиныНевыдачиПокупателю", Comment = "", Synonym = "Тип причины невыдачи накладной покупателю")]
        // Format 2.0
        public long ТипПричиныНевыдачиПокупателю {get; set;}
        [Description1C8(Name = "СпецРежимНалогообложения", Comment = "", Synonym = "Спец режим налогообложения")]
        // Format 1.0
        public long СпецРежимНалогообложения {get; set;}
        [Description1C8(Name = "УточняемыйПериод", Comment = "", Synonym = "Уточняемый период")]
        public DateTime УточняемыйПериод {get; set;}
        [Description1C8(Name = "ОснованиеКорректировки", Comment = "(Общ) Любая дополнительная информация", Synonym = "Основание корректировки")]
        public string ОснованиеКорректировки {get; set;}
        [Description1C8(Name = "ВключенаВЕдиныйРеестрНалоговыхНакладных", Comment = "", Synonym = "Включено в Единый реестр налоговых накладных")]
        public bool ВключенаВЕдиныйРеестрНалоговыхНакладных {get; set;}
        [Description1C8(Name = "ТребуетВключенияВЕдиныйРеестрНалоговыхНакладных", Comment = "", Synonym = "Подлежит включению в Единый реестр налоговых накладных")]
        public bool ТребуетВключенияВЕдиныйРеестрНалоговыхНакладных {get; set;}
        [Description1C8(Name = "ДатаОплаты", Comment = "", Synonym = "Дата оплаты")]
        public DateTime ДатаОплаты {get; set;}
        [Description1C8(Name = "ДатаПолученияПокупателем", Comment = "", Synonym = "Дата получения покупателем")]
        public DateTime ДатаПолученияПокупателем {get; set;}
        [Description1C8(Name = "ДатаПолученияПокупателемНеРавнаДатеДокумента", Comment = "", Synonym = "Дата получения покупателем не равна дате документа")]
        public bool ДатаПолученияПокупателемНеРавнаДатеДокумента {get; set;}
        [Description1C8(Name = "ЭлектронныйДокумент", Comment = "", Synonym = "Электронный документ")]
        public bool ЭлектронныйДокумент {get; set;}
        [Description1C8(Name = "НомерДляРеестра", Comment = "", Synonym = "Номер в реестре")]
        [StringLength(13)]
        public string НомерДляРеестра {get; set;}
        [Description1C8(Name = "ДатаДляРеестра", Comment = "", Synonym = "Дата в реестре")]
        public DateTime ДатаДляРеестра {get; set;}
        [Description1C8(Name = "ДатаВключенияВЕдиныйРеестрНалоговыхНакладных", Comment = "", Synonym = "Дата включения в единый реестр налоговых накладных")]
        public DateTime ДатаВключенияВЕдиныйРеестрНалоговыхНакладных {get; set;}
        [Description1C8(Name = "РегистрируетсяВЕРННПокупателем", Comment = "", Synonym = "Регистрируется в ЕРНН покупателем")]
        public bool РегистрируетсяВЕРННПокупателем {get; set;}
        [Description1C8(Name = "СчетДт", Comment = "(Регл)", Synonym = "Счет затрат (вычета из дохода)")]
        public ПланСчетов.Хозрасчетный СчетДт {get; set;}
        [Description1C8(Name = "СубконтоДт1", Comment = "(Регл)", Synonym = "Субконто 1")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоДт1 {get; set;}
        [Description1C8(Name = "СубконтоДт2", Comment = "(Регл)", Synonym = "Субконто 2")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоДт2 {get; set;}
        [Description1C8(Name = "СубконтоДт3", Comment = "(Регл)", Synonym = "Субконто 3")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоДт3 {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Товары", Comment = "(Общ)", Synonym = "Товары")]
        public List<Приложение2КНалоговойНакладной_Товары> Приложение2КНалоговойНакладнойТовары {get;set;}
        [Description1C8(Name = "Услуги", Comment = "(Общ)", Synonym = "Услуги")]
        public List<Приложение2КНалоговойНакладной_Услуги> Приложение2КНалоговойНакладнойУслуги {get;set;}
        [Description1C8(Name = "ОС", Comment = "(Общ)", Synonym = "ОС")]
        public List<Приложение2КНалоговойНакладной_ОС> Приложение2КНалоговойНакладнойОС {get;set;}
        [Description1C8(Name = "ВозвратнаяТара", Comment = "(Общ)", Synonym = "Возвратная тара")]
        public List<Приложение2КНалоговойНакладной_ВозвратнаяТара> Приложение2КНалоговойНакладнойВозвратнаяТара {get;set;}
        [Description1C8(Name = "НМА", Comment = "(Общ)", Synonym = "НМА")]
        public List<Приложение2КНалоговойНакладной_НМА> Приложение2КНалоговойНакладнойНМА {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Товары", Comment = "(Общ)", Synonym = "Товары")]
    [Table("Prylozhenye2KNalohovoiNakladnoi_Tovary")]
    public class Приложение2КНалоговойНакладной_Товары
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Номенклатура", Comment = "(Общ)", Synonym = "Номенклатура")]
        public Catalogs.Номенклатура Номенклатура {get; set;}
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
        [Description1C8(Name = "ИзменениеКоличества", Comment = "", Synonym = "Изменение количества")]
        // Format 15.3
        public decimal ИзменениеКоличества {get; set;}
        [Description1C8(Name = "ИзменениеЦены", Comment = "", Synonym = "Изменение цены")]
        // Format 15.2
        public decimal ИзменениеЦены {get; set;}
        [Description1C8(Name = "ИзменениеСуммы", Comment = "", Synonym = "Изменение суммы")]
        // Format 15.2
        public decimal ИзменениеСуммы {get; set;}
        [Description1C8(Name = "ИзменениеСуммыНДС", Comment = "", Synonym = "Изменение суммы НДС")]
        // Format 15.2
        public decimal ИзменениеСуммыНДС {get; set;}
        [Description1C8(Name = "Причина", Comment = "", Synonym = "Причина корректировки")]
        [StringLength(100)]
        public string Причина {get; set;}
        [Description1C8(Name = "СтатьяДекларацииНДСНалоговыеОбязательства", Comment = "", Synonym = "Статья декларации НДС (н/о)")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяДекларацииНДСНалоговыеОбязательства {get; set;}
        [Description1C8(Name = "ДатаКорректировки", Comment = "", Synonym = "Дата корректировки")]
        public DateTime ДатаКорректировки {get; set;}
        [Description1C8(Name = "ЕдиницаИзмерения", Comment = "(Общ)", Synonym = "Единица измерения")]
        public Catalogs.КлассификаторЕдиницИзмерения ЕдиницаИзмерения {get; set;}
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
        [Description1C8(Name = "НомерСтрокиНН", Comment = "", Synonym = "Номер строки НН")]
        // Format 7.0
        public long НомерСтрокиНН {get; set;}
        [Description1C8(Name = "НомерГруппы", Comment = "", Synonym = "Номер группы корректировки")]
        // Format 4.0
        public long НомерГруппы {get; set;}
        [Description1C8(Name = "КодПричины", Comment = "", Synonym = "Код причины корректировки")]
        // Format 3.0
        public long КодПричины {get; set;}
    }
    [Description1C8(Name = "Услуги", Comment = "(Общ)", Synonym = "Услуги")]
    [Table("Prylozhenye2KNalohovoiNakladnoi_Usluhy")]
    public class Приложение2КНалоговойНакладной_Услуги
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Номенклатура", Comment = "(Общ)", Synonym = "Номенклатура")]
        public Catalogs.Номенклатура Номенклатура {get; set;}
        [Description1C8(Name = "Содержание", Comment = "(Общ)", Synonym = "Содержание услуги, доп. сведения")]
        [StringLength(1000)]
        public string Содержание {get; set;}
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
        [Description1C8(Name = "ИзменениеКоличества", Comment = "", Synonym = "Изменение количества")]
        // Format 15.3
        public decimal ИзменениеКоличества {get; set;}
        [Description1C8(Name = "ИзменениеЦены", Comment = "", Synonym = "Изменение цены")]
        // Format 15.2
        public decimal ИзменениеЦены {get; set;}
        [Description1C8(Name = "ИзменениеСуммы", Comment = "", Synonym = "Изменение суммы")]
        // Format 15.2
        public decimal ИзменениеСуммы {get; set;}
        [Description1C8(Name = "ИзменениеСуммыНДС", Comment = "", Synonym = "Изменение суммы НДС")]
        // Format 15.2
        public decimal ИзменениеСуммыНДС {get; set;}
        [Description1C8(Name = "Причина", Comment = "", Synonym = "Причина")]
        [StringLength(100)]
        public string Причина {get; set;}
        [Description1C8(Name = "СтатьяДекларацииНДСНалоговыеОбязательства", Comment = "", Synonym = "Статья декларации НДС (н/о)")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяДекларацииНДСНалоговыеОбязательства {get; set;}
        [Description1C8(Name = "ДатаКорректировки", Comment = "", Synonym = "Дата корректировки")]
        public DateTime ДатаКорректировки {get; set;}
        [Description1C8(Name = "ПроцентСкидкиНаценки", Comment = "(Общ) Процент скидки (если данная скидка детализируется по позициям номенклатуры, то является значением по умолчанию)", Synonym = "Процент скидки или наценки")]
        // Format 5.2
        public decimal ПроцентСкидкиНаценки {get; set;}
        [Description1C8(Name = "СуммаБезСкидки", Comment = "(Общ)", Synonym = "Сумма без скидки")]
        // Format 15.2
        public decimal СуммаБезСкидки {get; set;}
        [Description1C8(Name = "СуммаСкидки", Comment = "(Общ)", Synonym = "Сумма скидки")]
        // Format 15.2
        public decimal СуммаСкидки {get; set;}
        [Description1C8(Name = "НомерСтрокиНН", Comment = "", Synonym = "Номер строки НН")]
        // Format 7.0
        public long НомерСтрокиНН {get; set;}
        [Description1C8(Name = "Количество", Comment = "(Общ)", Synonym = "Количество")]
        // Format 15.3
        public decimal Количество {get; set;}
        [Description1C8(Name = "КодУКТВЭД", Comment = "", Synonym = "Код")]
        public Catalogs.КлассификаторУКТВЭД КодУКТВЭД {get; set;}
        [Description1C8(Name = "НомерГруппы", Comment = "", Synonym = "Номер группы корректировки")]
        // Format 4.0
        public long НомерГруппы {get; set;}
        [Description1C8(Name = "КодПричины", Comment = "", Synonym = "Код причины корректировки")]
        // Format 3.0
        public long КодПричины {get; set;}
    }
    [Description1C8(Name = "ОС", Comment = "(Общ)", Synonym = "ОС")]
    [Table("Prylozhenye2KNalohovoiNakladnoi_OS")]
    public class Приложение2КНалоговойНакладной_ОС
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
        [Description1C8(Name = "ИзменениеКоличества", Comment = "", Synonym = "Изменение количества")]
        // Format 15.3
        public decimal ИзменениеКоличества {get; set;}
        [Description1C8(Name = "ИзменениеЦены", Comment = "", Synonym = "Изменение цены")]
        // Format 15.2
        public decimal ИзменениеЦены {get; set;}
        [Description1C8(Name = "ИзменениеСуммы", Comment = "", Synonym = "Изменение суммы")]
        // Format 15.2
        public decimal ИзменениеСуммы {get; set;}
        [Description1C8(Name = "ИзменениеСуммыНДС", Comment = "", Synonym = "Изменение суммы НДС")]
        // Format 15.2
        public decimal ИзменениеСуммыНДС {get; set;}
        [Description1C8(Name = "Причина", Comment = "", Synonym = "Причина корректировки")]
        [StringLength(100)]
        public string Причина {get; set;}
        [Description1C8(Name = "СтатьяДекларацииНДСНалоговыеОбязательства", Comment = "", Synonym = "Статья декларации НДС (н/о)")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяДекларацииНДСНалоговыеОбязательства {get; set;}
        [Description1C8(Name = "ДатаКорректировки", Comment = "", Synonym = "Дата корректировки")]
        public DateTime ДатаКорректировки {get; set;}
        [Description1C8(Name = "КодУКТВЭД", Comment = "", Synonym = "Код")]
        public Catalogs.КлассификаторУКТВЭД КодУКТВЭД {get; set;}
        [Description1C8(Name = "НомерГТД", Comment = "", Synonym = "Номер ГТД")]
        public Catalogs.НомераГТД НомерГТД {get; set;}
        [Description1C8(Name = "НомерСтрокиНН", Comment = "", Synonym = "Номер строки НН")]
        // Format 7.0
        public long НомерСтрокиНН {get; set;}
        [Description1C8(Name = "НомерГруппы", Comment = "", Synonym = "Номер группы корректировки")]
        // Format 4.0
        public long НомерГруппы {get; set;}
        [Description1C8(Name = "КодПричины", Comment = "", Synonym = "Код причины корректировки")]
        // Format 3.0
        public long КодПричины {get; set;}
    }
    [Description1C8(Name = "ВозвратнаяТара", Comment = "(Общ)", Synonym = "Возвратная тара")]
    [Table("Prylozhenye2KNalohovoiNakladnoi_VozvratnaiaTara")]
    public class Приложение2КНалоговойНакладной_ВозвратнаяТара
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
        [Description1C8(Name = "ИзменениеКоличества", Comment = "", Synonym = "Изменение количества")]
        // Format 15.3
        public decimal ИзменениеКоличества {get; set;}
        [Description1C8(Name = "ИзменениеЦены", Comment = "", Synonym = "Изменение цены")]
        // Format 15.2
        public decimal ИзменениеЦены {get; set;}
        [Description1C8(Name = "ИзменениеСуммы", Comment = "", Synonym = "Изменение суммы")]
        // Format 15.2
        public decimal ИзменениеСуммы {get; set;}
        [Description1C8(Name = "Причина", Comment = "", Synonym = "Причина корректировки")]
        [StringLength(100)]
        public string Причина {get; set;}
    }
    [Description1C8(Name = "НМА", Comment = "(Общ)", Synonym = "НМА")]
    [Table("Prylozhenye2KNalohovoiNakladnoi_NMA")]
    public class Приложение2КНалоговойНакладной_НМА
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
        [Description1C8(Name = "ИзменениеКоличества", Comment = "", Synonym = "Изменение количества")]
        // Format 15.3
        public decimal ИзменениеКоличества {get; set;}
        [Description1C8(Name = "ИзменениеЦены", Comment = "", Synonym = "Изменение цены")]
        // Format 15.2
        public decimal ИзменениеЦены {get; set;}
        [Description1C8(Name = "ИзменениеСуммы", Comment = "", Synonym = "Изменение суммы")]
        // Format 15.2
        public decimal ИзменениеСуммы {get; set;}
        [Description1C8(Name = "ИзменениеСуммыНДС", Comment = "", Synonym = "Изменение суммы НДС")]
        // Format 15.2
        public decimal ИзменениеСуммыНДС {get; set;}
        [Description1C8(Name = "Причина", Comment = "", Synonym = "Причина корректировки")]
        [StringLength(100)]
        public string Причина {get; set;}
        [Description1C8(Name = "СтатьяДекларацииНДСНалоговыеОбязательства", Comment = "", Synonym = "Статья декларации НДС (н/о)")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяДекларацииНДСНалоговыеОбязательства {get; set;}
        [Description1C8(Name = "ДатаКорректировки", Comment = "", Synonym = "Дата корректировки")]
        public DateTime ДатаКорректировки {get; set;}
        [Description1C8(Name = "КодУКТВЭД", Comment = "", Synonym = "Код")]
        public Catalogs.КлассификаторУКТВЭД КодУКТВЭД {get; set;}
        [Description1C8(Name = "НомерГТД", Comment = "", Synonym = "Номер ГТД")]
        public Catalogs.НомераГТД НомерГТД {get; set;}
        [Description1C8(Name = "НомерСтрокиНН", Comment = "", Synonym = "Номер строки НН")]
        // Format 7.0
        public long НомерСтрокиНН {get; set;}
        [Description1C8(Name = "НомерГруппы", Comment = "", Synonym = "Номер группы корректировки")]
        // Format 4.0
        public long НомерГруппы {get; set;}
        [Description1C8(Name = "КодПричины", Comment = "", Synonym = "Код причины корректировки")]
        // Format 3.0
        public long КодПричины {get; set;}
    }
}
