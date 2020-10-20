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
    [Table("PostuplenyeNaRaschetnyiSchet")]
    [Description1C8(Name = "ПоступлениеНаРасчетныйСчет", Comment = "", Synonym = "Поступление на банковский счет")]
    public class ПоступлениеНаРасчетныйСчет:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "ВалютаДокумента", Comment = "(Общ)", Synonym = "Валюта")]
        public Catalogs.Валюты ВалютаДокумента {get; set;}
        [Description1C8(Name = "ВидОперации", Comment = "(Общ)", Synonym = "Вид операции")]
        public Enums.ВидыОперацийПоступлениеДенежныхСредств ВидОперации {get; set;}
        [Description1C8(Name = "ДоговорКонтрагента", Comment = "(Общ)", Synonym = "Договор")]
        public Catalogs.ДоговорыКонтрагентов ДоговорКонтрагента {get; set;}
        [Description1C8(Name = "ДокументОснование", Comment = "(Общ)", Synonym = "Документ основание")]
        public Documents.ПередачаОС ДокументОснование {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "Контрагент", Comment = "(Общ)", Synonym = "Контрагент")]
        public Catalogs.Контрагенты Контрагент {get; set;}
        [Description1C8(Name = "НомерВходящегоДокумента", Comment = "(Общ)", Synonym = "Номер входящего документа")]
        [StringLength(30)]
        public string НомерВходящегоДокумента {get; set;}
        [Description1C8(Name = "ДатаВходящегоДокумента", Comment = "(Общ)", Synonym = "Дата входящего документа")]
        public DateTime ДатаВходящегоДокумента {get; set;}
        [Description1C8(Name = "УдалитьОплачено", Comment = "(Общ)", Synonym = "(не используется) Оплачено")]
        public bool УдалитьОплачено {get; set;}
        [Description1C8(Name = "Организация", Comment = "(Общ)", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "(Общ)", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "СтатьяДвиженияДенежныхСредств", Comment = "(Регл)", Synonym = "Статья движения денежных средств")]
        public Catalogs.СтатьиДвиженияДенежныхСредств СтатьяДвиженияДенежныхСредств {get; set;}
        [Description1C8(Name = "СубконтоКт1", Comment = "(Регл)", Synonym = "Субконто Кт1")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоКт1 {get; set;}
        [Description1C8(Name = "СубконтоКт2", Comment = "(Регл)", Synonym = "Субконто Кт2")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоКт2 {get; set;}
        [Description1C8(Name = "СубконтоКт3", Comment = "(Регл)", Synonym = "Субконто Кт3")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоКт3 {get; set;}
        [Description1C8(Name = "СуммаДокумента", Comment = "(Общ)", Synonym = "Сумма")]
        // Format 15.2
        public decimal СуммаДокумента {get; set;}
        [Description1C8(Name = "СчетКонтрагента", Comment = "(Общ) Банковский счет контрагента", Synonym = "Счет контрагента")]
        public Catalogs.БанковскиеСчета СчетКонтрагента {get; set;}
        [Description1C8(Name = "СчетОрганизации", Comment = "(Общ) Банковский счет организации", Synonym = "Счет организации")]
        public Catalogs.БанковскиеСчета СчетОрганизации {get; set;}
        [Description1C8(Name = "СчетУчетаРасчетовСКонтрагентом", Comment = "(Регл)", Synonym = "Счет учета расчетов с контрагентом")]
        public ПланСчетов.Хозрасчетный СчетУчетаРасчетовСКонтрагентом {get; set;}
        [Description1C8(Name = "СчетБанк", Comment = "(бух)", Synonym = "Счет учета")]
        public ПланСчетов.Хозрасчетный СчетБанк {get; set;}
        [Description1C8(Name = "ДатаВыписки", Comment = "", Synonym = "Дата выписки")]
        public DateTime ДатаВыписки {get; set;}
        [Description1C8(Name = "РучнаяКорректировка", Comment = "", Synonym = "Ручная корректировка")]
        public bool РучнаяКорректировка {get; set;}
        [Description1C8(Name = "СтатьяДекларацииПоЕдиномуНалогу", Comment = "(Регл)", Synonym = "Ст. декл. по ед. налогу")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяДекларацииПоЕдиномуНалогу {get; set;}
        [Description1C8(Name = "НалоговоеНазначениеПриПрочемПоступлении", Comment = "", Synonym = "Налоговое назначение при прочем поступлении")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначениеПриПрочемПоступлении {get; set;}
        [Description1C8(Name = "НазначениеПлатежа", Comment = "(Общ)", Synonym = "Назначение платежа")]
        [StringLength(250)]
        public string НазначениеПлатежа {get; set;}
        [Description1C8(Name = "СуммаУслуг", Comment = "Услуги банка по платежным картам и банковским кредитам", Synonym = "Комиссия")]
        // Format 15.2
        public decimal СуммаУслуг {get; set;}
        [Description1C8(Name = "НалоговоеНазначениеПлатежныеКартыУслуги", Comment = "", Synonym = "Налоговое назначение при расчете платежными картами")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначениеПлатежныеКартыУслуги {get; set;}
        [Description1C8(Name = "СтатьяДекларацииПоЕдиномуНалогуОплатаУслугБанка", Comment = "", Synonym = "Статья декларации по единому налогу оплата услуг банка")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяДекларацииПоЕдиномуНалогуОплатаУслугБанка {get; set;}
        [Description1C8(Name = "ФизЛицо", Comment = "(Общ)", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизЛицо {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "РасшифровкаПлатежа", Comment = "(Общ)", Synonym = "Расшифровка платежа")]
        public List<ПоступлениеНаРасчетныйСчет_РасшифровкаПлатежа> ПоступлениеНаРасчетныйСчетРасшифровкаПлатежа {get;set;}
        [Description1C8(Name = "РеквизитыКонтрагента", Comment = "", Synonym = "Реквизиты контрагента")]
        public List<ПоступлениеНаРасчетныйСчет_РеквизитыКонтрагента> ПоступлениеНаРасчетныйСчетРеквизитыКонтрагента {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "РасшифровкаПлатежа", Comment = "(Общ)", Synonym = "Расшифровка платежа")]
    [Table("PostuplenyeNaRaschetnyiSchet_RasshyfrovkaPlatezha")]
    public class ПоступлениеНаРасчетныйСчет_РасшифровкаПлатежа
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ДоговорКонтрагента", Comment = "(Общ)", Synonym = "Договор")]
        public Catalogs.ДоговорыКонтрагентов ДоговорКонтрагента {get; set;}
        [Description1C8(Name = "Сделка", Comment = "(Общ)", Synonym = "Документ расчетов")]
        public Documents.ПлатежныйОрдерСписаниеДенежныхСредств Сделка {get; set;}
        [Description1C8(Name = "КурсВзаиморасчетов", Comment = "(Общ) Курс валюты взаиморасчетов по договору или валюты взаиморасчетов с подотчетником", Synonym = "Курс расчетов")]
        // Format 10.4
        public decimal КурсВзаиморасчетов {get; set;}
        [Description1C8(Name = "СуммаПлатежа", Comment = "(Общ)", Synonym = "Сумма")]
        // Format 15.2
        public decimal СуммаПлатежа {get; set;}
        [Description1C8(Name = "КратностьВзаиморасчетов", Comment = "(Общ)", Synonym = "Кратность взаиморасчетов")]
        // Format 10.0
        public long КратностьВзаиморасчетов {get; set;}
        [Description1C8(Name = "СуммаВзаиморасчетов", Comment = "(Общ)", Synonym = "Сумма взаиморасчетов")]
        // Format 15.2
        public decimal СуммаВзаиморасчетов {get; set;}
        [Description1C8(Name = "СтавкаНДС", Comment = "(Общ)", Synonym = "% НДС")]
        public Enums.СтавкиНДС СтавкаНДС {get; set;}
        [Description1C8(Name = "СуммаНДС", Comment = "(Общ)", Synonym = "Сумма НДС")]
        // Format 15.2
        public decimal СуммаНДС {get; set;}
        [Description1C8(Name = "СтатьяДвиженияДенежныхСредств", Comment = "(Регл)", Synonym = "Статья движения ден. средств")]
        public Catalogs.СтатьиДвиженияДенежныхСредств СтатьяДвиженияДенежныхСредств {get; set;}
        [Description1C8(Name = "СчетУчетаРасчетовСКонтрагентом", Comment = "(Регл)", Synonym = "Счет расчетов")]
        public ПланСчетов.Хозрасчетный СчетУчетаРасчетовСКонтрагентом {get; set;}
        [Description1C8(Name = "СчетУчетаРасчетовПоАвансам", Comment = "(Регл)", Synonym = "Счет авансов")]
        public ПланСчетов.Хозрасчетный СчетУчетаРасчетовПоАвансам {get; set;}
        [Description1C8(Name = "ЗаТару", Comment = "(Общ)", Synonym = "Тара")]
        public bool ЗаТару {get; set;}
        [Description1C8(Name = "СтатьяДекларацииПоЕдиномуНалогу", Comment = "(Регл)", Synonym = "Ст. декл. по ед. налогу")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяДекларацииПоЕдиномуНалогу {get; set;}
        [Description1C8(Name = "ДокументПередачиОС", Comment = "(Регл)", Synonym = "Документ передачи ОС")]
        public Documents.ПередачаОС ДокументПередачиОС {get; set;}
        [Description1C8(Name = "ОстаточнаяСтоимостьОС", Comment = "(Регл)", Synonym = "Остаточная стоимость основных средств")]
        // Format 15.2
        public decimal ОстаточнаяСтоимостьОС {get; set;}
        [Description1C8(Name = "СчетУчетаНДС", Comment = "(Регл)", Synonym = "Счет НДС")]
        public ПланСчетов.Хозрасчетный СчетУчетаНДС {get; set;}
        [Description1C8(Name = "СчетУчетаНДСПодтвержденный", Comment = "", Synonym = "Счет НДС подтв.")]
        public ПланСчетов.Хозрасчетный СчетУчетаНДСПодтвержденный {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение при приобретении")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        [Description1C8(Name = "СуммаНДСПропорциональноКредит", Comment = "", Synonym = "Сумма НДС (проп.)")]
        // Format 15.2
        public decimal СуммаНДСПропорциональноКредит {get; set;}
        [Description1C8(Name = "СтатьяРасчетовСФСС", Comment = "", Synonym = "Статья расчетов с ФСС")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяРасчетовСФСС {get; set;}
        [Description1C8(Name = "СуммаПоСтатьям", Comment = "(Общ)", Synonym = "Сумма по статьям")]
        // Format 15.2
        public decimal СуммаПоСтатьям {get; set;}
        [Description1C8(Name = "Амортизируется", Comment = "Поставка Основных фондов. Используется для запонения Приложения 5 к Декларации по НДС (с 2008 г) только для приобретения", Synonym = "ОФ")]
        public bool Амортизируется {get; set;}
        [Description1C8(Name = "ВозвратАвансаДо01042011НУ", Comment = "", Synonym = "Аванс до НКУ")]
        public bool ВозвратАвансаДо01042011НУ {get; set;}
        [Description1C8(Name = "СтатьяПоВозвратуАвансаДо2011НУ", Comment = "", Synonym = "Статья по возврату аванса (НУ)")]
        public Catalogs.СтатьиДоходов СтатьяПоВозвратуАвансаДо2011НУ {get; set;}
        [Description1C8(Name = "СуммаВДВРПоАвансуДо01042011", Comment = "", Synonym = "Сумма ВР до НКУ")]
        // Format 15.2
        public decimal СуммаВДВРПоАвансуДо01042011 {get; set;}
        [Description1C8(Name = "СубконтоКт1", Comment = "", Synonym = "Субконто Кт1")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоКт1 {get; set;}
        [Description1C8(Name = "СубконтоКт2", Comment = "", Synonym = "Субконто Кт2")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоКт2 {get; set;}
        [Description1C8(Name = "СубконтоКт3", Comment = "", Synonym = "Субконто Кт3")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоКт3 {get; set;}
        [Description1C8(Name = "СуммаУслуг", Comment = "", Synonym = "Сумма услуг")]
        // Format 15.2
        public decimal СуммаУслуг {get; set;}
    }
    [Description1C8(Name = "РеквизитыКонтрагента", Comment = "", Synonym = "Реквизиты контрагента")]
    [Table("PostuplenyeNaRaschetnyiSchet_RekvyzytyKontrahenta")]
    public class ПоступлениеНаРасчетныйСчет_РеквизитыКонтрагента
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Реквизит", Comment = "", Synonym = "Реквизит")]
        [StringLength(20)]
        public string Реквизит {get; set;}
        [Description1C8(Name = "Значение", Comment = "", Synonym = "Значение")]
        public string Значение {get; set;}
        [Description1C8(Name = "Представление", Comment = "", Synonym = "Представления")]
        [StringLength(30)]
        public string Представление {get; set;}
        [Description1C8(Name = "ТипКонтрагента", Comment = "", Synonym = "Тип контрагента")]
        [StringLength(10)]
        public string ТипКонтрагента {get; set;}
    }
}
