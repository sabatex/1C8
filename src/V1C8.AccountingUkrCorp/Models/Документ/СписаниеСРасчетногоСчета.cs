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
    [Table("SpysanyeSRaschetnohoScheta")]
    [Description1C8(Name = "СписаниеСРасчетногоСчета", Comment = "(Общ)", Synonym = "Списание с банковского счета")]
    public class СписаниеСРасчетногоСчета:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "ДокументОснование", Comment = "(Общ)", Synonym = "Документ основание")]
        public Документ.УстарелоНачислениеЗарплаты ДокументОснование {get; set;}
        [Description1C8(Name = "Организация", Comment = "(Общ)", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "ВидОперации", Comment = "(Общ)", Synonym = "Вид операции")]
        public Enums.ВидыОперацийСписаниеДенежныхСредств ВидОперации {get; set;}
        [Description1C8(Name = "СчетОрганизации", Comment = "(Общ) Банковский счет организации", Synonym = "Счет организации")]
        public Catalogs.БанковскиеСчета СчетОрганизации {get; set;}
        [Description1C8(Name = "Контрагент", Comment = "(Общ)", Synonym = "Контрагент")]
        public Catalogs.Контрагенты Контрагент {get; set;}
        [Description1C8(Name = "СчетКонтрагента", Comment = "(Общ) Банковский счет контрагента", Synonym = "Счет контрагента")]
        public Catalogs.БанковскиеСчета СчетКонтрагента {get; set;}
        [Description1C8(Name = "ДоговорКонтрагента", Comment = "(Общ)", Synonym = "Договор")]
        public Catalogs.ДоговорыКонтрагентов ДоговорКонтрагента {get; set;}
        [Description1C8(Name = "СуммаДокумента", Comment = "(Общ)", Synonym = "Сумма")]
        // Format 15.2
        public decimal СуммаДокумента {get; set;}
        [Description1C8(Name = "НазначениеПлатежа", Comment = "(Общ)", Synonym = "Назначение платежа")]
        [StringLength(250)]
        public string НазначениеПлатежа {get; set;}
        [Description1C8(Name = "ВалютаДокумента", Comment = "(Общ)", Synonym = "Валюта")]
        public Catalogs.Валюты ВалютаДокумента {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "(Общ)", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "СтатьяДвиженияДенежныхСредств", Comment = "(Регл)", Synonym = "Статья движения денежных средств")]
        public Catalogs.СтатьиДвиженияДенежныхСредств СтатьяДвиженияДенежныхСредств {get; set;}
        [Description1C8(Name = "СчетУчетаРасчетовСКонтрагентом", Comment = "(Регл)", Synonym = "Счет учета расчетов с контрагентом")]
        public ПланСчетов.Хозрасчетный СчетУчетаРасчетовСКонтрагентом {get; set;}
        [Description1C8(Name = "СубконтоДт1", Comment = "(Регл)", Synonym = "Субконто Дт1")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоДт1 {get; set;}
        [Description1C8(Name = "СубконтоДт2", Comment = "(Регл)", Synonym = "Субконто Дт1")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоДт2 {get; set;}
        [Description1C8(Name = "СубконтоДт3", Comment = "(Регл)", Synonym = "Субконто Дт1")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоДт3 {get; set;}
        [Description1C8(Name = "ФизЛицо", Comment = "(Общ)", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизЛицо {get; set;}
        [Description1C8(Name = "ДоговорЗайма", Comment = "(общ)", Synonym = "Договор займа")]
        [StringLength(10)]
        public string ДоговорЗайма {get; set;}
        [Description1C8(Name = "ВалютаВзаиморасчетовРаботника", Comment = "(Общ) Валюта, в которой работник отчитывается за полученный займ", Synonym = "Валюта взаиморасчетов работника")]
        public Catalogs.Валюты ВалютаВзаиморасчетовРаботника {get; set;}
        [Description1C8(Name = "СчетБанк", Comment = "(бух)", Synonym = "Счет учета")]
        public ПланСчетов.Хозрасчетный СчетБанк {get; set;}
        [Description1C8(Name = "ДатаВыписки", Comment = "", Synonym = "Дата выписки")]
        public DateTime ДатаВыписки {get; set;}
        [Description1C8(Name = "УдалитьНомерПоручения", Comment = "(Регл)", Synonym = "(не используется) Номер поручения")]
        [StringLength(10)]
        public string УдалитьНомерПоручения {get; set;}
        [Description1C8(Name = "СтатьяДекларацииПоЕдиномуНалогу", Comment = "(Регл)", Synonym = "Ст. декл. по ед. налогу")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяДекларацииПоЕдиномуНалогу {get; set;}
        [Description1C8(Name = "НалоговоеНазначениеПриПрочемСписании", Comment = "", Synonym = "Налоговое назначение при прочем списании")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначениеПриПрочемСписании {get; set;}
        [Description1C8(Name = "РучнаяКорректировка", Comment = "", Synonym = "Ручная корректировка")]
        public bool РучнаяКорректировка {get; set;}
        [Description1C8(Name = "НомерВходящегоДокумента", Comment = "", Synonym = "Вх. номер")]
        [StringLength(20)]
        public string НомерВходящегоДокумента {get; set;}
        [Description1C8(Name = "ДатаВходящегоДокумента", Comment = "", Synonym = "Вх. дата")]
        public DateTime ДатаВходящегоДокумента {get; set;}
        [Description1C8(Name = "НеПодтвержденоВыпискойБанка", Comment = "", Synonym = "Не подтверждено выпиской банка")]
        public bool НеПодтвержденоВыпискойБанка {get; set;}
        [Description1C8(Name = "Ведомость", Comment = "", Synonym = "Ведомость")]
        public Документ.ВедомостьНаВыплатуЗарплатыПеречислением Ведомость {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ВыплатаЗаработнойПлаты", Comment = "(Общ)", Synonym = "Выплата заработной платы")]
        public List<СписаниеСРасчетногоСчета_ВыплатаЗаработнойПлаты> СписаниеСРасчетногоСчетаВыплатаЗаработнойПлаты {get;set;}
        [Description1C8(Name = "РасшифровкаПлатежа", Comment = "(Общ)", Synonym = "Расшифровка платежа")]
        public List<СписаниеСРасчетногоСчета_РасшифровкаПлатежа> СписаниеСРасчетногоСчетаРасшифровкаПлатежа {get;set;}
        [Description1C8(Name = "ПеречислениеНалогов", Comment = "(Регл)", Synonym = "Перечисление налогов")]
        public List<СписаниеСРасчетногоСчета_ПеречислениеНалогов> СписаниеСРасчетногоСчетаПеречислениеНалогов {get;set;}
        [Description1C8(Name = "РеквизитыКонтрагента", Comment = "", Synonym = "Реквизиты контрагента")]
        public List<СписаниеСРасчетногоСчета_РеквизитыКонтрагента> СписаниеСРасчетногоСчетаРеквизитыКонтрагента {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ВыплатаЗаработнойПлаты", Comment = "(Общ)", Synonym = "Выплата заработной платы")]
    [Table("SpysanyeSRaschetnohoScheta_VyplataZarabotnoiPlaty")]
    public class СписаниеСРасчетногоСчета_ВыплатаЗаработнойПлаты
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Ведомость", Comment = "(Общ) Ведомость на выдачу зарплаты, под которую снимается сумма", Synonym = "Ведомость")]
        public Документ.УстарелоВедомостьНаВыплатуЗарплаты Ведомость {get; set;}
        [Description1C8(Name = "СуммаКВыплате", Comment = "(Общ) Сумма, снимаемая на выплату ЗП по ведомости", Synonym = "Сумма к выплате")]
        // Format 15.2
        public decimal СуммаКВыплате {get; set;}
        [Description1C8(Name = "СчетУчета", Comment = "", Synonym = "Счет учета")]
        public ПланСчетов.Хозрасчетный СчетУчета {get; set;}
        [Description1C8(Name = "ГруппаУчетаНачислений", Comment = "", Synonym = "Группа учета начислений")]
        public Catalogs.ГруппыУчетаНачисленийИУдержаний ГруппаУчетаНачислений {get; set;}
    }
    [Description1C8(Name = "РасшифровкаПлатежа", Comment = "(Общ)", Synonym = "Расшифровка платежа")]
    [Table("SpysanyeSRaschetnohoScheta_RasshyfrovkaPlatezha")]
    public class СписаниеСРасчетногоСчета_РасшифровкаПлатежа
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ДоговорКонтрагента", Comment = "(Общ)", Synonym = "Договор")]
        public Catalogs.ДоговорыКонтрагентов ДоговорКонтрагента {get; set;}
        [Description1C8(Name = "Сделка", Comment = "(Общ)", Synonym = "Документ расчетов")]
        public Документ.ПлатежныйОрдерСписаниеДенежныхСредств Сделка {get; set;}
        [Description1C8(Name = "КурсВзаиморасчетов", Comment = "(Общ) Курс валюты взаиморасчетов по договору или валюты взаиморасчетов с подотчетником", Synonym = "Курс взаиморасчетов")]
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
        [Description1C8(Name = "СтатьяДвиженияДенежныхСредств", Comment = "(Регл)", Synonym = "Статья движения денежных средств")]
        public Catalogs.СтатьиДвиженияДенежныхСредств СтатьяДвиженияДенежныхСредств {get; set;}
        [Description1C8(Name = "СчетУчетаРасчетовСКонтрагентом", Comment = "(Регл)", Synonym = "Счет расчетов")]
        public ПланСчетов.Хозрасчетный СчетУчетаРасчетовСКонтрагентом {get; set;}
        [Description1C8(Name = "СчетУчетаРасчетовПоАвансам", Comment = "(Регл)", Synonym = "Счет авансов")]
        public ПланСчетов.Хозрасчетный СчетУчетаРасчетовПоАвансам {get; set;}
        [Description1C8(Name = "СтатьяДекларацииПоЕдиномуНалогу", Comment = "(Регл)", Synonym = "Ст. декл. по ед. налогу")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяДекларацииПоЕдиномуНалогу {get; set;}
        [Description1C8(Name = "СчетУчетаНДС", Comment = "(Регл)", Synonym = "Счет НДС")]
        public ПланСчетов.Хозрасчетный СчетУчетаНДС {get; set;}
        [Description1C8(Name = "СчетУчетаНДСПодтвержденный", Comment = "", Synonym = "Счет НДС подтв.")]
        public ПланСчетов.Хозрасчетный СчетУчетаНДСПодтвержденный {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение при приобретении")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        [Description1C8(Name = "Амортизируется", Comment = "Поставка Основных фондов. Исользуется для запонения Приложения 5 к Декларации по НДС (с 2008 г)", Synonym = "ОФ")]
        public bool Амортизируется {get; set;}
        [Description1C8(Name = "ЗаТару", Comment = "(Общ)", Synonym = "Тара")]
        public bool ЗаТару {get; set;}
        [Description1C8(Name = "СуммаНДСПропорциональноКредит", Comment = "", Synonym = "Сумма НДС (проп.)")]
        // Format 15.2
        public decimal СуммаНДСПропорциональноКредит {get; set;}
        [Description1C8(Name = "ВозвратАвансаДо01042011НУ", Comment = "", Synonym = "Аванс до НКУ")]
        public bool ВозвратАвансаДо01042011НУ {get; set;}
        [Description1C8(Name = "СтатьяПоВозвратуАвансаДо2011НУ", Comment = "", Synonym = "Статья по возврату аванса (НУ)")]
        public Catalogs.СтатьиДоходов СтатьяПоВозвратуАвансаДо2011НУ {get; set;}
        [Description1C8(Name = "СуммаВДВРПоАвансуДо01042011", Comment = "", Synonym = "Сумма ВР до НКУ")]
        // Format 15.2
        public decimal СуммаВДВРПоАвансуДо01042011 {get; set;}
    }
    [Description1C8(Name = "ПеречислениеНалогов", Comment = "(Регл)", Synonym = "Перечисление налогов")]
    [Table("SpysanyeSRaschetnohoScheta_PerechyslenyeNalohov")]
    public class СписаниеСРасчетногоСчета_ПеречислениеНалогов
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
        public Документ.УстарелоВедомостьНаВыплатуЗарплаты Ведомость {get; set;}
        [Description1C8(Name = "СчетУчета", Comment = "", Synonym = "Счет учета")]
        public ПланСчетов.Хозрасчетный СчетУчета {get; set;}
    }
    [Description1C8(Name = "РеквизитыКонтрагента", Comment = "", Synonym = "Реквизиты контрагента")]
    [Table("SpysanyeSRaschetnohoScheta_RekvyzytyKontrahenta")]
    public class СписаниеСРасчетногоСчета_РеквизитыКонтрагента
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
