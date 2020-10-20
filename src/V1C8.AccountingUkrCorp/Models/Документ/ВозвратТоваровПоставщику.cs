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
    [Table("VozvratTovarovPostavshchyku")]
    [Description1C8(Name = "ВозвратТоваровПоставщику", Comment = "", Synonym = "Возврат товаров поставщику")]
    public class ВозвратТоваровПоставщику:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "ВидОперации", Comment = "", Synonym = "Вид операции")]
        public Enums.ВидыОперацийВозвратТоваровПоставщику ВидОперации {get; set;}
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Контрагент", Comment = "", Synonym = "Контрагент")]
        public Catalogs.Контрагенты Контрагент {get; set;}
        [Description1C8(Name = "ДоговорКонтрагента", Comment = "", Synonym = "Договор")]
        public Catalogs.ДоговорыКонтрагентов ДоговорКонтрагента {get; set;}
        [Description1C8(Name = "Сделка", Comment = "", Synonym = "Документ расчетов")]
        public Документ.ПлатежныйОрдерСписаниеДенежныхСредств Сделка {get; set;}
        [Description1C8(Name = "Склад", Comment = "", Synonym = "Склад")]
        public Catalogs.Склады Склад {get; set;}
        [Description1C8(Name = "ТипЦен", Comment = "", Synonym = "Тип цен")]
        public Catalogs.ТипыЦенНоменклатуры ТипЦен {get; set;}
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
        [Description1C8(Name = "СчетУчетаРасчетовСКонтрагентом", Comment = "", Synonym = "Счет расчетов")]
        public ПланСчетов.Хозрасчетный СчетУчетаРасчетовСКонтрагентом {get; set;}
        [Description1C8(Name = "СчетУчетаРасчетовПоТаре", Comment = "", Synonym = "Счет расчетов по таре")]
        public ПланСчетов.Хозрасчетный СчетУчетаРасчетовПоТаре {get; set;}
        [Description1C8(Name = "СчетУчетаДоходовБУ", Comment = "", Synonym = "Счет доходов")]
        public ПланСчетов.Хозрасчетный СчетУчетаДоходовБУ {get; set;}
        [Description1C8(Name = "СчетУчетаРасходовБУ", Comment = "", Synonym = "Счет расходов")]
        public ПланСчетов.Хозрасчетный СчетУчетаРасходовБУ {get; set;}
        [Description1C8(Name = "СчетУчетаРасчетовПоАвансам", Comment = "", Synonym = "Счет расчетов по авансам")]
        public ПланСчетов.Хозрасчетный СчетУчетаРасчетовПоАвансам {get; set;}
        [Description1C8(Name = "Грузополучатель", Comment = "", Synonym = "Грузополучатель")]
        public Catalogs.Контрагенты Грузополучатель {get; set;}
        [Description1C8(Name = "СчетУчетаРасчетовПоТареПоАвансам", Comment = "", Synonym = "Счет расчетов по таре по авансам")]
        public ПланСчетов.Хозрасчетный СчетУчетаРасчетовПоТареПоАвансам {get; set;}
        [Description1C8(Name = "РучнаяКорректировка", Comment = "", Synonym = "Ручная корректировка")]
        public bool РучнаяКорректировка {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "СубконтоДоходов1", Comment = "", Synonym = "Субконто доходов 1")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоДоходов1 {get; set;}
        [Description1C8(Name = "СубконтоДоходов2", Comment = "", Synonym = "Субконто доходов 2")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоДоходов2 {get; set;}
        [Description1C8(Name = "СубконтоДоходов3", Comment = "", Synonym = "Субконто доходов 3")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоДоходов3 {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "СубконтоРасходов1", Comment = "", Synonym = "Субконто расходов 1")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоРасходов1 {get; set;}
        [Description1C8(Name = "СубконтоРасходов2", Comment = "", Synonym = "Субконто расходов 2")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоРасходов2 {get; set;}
        [Description1C8(Name = "СубконтоРасходов3", Comment = "", Synonym = "Субконто расходов 3")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоРасходов3 {get; set;}
        [Description1C8(Name = "ДоверенностьСерия", Comment = "", Synonym = "Доверенность серия")]
        [StringLength(3)]
        public string ДоверенностьСерия {get; set;}
        [Description1C8(Name = "ДоверенностьНомер", Comment = "", Synonym = "Доверенность номер")]
        [StringLength(11)]
        public string ДоверенностьНомер {get; set;}
        [Description1C8(Name = "ДоверенностьДата", Comment = "", Synonym = "Доверенность дата")]
        public DateTime ДоверенностьДата {get; set;}
        [Description1C8(Name = "Получил", Comment = "ФИО представителя контрагента, получившего товары", Synonym = "Представитель контрагента")]
        [StringLength(250)]
        public string Получил {get; set;}
        [Description1C8(Name = "НомерВходящегоДокумента", Comment = "", Synonym = "Вх. номер")]
        [StringLength(30)]
        public string НомерВходящегоДокумента {get; set;}
        [Description1C8(Name = "ДатаВходящегоДокумента", Comment = "", Synonym = "Вх. дата")]
        public DateTime ДатаВходящегоДокумента {get; set;}
        [Description1C8(Name = "УдалитьУчитыватьНДС", Comment = "(Общ)", Synonym = "(не используется) Учитывать НДС")]
        public bool УдалитьУчитыватьНДС {get; set;}
        [Description1C8(Name = "ДокументПоступления", Comment = "", Synonym = "Документ поступления")]
        public Документ.ПоступлениеТоваровУслуг ДокументПоступления {get; set;}
        [Description1C8(Name = "СчетУчетаНДС", Comment = "", Synonym = "Счет НДС (неподтвержденный)")]
        public ПланСчетов.Хозрасчетный СчетУчетаНДС {get; set;}
        [Description1C8(Name = "СчетУчетаНДСПодтвержденный", Comment = "", Synonym = "Счет НДС (нал. обязательства)")]
        public ПланСчетов.Хозрасчетный СчетУчетаНДСПодтвержденный {get; set;}
        [Description1C8(Name = "СуммаНДСПропорциональноВсего", Comment = "", Synonym = "Сумма НДС (пропорционально, вся)")]
        // Format 15.2
        public decimal СуммаНДСПропорциональноВсего {get; set;}
        [Description1C8(Name = "СуммаНДСПропорциональноКредит", Comment = "", Synonym = "Сумма НДС (пропорционально, в кредит)")]
        // Format 15.2
        public decimal СуммаНДСПропорциональноКредит {get; set;}
        [Description1C8(Name = "ПредставительОрганизации", Comment = "", Synonym = "Представитель организации")]
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
        [Description1C8(Name = "Товары", Comment = "", Synonym = "Товары")]
        public List<ВозвратТоваровПоставщику_Товары> ВозвратТоваровПоставщикуТовары {get;set;}
        [Description1C8(Name = "ВозвратнаяТара", Comment = "", Synonym = "Возвратная тара")]
        public List<ВозвратТоваровПоставщику_ВозвратнаяТара> ВозвратТоваровПоставщикуВозвратнаяТара {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Товары", Comment = "", Synonym = "Товары")]
    [Table("VozvratTovarovPostavshchyku_Tovary")]
    public class ВозвратТоваровПоставщику_Товары
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
        [Description1C8(Name = "ЦенаВРознице", Comment = "", Synonym = "Цена в рознице")]
        // Format 15.2
        public decimal ЦенаВРознице {get; set;}
        [Description1C8(Name = "СуммаВРознице", Comment = "", Synonym = "Сумма в рознице")]
        // Format 15.2
        public decimal СуммаВРознице {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение (НДС)")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        [Description1C8(Name = "СтавкаНДСВРознице", Comment = "", Synonym = "% НДС в рознице")]
        public Enums.СтавкиНДС СтавкаНДСВРознице {get; set;}
        [Description1C8(Name = "ДокументОприходования", Comment = "", Synonym = "Документ оприходования")]
        public Документ.ОтчетПроизводстваЗаСмену ДокументОприходования {get; set;}
        [Description1C8(Name = "СебестоимостьНУ", Comment = "", Synonym = "Себестоимость НУ")]
        // Format 15.2
        public decimal СебестоимостьНУ {get; set;}
        [Description1C8(Name = "Себестоимость", Comment = "", Synonym = "Себестоимость")]
        // Format 15.2
        public decimal Себестоимость {get; set;}
    }
    [Description1C8(Name = "ВозвратнаяТара", Comment = "", Synonym = "Возвратная тара")]
    [Table("VozvratTovarovPostavshchyku_VozvratnaiaTara")]
    public class ВозвратТоваровПоставщику_ВозвратнаяТара
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
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение (НДС)")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
    }
}
