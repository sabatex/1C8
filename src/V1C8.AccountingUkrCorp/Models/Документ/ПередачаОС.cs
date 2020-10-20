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
    [Table("PeredachaOS")]
    [Description1C8(Name = "ПередачаОС", Comment = "(Общ)", Synonym = "Передача ОС")]
    public class ПередачаОС:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "(Общ)", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "СобытиеОС", Comment = "(Общ)", Synonym = "Событие ОС")]
        public Catalogs.СобытияОС СобытиеОС {get; set;}
        [Description1C8(Name = "ДокПодготовкаКПередачеОС", Comment = "(Общ)", Synonym = "Документ подготовка к передаче ОС")]
        public Документ.ПодготовкаКПередачеОС ДокПодготовкаКПередачеОС {get; set;}
        [Description1C8(Name = "Контрагент", Comment = "(Общ)", Synonym = "Контрагент")]
        public Catalogs.Контрагенты Контрагент {get; set;}
        [Description1C8(Name = "ДоговорКонтрагента", Comment = "(Общ)", Synonym = "Договор")]
        public Catalogs.ДоговорыКонтрагентов ДоговорКонтрагента {get; set;}
        [Description1C8(Name = "ВалютаДокумента", Comment = "(Общ)", Synonym = "Валюта")]
        public Catalogs.Валюты ВалютаДокумента {get; set;}
        [Description1C8(Name = "КратностьВзаиморасчетов", Comment = "(Общ)", Synonym = "Кратность взаиморасчетов")]
        // Format 10.0
        public long КратностьВзаиморасчетов {get; set;}
        [Description1C8(Name = "Сделка", Comment = "(Общ)", Synonym = "Документ расчетов")]
        public Документ.ПлатежныйОрдерСписаниеДенежныхСредств Сделка {get; set;}
        [Description1C8(Name = "КурсВзаиморасчетов", Comment = "(Общ)", Synonym = "Курс взаиморасчетов")]
        // Format 10.4
        public decimal КурсВзаиморасчетов {get; set;}
        [Description1C8(Name = "НДСВключенВСтоимость", Comment = "(Общ)", Synonym = "НДС включен в стоимость")]
        public bool НДСВключенВСтоимость {get; set;}
        [Description1C8(Name = "СуммаВключаетНДС", Comment = "(Общ)", Synonym = "Сумма включает НДС")]
        public bool СуммаВключаетНДС {get; set;}
        [Description1C8(Name = "УдалитьУчитыватьНДС", Comment = "(Общ)", Synonym = "(не используется) Учитывать НДС")]
        public bool УдалитьУчитыватьНДС {get; set;}
        [Description1C8(Name = "СчетУчетаРасчетовПоАвансам", Comment = "(Регл)", Synonym = "Счет расчетов по авансам")]
        public ПланСчетов.Хозрасчетный СчетУчетаРасчетовПоАвансам {get; set;}
        [Description1C8(Name = "СчетУчетаРасчетовСКонтрагентом", Comment = "(Регл)", Synonym = "Счет расчетов")]
        public ПланСчетов.Хозрасчетный СчетУчетаРасчетовСКонтрагентом {get; set;}
        [Description1C8(Name = "Грузополучатель", Comment = "(Общ)", Synonym = "Грузополучатель")]
        public Catalogs.Контрагенты Грузополучатель {get; set;}
        [Description1C8(Name = "СуммаДокумента", Comment = "(Общ) Сумма в валюте документа, налоги включены согласно флагам", Synonym = "Сумма")]
        // Format 15.2
        public decimal СуммаДокумента {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "(Общ)", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "(Общ)", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "АдресДоставки", Comment = "(Общ)", Synonym = "Адрес доставки")]
        public string АдресДоставки {get; set;}
        [Description1C8(Name = "АвторасчетНДС", Comment = "", Synonym = "Авторасчет НДС")]
        public bool АвторасчетНДС {get; set;}
        [Description1C8(Name = "ПредседательКомиссии", Comment = "", Synonym = "Председатель комиссии")]
        public Catalogs.ФизическиеЛица ПредседательКомиссии {get; set;}
        [Description1C8(Name = "ПервыйЧленКомиссии", Comment = "", Synonym = "Первый член комиссии")]
        public Catalogs.ФизическиеЛица ПервыйЧленКомиссии {get; set;}
        [Description1C8(Name = "ВторойЧленКомиссии", Comment = "", Synonym = "Второй член комиссии")]
        public Catalogs.ФизическиеЛица ВторойЧленКомиссии {get; set;}
        [Description1C8(Name = "ТретийЧленКомиссии", Comment = "", Synonym = "Третий член комиссии")]
        public Catalogs.ФизическиеЛица ТретийЧленКомиссии {get; set;}
        [Description1C8(Name = "ДоверенностьСерия", Comment = "", Synonym = "Доверенность серия")]
        [StringLength(3)]
        public string ДоверенностьСерия {get; set;}
        [Description1C8(Name = "ДоверенностьНомер", Comment = "", Synonym = "Доверенность номер")]
        [StringLength(11)]
        public string ДоверенностьНомер {get; set;}
        [Description1C8(Name = "ДоверенностьДата", Comment = "", Synonym = "Доверенность дата")]
        public DateTime ДоверенностьДата {get; set;}
        [Description1C8(Name = "Получил", Comment = "ФИО представителя контрагента, получившего товары по доверенности", Synonym = "Получил")]
        [StringLength(250)]
        public string Получил {get; set;}
        [Description1C8(Name = "РучнаяКорректировка", Comment = "", Synonym = "Ручная корректировка")]
        public bool РучнаяКорректировка {get; set;}
        [Description1C8(Name = "СчетУчетаНДС", Comment = "(Регл)", Synonym = "Счет НДС (неподтвержденный)")]
        public ПланСчетов.Хозрасчетный СчетУчетаНДС {get; set;}
        [Description1C8(Name = "СчетУчетаНДСПодтвержденный", Comment = "", Synonym = "Счет НДС (нал. обязательства)")]
        public ПланСчетов.Хозрасчетный СчетУчетаНДСПодтвержденный {get; set;}
        [Description1C8(Name = "ПредставительОрганизации", Comment = "(Общ)", Synonym = "Представитель организации")]
        public Catalogs.ФизическиеЛица ПредставительОрганизации {get; set;}
        [Description1C8(Name = "МестоСоставленияДокумента", Comment = "", Synonym = "Место составления документа")]
        public string МестоСоставленияДокумента {get; set;}
        [Description1C8(Name = "ПолучилПоДругомуДокументу", Comment = "Получил по другому документу (не по доверенности)", Synonym = "Получено не по доверенности")]
        public bool ПолучилПоДругомуДокументу {get; set;}
        [Description1C8(Name = "ДокументПодтверждающийПолномочия", Comment = "", Synonym = "Документ подтверждающий полномочия")]
        [StringLength(250)]
        public string ДокументПодтверждающийПолномочия {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ОС", Comment = "(Общ)", Synonym = "ОС")]
        public List<ПередачаОС_ОС> ПередачаОСОС {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ОС", Comment = "(Общ)", Synonym = "ОС")]
    [Table("PeredachaOS_OS")]
    public class ПередачаОС_ОС
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ОсновноеСредство", Comment = "(Общ)", Synonym = "Основное средство")]
        public Catalogs.ОсновныеСредства ОсновноеСредство {get; set;}
        [Description1C8(Name = "СтоимостьБУ", Comment = "(Регл)", Synonym = "Стоимость (БУ)")]
        // Format 15.2
        public decimal СтоимостьБУ {get; set;}
        [Description1C8(Name = "АмортизацияБУ", Comment = "(Регл)", Synonym = "Амортизация (БУ)")]
        // Format 15.2
        public decimal АмортизацияБУ {get; set;}
        [Description1C8(Name = "АмортизацияЗаМесяцБУ", Comment = "(Регл)", Synonym = "Амортизация за месяц (БУ)")]
        // Format 15.2
        public decimal АмортизацияЗаМесяцБУ {get; set;}
        [Description1C8(Name = "СтоимостьНУ", Comment = "(Регл)", Synonym = "Стоимость (НУ)")]
        // Format 15.2
        public decimal СтоимостьНУ {get; set;}
        [Description1C8(Name = "СуммаМодернизацииНУ", Comment = "(Регл)", Synonym = "Сумма модернизации (НУ)")]
        // Format 15.2
        public decimal СуммаМодернизацииНУ {get; set;}
        [Description1C8(Name = "АмортизацияЗаМесяцНУ", Comment = "(Регл)", Synonym = "Амортизация за месяц (НУ)")]
        // Format 15.2
        public decimal АмортизацияЗаМесяцНУ {get; set;}
        [Description1C8(Name = "Сумма", Comment = "(Общ)", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "СтавкаНДС", Comment = "(Общ)", Synonym = "% НДС")]
        public Enums.СтавкиНДС СтавкаНДС {get; set;}
        [Description1C8(Name = "СуммаНДС", Comment = "(Общ)", Synonym = "Сумма НДС")]
        // Format 15.2
        public decimal СуммаНДС {get; set;}
        [Description1C8(Name = "СхемаРеализации", Comment = "", Synonym = "Схема реализации")]
        public Catalogs.СхемыРеализации СхемаРеализации {get; set;}
        [Description1C8(Name = "СчетПродажиОС", Comment = "(Регл)", Synonym = "Счет продажи ОС")]
        public ПланСчетов.Хозрасчетный СчетПродажиОС {get; set;}
        [Description1C8(Name = "НалоговоеНазначениеДоходовИЗатрат", Comment = "", Synonym = "Налоговое назначение доходов и затрат")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначениеДоходовИЗатрат {get; set;}
        [Description1C8(Name = "АмортизацияНУ", Comment = "(Регл)", Synonym = "Амортизация (НУ)")]
        // Format 15.2
        public decimal АмортизацияНУ {get; set;}
        [Description1C8(Name = "ПревышениеСуммДооценокНадСуммамиУценокБУ", Comment = "", Synonym = "Превышение сумм дооценок над суммами уценок (БУ)")]
        // Format 15.2
        public decimal ПревышениеСуммДооценокНадСуммамиУценокБУ {get; set;}
    }
}
