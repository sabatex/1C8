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
    [Table("PlatezhnyiOrderSpysanyeDenezhnykhSredstv")]
    [Description1C8(Name = "ПлатежныйОрдерСписаниеДенежныхСредств", Comment = "(Общ)", Synonym = "Платежный ордер на списание денежных средств")]
    public class ПлатежныйОрдерСписаниеДенежныхСредств:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "ВидОперации", Comment = "(Общ)", Synonym = "Вид операции")]
        public Enums.ВидыОперацийСписаниеБезналичныхДенежныхСредств ВидОперации {get; set;}
        [Description1C8(Name = "Организация", Comment = "(Общ)", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "СчетОрганизации", Comment = "(Общ) Банковский счет организации", Synonym = "Счет организации")]
        public Catalogs.БанковскиеСчета СчетОрганизации {get; set;}
        [Description1C8(Name = "СчетБанк", Comment = "(бух)", Synonym = "Счет учета наличных денежных средств")]
        public ПланСчетов.Хозрасчетный СчетБанк {get; set;}
        [Description1C8(Name = "Контрагент", Comment = "(Общ)", Synonym = "Контрагент")]
        public Catalogs.Контрагенты Контрагент {get; set;}
        [Description1C8(Name = "СчетКонтрагента", Comment = "(Общ) Банковский счет контрагента", Synonym = "Счет контрагента")]
        public Catalogs.БанковскиеСчета СчетКонтрагента {get; set;}
        [Description1C8(Name = "СуммаДокумента", Comment = "(Общ)", Synonym = "Сумма")]
        // Format 15.2
        public decimal СуммаДокумента {get; set;}
        [Description1C8(Name = "СчетУчетаРасчетовСКонтрагентом", Comment = "(Регл)", Synonym = "Счет учета расчетов с контрагентом")]
        public ПланСчетов.Хозрасчетный СчетУчетаРасчетовСКонтрагентом {get; set;}
        [Description1C8(Name = "СубконтоДт1", Comment = "(Регл)", Synonym = "Субконто Дт1")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоДт1 {get; set;}
        [Description1C8(Name = "Оплачено", Comment = "(Общ)", Synonym = "Оплачено")]
        public bool Оплачено {get; set;}
        [Description1C8(Name = "СубконтоДт2", Comment = "(Регл)", Synonym = "Субконто Дт1")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоДт2 {get; set;}
        [Description1C8(Name = "СубконтоДт3", Comment = "(Регл)", Synonym = "Субконто Дт1")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоДт3 {get; set;}
        [Description1C8(Name = "СтатьяДвиженияДенежныхСредств", Comment = "(Регл)", Synonym = "Статья движения денежных средств")]
        public Catalogs.СтатьиДвиженияДенежныхСредств СтатьяДвиженияДенежныхСредств {get; set;}
        [Description1C8(Name = "ФизЛицо", Comment = "(Общ)", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизЛицо {get; set;}
        [Description1C8(Name = "НазначениеПлатежа", Comment = "(Общ)", Synonym = "Назначение платежа")]
        [StringLength(250)]
        public string НазначениеПлатежа {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "(Общ)", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "ДокументОснование", Comment = "(Общ)", Synonym = "Документ основание")]
        public Documents.ПоступлениеНМА ДокументОснование {get; set;}
        [Description1C8(Name = "ДоговорКонтрагента", Comment = "(Общ)", Synonym = "Договор")]
        public Catalogs.ДоговорыКонтрагентов ДоговорКонтрагента {get; set;}
        [Description1C8(Name = "ДоговорЗайма", Comment = "(общ)", Synonym = "Договор займа")]
        [StringLength(10)]
        public string ДоговорЗайма {get; set;}
        [Description1C8(Name = "ВалютаВзаиморасчетовРаботника", Comment = "(Общ) Валюта, в которой работник отчитывается за полученный займ", Synonym = "Валюта взаиморасчетов работника")]
        public Catalogs.Валюты ВалютаВзаиморасчетовРаботника {get; set;}
        [Description1C8(Name = "ВалютаДокумента", Comment = "(Общ)", Synonym = "Валюта")]
        public Catalogs.Валюты ВалютаДокумента {get; set;}
        [Description1C8(Name = "ДатаВыписки", Comment = "", Synonym = "Дата выписки")]
        public DateTime ДатаВыписки {get; set;}
        [Description1C8(Name = "СтатьяДекларацииПоЕдиномуНалогу", Comment = "(Регл)", Synonym = "Ст. декл. по ед. налогу")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяДекларацииПоЕдиномуНалогу {get; set;}
        [Description1C8(Name = "НалоговоеНазначениеПриПрочемСписании", Comment = "", Synonym = "Налоговое назначение при прочем списании")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначениеПриПрочемСписании {get; set;}
        [Description1C8(Name = "РучнаяКорректировка", Comment = "", Synonym = "Ручная корректировка")]
        public bool РучнаяКорректировка {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "РасшифровкаПлатежа", Comment = "(Общ)", Synonym = "Расшифровка платежа")]
        public List<ПлатежныйОрдерСписаниеДенежныхСредств_РасшифровкаПлатежа> ПлатежныйОрдерСписаниеДенежныхСредствРасшифровкаПлатежа {get;set;}
        [Description1C8(Name = "ВыплатаЗаработнойПлаты", Comment = "(Общ)", Synonym = "Выплата заработной платы")]
        public List<ПлатежныйОрдерСписаниеДенежныхСредств_ВыплатаЗаработнойПлаты> ПлатежныйОрдерСписаниеДенежныхСредствВыплатаЗаработнойПлаты {get;set;}
        [Description1C8(Name = "ПеречислениеНалогов", Comment = "", Synonym = "Перечисление налогов")]
        public List<ПлатежныйОрдерСписаниеДенежныхСредств_ПеречислениеНалогов> ПлатежныйОрдерСписаниеДенежныхСредствПеречислениеНалогов {get;set;}
        [Description1C8(Name = "РеквизитыКонтрагента", Comment = "", Synonym = "Реквизиты контрагента")]
        public List<ПлатежныйОрдерСписаниеДенежныхСредств_РеквизитыКонтрагента> ПлатежныйОрдерСписаниеДенежныхСредствРеквизитыКонтрагента {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "РасшифровкаПлатежа", Comment = "(Общ)", Synonym = "Расшифровка платежа")]
    [Table("PlatezhnyiOrderSpysanyeDenezhnykhSredstv_RasshyfrovkaPlatezha")]
    public class ПлатежныйОрдерСписаниеДенежныхСредств_РасшифровкаПлатежа
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ДоговорКонтрагента", Comment = "(Общ)", Synonym = "Договор")]
        public Catalogs.ДоговорыКонтрагентов ДоговорКонтрагента {get; set;}
        [Description1C8(Name = "Сделка", Comment = "(Общ)", Synonym = "Сделка")]
        public Documents.ПлатежныйОрдерСписаниеДенежныхСредств Сделка {get; set;}
        [Description1C8(Name = "СуммаПлатежа", Comment = "(Общ)", Synonym = "Сумма платежа")]
        // Format 15.2
        public decimal СуммаПлатежа {get; set;}
        [Description1C8(Name = "КурсВзаиморасчетов", Comment = "(Общ) Курс валюты взаиморасчетов по договору или валюты взаиморасчетов с подотчетником", Synonym = "Курс взаиморасчетов")]
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
        [Description1C8(Name = "СчетУчетаРасчетовСКонтрагентом", Comment = "(Регл)", Synonym = "Счет учета расчетов с контрагентом")]
        public ПланСчетов.Хозрасчетный СчетУчетаРасчетовСКонтрагентом {get; set;}
        [Description1C8(Name = "СчетУчетаРасчетовПоАвансам", Comment = "(Регл)", Synonym = "Счет учета расчетов по авансам")]
        public ПланСчетов.Хозрасчетный СчетУчетаРасчетовПоАвансам {get; set;}
        [Description1C8(Name = "КратностьВзаиморасчетов", Comment = "(Общ)", Synonym = "Кратность взаиморасчетов")]
        // Format 10.0
        public long КратностьВзаиморасчетов {get; set;}
        [Description1C8(Name = "ЗаТару", Comment = "(Общ)", Synonym = "Платеж за тару")]
        public bool ЗаТару {get; set;}
        [Description1C8(Name = "СтатьяДекларацииПоЕдиномуНалогу", Comment = "(Регл)", Synonym = "Ст. декл. по ед. налогу")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяДекларацииПоЕдиномуНалогу {get; set;}
        [Description1C8(Name = "СчетУчетаНДС", Comment = "(Регл)", Synonym = "Счет учета НДС")]
        public ПланСчетов.Хозрасчетный СчетУчетаНДС {get; set;}
        [Description1C8(Name = "СчетУчетаНДСПодтвержденный", Comment = "", Synonym = "Счет учета НДС подтвержденный")]
        public ПланСчетов.Хозрасчетный СчетУчетаНДСПодтвержденный {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение при приобретении")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        [Description1C8(Name = "Амортизируется", Comment = "Поставка Основных фондов. Исользуется для запонения Приложения 5 к Декларации по НДС (с 2008 г)", Synonym = "Поставка основных фондов")]
        public bool Амортизируется {get; set;}
        [Description1C8(Name = "СуммаНДСПропорциональноКредит", Comment = "", Synonym = "Сумма НДС (пропорционально, в кредит)")]
        // Format 15.2
        public decimal СуммаНДСПропорциональноКредит {get; set;}
        [Description1C8(Name = "ВозвратАвансаДо01042011НУ", Comment = "", Synonym = "Возврат аванса, полученного (выданного) до 01.04.2011 (НУ)")]
        public bool ВозвратАвансаДо01042011НУ {get; set;}
        [Description1C8(Name = "СтатьяПоВозвратуАвансаДо2011НУ", Comment = "", Synonym = "Статья по возврату аванса (НУ)")]
        public Catalogs.СтатьиДоходов СтатьяПоВозвратуАвансаДо2011НУ {get; set;}
        [Description1C8(Name = "СуммаВДВРПоАвансуДо01042011", Comment = "", Synonym = "Сумма валовых расходов, начисленных по авансу до 01.04.2011 р. (грн.)")]
        // Format 15.2
        public decimal СуммаВДВРПоАвансуДо01042011 {get; set;}
    }
    [Description1C8(Name = "ВыплатаЗаработнойПлаты", Comment = "(Общ)", Synonym = "Выплата заработной платы")]
    [Table("PlatezhnyiOrderSpysanyeDenezhnykhSredstv_VyplataZarabotnoiPlaty")]
    public class ПлатежныйОрдерСписаниеДенежныхСредств_ВыплатаЗаработнойПлаты
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Ведомость", Comment = "(Общ) Ведомость на выдачу зарплаты, под которую снимается сумма", Synonym = "Ведомость")]
        public Documents.УстарелоВедомостьНаВыплатуЗарплаты Ведомость {get; set;}
        [Description1C8(Name = "СуммаКВыплате", Comment = "(Общ) Сумма, перечисляемая по ведомости", Synonym = "Сумма к выплате")]
        // Format 15.2
        public decimal СуммаКВыплате {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "УдалитьФизлицо", Comment = "", Synonym = "(не используется) Физлицо")]
        public Catalogs.ФизическиеЛица УдалитьФизлицо {get; set;}
        [Description1C8(Name = "СчетУчета", Comment = "", Synonym = "Счет учета")]
        public ПланСчетов.Хозрасчетный СчетУчета {get; set;}
        [Description1C8(Name = "УдалитьВидВзаиморасчетов", Comment = "(Регл)", Synonym = "(не используется) Вид взаиморасчетов")]
        public Enums.УдалитьВидыВзаиморасчетовСРаботниками УдалитьВидВзаиморасчетов {get; set;}
        [Description1C8(Name = "СтатьяДвиженияДенежныхСредств", Comment = "(Регл)", Synonym = "Статья движения денежных средств")]
        public Catalogs.СтатьиДвиженияДенежныхСредств СтатьяДвиженияДенежныхСредств {get; set;}
    }
    [Description1C8(Name = "ПеречислениеНалогов", Comment = "", Synonym = "Перечисление налогов")]
    [Table("PlatezhnyiOrderSpysanyeDenezhnykhSredstv_PerechyslenyeNalohov")]
    public class ПлатежныйОрдерСписаниеДенежныхСредств_ПеречислениеНалогов
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Ответственный", Comment = "(Общ)", Synonym = "Расчетчик")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "СубконтоДт1", Comment = "(Регл)", Synonym = "Субконто Дт1")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоДт1 {get; set;}
        [Description1C8(Name = "СубконтоДт2", Comment = "(Регл)", Synonym = "Субконто Дт2")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоДт2 {get; set;}
        [Description1C8(Name = "СубконтоДт3", Comment = "(Регл)", Synonym = "Субконто Дт3")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоДт3 {get; set;}
        [Description1C8(Name = "Сумма", Comment = "(Регл)", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "СтатьяДвиженияДенежныхСредств", Comment = "(Регл)", Synonym = "Статья движения денежных средств")]
        public Catalogs.СтатьиДвиженияДенежныхСредств СтатьяДвиженияДенежныхСредств {get; set;}
        [Description1C8(Name = "СтатьяДекларацииПоЕдиномуНалогу", Comment = "(Регл.)", Synonym = "Ст. декл. по ед. налогу")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяДекларацииПоЕдиномуНалогу {get; set;}
        [Description1C8(Name = "Ведомость", Comment = "(Общ) Ведомость на выдачу зарплаты, под которую снимается сумма", Synonym = "Ведомость")]
        public Documents.УстарелоВедомостьНаВыплатуЗарплаты Ведомость {get; set;}
    }
    [Description1C8(Name = "РеквизитыКонтрагента", Comment = "", Synonym = "Реквизиты контрагента")]
    [Table("PlatezhnyiOrderSpysanyeDenezhnykhSredstv_RekvyzytyKontrahenta")]
    public class ПлатежныйОрдерСписаниеДенежныхСредств_РеквизитыКонтрагента
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
