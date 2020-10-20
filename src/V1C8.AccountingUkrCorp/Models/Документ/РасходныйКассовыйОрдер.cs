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
    [Table("RaskhodnyiKassovyiOrder")]
    [Description1C8(Name = "РасходныйКассовыйОрдер", Comment = "(Общ)", Synonym = "Расходный кассовый ордер")]
    public class РасходныйКассовыйОрдер:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "ВидОперации", Comment = "(Общ)", Synonym = "Вид операции")]
        public Enums.ВидыОперацийРКО ВидОперации {get; set;}
        [Description1C8(Name = "Организация", Comment = "(Общ)", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "СчетКасса", Comment = "(бух)", Synonym = "Счет учета")]
        public ПланСчетов.Хозрасчетный СчетКасса {get; set;}
        [Description1C8(Name = "Контрагент", Comment = "(Общ)", Synonym = "Получатель")]
        public Catalogs.Контрагенты Контрагент {get; set;}
        [Description1C8(Name = "СуммаДокумента", Comment = "(Общ) Сумма в валюте документа, налоги включены согласно флагам", Synonym = "Сумма")]
        // Format 15.2
        public decimal СуммаДокумента {get; set;}
        [Description1C8(Name = "ВалютаДокумента", Comment = "(Общ)", Synonym = "Валюта")]
        public Catalogs.Валюты ВалютаДокумента {get; set;}
        [Description1C8(Name = "СчетУчетаРасчетовСКонтрагентом", Comment = "(Регл)", Synonym = "Счет расчетов")]
        public ПланСчетов.Хозрасчетный СчетУчетаРасчетовСКонтрагентом {get; set;}
        [Description1C8(Name = "СчетОрганизации", Comment = "(Регл) Банковский счет организации", Synonym = "Счет организации")]
        public Catalogs.БанковскиеСчета СчетОрганизации {get; set;}
        [Description1C8(Name = "СубконтоДт1", Comment = "(Регл)", Synonym = "Субконто Дт1")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоДт1 {get; set;}
        [Description1C8(Name = "СубконтоДт2", Comment = "(Регл)", Synonym = "Субконто Дт2")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоДт2 {get; set;}
        [Description1C8(Name = "СубконтоДт3", Comment = "(Регл)", Synonym = "Субконто Дт3")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоДт3 {get; set;}
        [Description1C8(Name = "ПлатежнаяВедомость", Comment = "", Synonym = "Платежная ведомость")]
        public Документ.ВедомостьНаВыплатуЗарплатыВКассу ПлатежнаяВедомость {get; set;}
        [Description1C8(Name = "СтатьяДвиженияДенежныхСредств", Comment = "(Регл)", Synonym = "Статья движения денежных средств")]
        public Catalogs.СтатьиДвиженияДенежныхСредств СтатьяДвиженияДенежныхСредств {get; set;}
        [Description1C8(Name = "Выдать", Comment = "(Общ)", Synonym = "Выдать")]
        [StringLength(250)]
        public string Выдать {get; set;}
        [Description1C8(Name = "Основание", Comment = "(Общ)", Synonym = "Основание")]
        [StringLength(250)]
        public string Основание {get; set;}
        [Description1C8(Name = "Приложение", Comment = "(Общ)", Synonym = "Приложение")]
        [StringLength(250)]
        public string Приложение {get; set;}
        [Description1C8(Name = "ПоДокументу", Comment = "(Общ)", Synonym = "По")]
        [StringLength(250)]
        public string ПоДокументу {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "(Общ)", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "ДокументОснование", Comment = "(Общ)", Synonym = "Документ основание")]
        public Документ.ПоступлениеНМА ДокументОснование {get; set;}
        [Description1C8(Name = "ДоговорКонтрагента", Comment = "(Общ)", Synonym = "Договор")]
        public Catalogs.ДоговорыКонтрагентов ДоговорКонтрагента {get; set;}
        [Description1C8(Name = "СтавкаНДС", Comment = "(Общ)", Synonym = "% НДС")]
        public Enums.СтавкиНДС СтавкаНДС {get; set;}
        [Description1C8(Name = "НомерОрдера", Comment = "(Регл)", Synonym = "Номер ордера")]
        [StringLength(10)]
        public string НомерОрдера {get; set;}
        [Description1C8(Name = "НазначениеДенежныхСредств", Comment = "(Регл)", Synonym = "Назначение денежных средств")]
        public Catalogs.НазначенияНаличныхДенежныхСредств НазначениеДенежныхСредств {get; set;}
        [Description1C8(Name = "СтатьяДекларацииПоЕдиномуНалогу", Comment = "(Регл)", Synonym = "Ст. декл. по ед. налогу")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяДекларацииПоЕдиномуНалогу {get; set;}
        [Description1C8(Name = "СчетУчетаРасчетовПоЗП", Comment = "", Synonym = "Счет учета")]
        public ПланСчетов.Хозрасчетный СчетУчетаРасчетовПоЗП {get; set;}
        [Description1C8(Name = "ВидВзаиморасчетовРасчетовПоЗП", Comment = "(Регл)", Synonym = "Вид взаиморасчетов")]
        public Enums.УдалитьВидыВзаиморасчетовСРаботниками ВидВзаиморасчетовРасчетовПоЗП {get; set;}
        [Description1C8(Name = "ОбособленноеПодразделениеОрганизации", Comment = "", Synonym = "Обособленное подразделение организации")]
        public Catalogs.ОбособленныеПодразделенияОрганизаций ОбособленноеПодразделениеОрганизации {get; set;}
        [Description1C8(Name = "ПоОбособленномуПодразделению", Comment = "", Synonym = "По обособленному подразделению")]
        public bool ПоОбособленномуПодразделению {get; set;}
        [Description1C8(Name = "НалоговоеНазначениеПриПрочемСписании", Comment = "", Synonym = "Налоговое назначение при прочем списании")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначениеПриПрочемСписании {get; set;}
        [Description1C8(Name = "РучнаяКорректировка", Comment = "", Synonym = "Ручная корректировка")]
        public bool РучнаяКорректировка {get; set;}
        [Description1C8(Name = "ГруппаУчетаНачислений", Comment = "", Synonym = "Группа учета начислений")]
        public Catalogs.ГруппыУчетаНачисленийИУдержаний ГруппаУчетаНачислений {get; set;}
        [Description1C8(Name = "ДоговорЗаймаСотруднику", Comment = "", Synonym = "Договор займа сотруднику")]
        public Документ.ДоговорЗаймаСотруднику ДоговорЗаймаСотруднику {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "РасшифровкаПлатежа", Comment = "(Общ)", Synonym = "Расшифровка платежа")]
        public List<РасходныйКассовыйОрдер_РасшифровкаПлатежа> РасходныйКассовыйОрдерРасшифровкаПлатежа {get;set;}
        [Description1C8(Name = "ВыплатаЗаработнойПлаты", Comment = "(Общ)", Synonym = "Выплата заработной платы")]
        public List<РасходныйКассовыйОрдер_ВыплатаЗаработнойПлаты> РасходныйКассовыйОрдерВыплатаЗаработнойПлаты {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "РасшифровкаПлатежа", Comment = "(Общ)", Synonym = "Расшифровка платежа")]
    [Table("RaskhodnyiKassovyiOrder_RasshyfrovkaPlatezha")]
    public class РасходныйКассовыйОрдер_РасшифровкаПлатежа
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ДоговорКонтрагента", Comment = "", Synonym = "Договор")]
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
        [Description1C8(Name = "СтатьяДвиженияДенежныхСредств", Comment = "(Регл)", Synonym = "Статья движения ден. средств")]
        public Catalogs.СтатьиДвиженияДенежныхСредств СтатьяДвиженияДенежныхСредств {get; set;}
        [Description1C8(Name = "СчетУчетаРасчетовСКонтрагентом", Comment = "(Регл)", Synonym = "Счет расчетов")]
        public ПланСчетов.Хозрасчетный СчетУчетаРасчетовСКонтрагентом {get; set;}
        [Description1C8(Name = "СчетУчетаРасчетовПоАвансам", Comment = "(Регл)", Synonym = "Счет авансов")]
        public ПланСчетов.Хозрасчетный СчетУчетаРасчетовПоАвансам {get; set;}
        [Description1C8(Name = "КратностьВзаиморасчетов", Comment = "(Общ)", Synonym = "Кратность взаиморасчетов")]
        // Format 10.0
        public long КратностьВзаиморасчетов {get; set;}
        [Description1C8(Name = "ЗаТару", Comment = "(Общ)", Synonym = "Тара")]
        public bool ЗаТару {get; set;}
        [Description1C8(Name = "СтатьяДекларацииПоЕдиномуНалогу", Comment = "(Регл)", Synonym = "Ст. декл. по ед. налогу")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяДекларацииПоЕдиномуНалогу {get; set;}
        [Description1C8(Name = "СчетУчетаНДС", Comment = "(Регл)", Synonym = "Счет НДС")]
        public ПланСчетов.Хозрасчетный СчетУчетаНДС {get; set;}
        [Description1C8(Name = "СчетУчетаНДСПодтвержденный", Comment = "", Synonym = "Счет НДС подтв.")]
        public ПланСчетов.Хозрасчетный СчетУчетаНДСПодтвержденный {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        [Description1C8(Name = "СуммаНДСПропорциональноКредит", Comment = "", Synonym = "НДС (проп.)")]
        // Format 15.2
        public decimal СуммаНДСПропорциональноКредит {get; set;}
        [Description1C8(Name = "Амортизируется", Comment = "Поставка Основных фондов. Исользуется для запонения Приложения 5 к Декларации по НДС (с 2008 г)", Synonym = "ОФ")]
        public bool Амортизируется {get; set;}
        [Description1C8(Name = "ВозвратАвансаДо01042011НУ", Comment = "", Synonym = "Аванс до НКУ")]
        public bool ВозвратАвансаДо01042011НУ {get; set;}
        [Description1C8(Name = "СтатьяПоВозвратуАвансаДо2011НУ", Comment = "", Synonym = "Статья по возврату аванса (НУ)")]
        public Catalogs.СтатьиДоходов СтатьяПоВозвратуАвансаДо2011НУ {get; set;}
        [Description1C8(Name = "СуммаВДВРПоАвансуДо01042011", Comment = "", Synonym = "Сумма ВР до НКУ")]
        // Format 15.2
        public decimal СуммаВДВРПоАвансуДо01042011 {get; set;}
    }
    [Description1C8(Name = "ВыплатаЗаработнойПлаты", Comment = "(Общ)", Synonym = "Выплата заработной платы")]
    [Table("RaskhodnyiKassovyiOrder_VyplataZarabotnoiPlaty")]
    public class РасходныйКассовыйОрдер_ВыплатаЗаработнойПлаты
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Ведомость", Comment = "(Общ) Ведомость на выдачу зарплаты, под которую снимается сумма", Synonym = "Ведомость")]
        public Документ.ВедомостьНаВыплатуЗарплатыРаздатчиком Ведомость {get; set;}
        [Description1C8(Name = "СуммаКВыплате", Comment = "(Общ) Сумма, снимаемая на выплату ЗП по ведомости", Synonym = "Сумма к выплате")]
        // Format 15.2
        public decimal СуммаКВыплате {get; set;}
        [Description1C8(Name = "СчетУчета", Comment = "", Synonym = "Счет учета")]
        public ПланСчетов.Хозрасчетный СчетУчета {get; set;}
        [Description1C8(Name = "ГруппаУчетаНачислений", Comment = "", Synonym = "Группа учета начислений")]
        public Catalogs.ГруппыУчетаНачисленийИУдержаний ГруппаУчетаНачислений {get; set;}
    }
}
