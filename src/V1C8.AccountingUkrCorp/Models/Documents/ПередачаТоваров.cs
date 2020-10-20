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
    [Table("PeredachaTovarov")]
    [Description1C8(Name = "ПередачаТоваров", Comment = "(Общ)", Synonym = "Передача товаров")]
    public class ПередачаТоваров:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "ВалютаДокумента", Comment = "(Общ)", Synonym = "Валюта")]
        public Catalogs.Валюты ВалютаДокумента {get; set;}
        [Description1C8(Name = "ВидОперации", Comment = "(Общ)", Synonym = "Вид операции")]
        public Enums.ВидыОперацийПередачаТоваров ВидОперации {get; set;}
        [Description1C8(Name = "Организация", Comment = "(Общ)", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Склад", Comment = "(Общ)", Synonym = "Склад")]
        public Catalogs.Склады Склад {get; set;}
        [Description1C8(Name = "Контрагент", Comment = "(Общ)", Synonym = "Контрагент")]
        public Catalogs.Контрагенты Контрагент {get; set;}
        [Description1C8(Name = "ДоговорКонтрагента", Comment = "(Общ)", Synonym = "Договор")]
        public Catalogs.ДоговорыКонтрагентов ДоговорКонтрагента {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "(Общ)", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "СчетУчетаРасчетовПоТаре", Comment = "(Регл)", Synonym = "Счет расчетов по таре")]
        public ПланСчетов.Хозрасчетный СчетУчетаРасчетовПоТаре {get; set;}
        [Description1C8(Name = "СчетУчетаРасчетовПоТареПоАвансам", Comment = "(Регл)", Synonym = "Счет расчетов по таре по авансам")]
        public ПланСчетов.Хозрасчетный СчетУчетаРасчетовПоТареПоАвансам {get; set;}
        [Description1C8(Name = "ДоверенностьСерия", Comment = "", Synonym = "Доверенность серия")]
        [StringLength(3)]
        public string ДоверенностьСерия {get; set;}
        [Description1C8(Name = "ДоверенностьНомер", Comment = "", Synonym = "Доверенность номер")]
        [StringLength(11)]
        public string ДоверенностьНомер {get; set;}
        [Description1C8(Name = "ДоверенностьДата", Comment = "", Synonym = "Доверенность дата")]
        public DateTime ДоверенностьДата {get; set;}
        [Description1C8(Name = "Получил", Comment = "ФИО представителя контрагента, получившего товары", Synonym = "Получил")]
        [StringLength(250)]
        public string Получил {get; set;}
        [Description1C8(Name = "РучнаяКорректировка", Comment = "", Synonym = "Ручная корректировка")]
        public bool РучнаяКорректировка {get; set;}
        [Description1C8(Name = "Сделка", Comment = "(Общ)", Synonym = "Документ расчетов")]
        public Documents.ПлатежныйОрдерСписаниеДенежныхСредств Сделка {get; set;}
        [Description1C8(Name = "ЕстьАвансДо01042011", Comment = "", Synonym = "Есть валовые расходы, начисленные по авансу до 01.04.2011 р.")]
        public bool ЕстьАвансДо01042011 {get; set;}
        [Description1C8(Name = "СуммаВДВРПоАвансуДо01042011", Comment = "", Synonym = "Сумма валовых расходов, начисленных по авансу до 01.04.2011 р. (грн.)")]
        // Format 15.2
        public decimal СуммаВДВРПоАвансуДо01042011 {get; set;}
        [Description1C8(Name = "НеОтноситьСебестоимостьЗапасовНаРасходыПоНУ", Comment = "Возможность не относить на расходы себестоимость запасаов, если идет реализации по авансу до 01.04 (в этом случае не покаываются доходы, поэтому есть спорное мнение, что не должны показываться и расходы)", Synonym = "Не относить себестоимость запасов на расходы в налоговом учете")]
        public bool НеОтноситьСебестоимостьЗапасовНаРасходыПоНУ {get; set;}
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
        [Description1C8(Name = "Товары", Comment = "(Общ)", Synonym = "Товары")]
        public List<ПередачаТоваров_Товары> ПередачаТоваровТовары {get;set;}
        [Description1C8(Name = "ВозвратнаяТара", Comment = "(Общ)", Synonym = "Возвратная тара")]
        public List<ПередачаТоваров_ВозвратнаяТара> ПередачаТоваровВозвратнаяТара {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Товары", Comment = "(Общ)", Synonym = "Товары")]
    [Table("PeredachaTovarov_Tovary")]
    public class ПередачаТоваров_Товары
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Номенклатура", Comment = "(Общ)", Synonym = "Номенклатура")]
        public Catalogs.Номенклатура Номенклатура {get; set;}
        [Description1C8(Name = "Количество", Comment = "(Общ)", Synonym = "Количество")]
        // Format 15.3
        public decimal Количество {get; set;}
        [Description1C8(Name = "СчетУчетаБУ", Comment = "(Регл)", Synonym = "Счет учета")]
        public ПланСчетов.Хозрасчетный СчетУчетаБУ {get; set;}
        [Description1C8(Name = "СчетПередачиБУ", Comment = "(Регл)", Synonym = "Счет передачи")]
        public ПланСчетов.Хозрасчетный СчетПередачиБУ {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение (НДС)")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        [Description1C8(Name = "ЕдиницаИзмерения", Comment = "(Общ)", Synonym = "Единица измерения")]
        public Catalogs.КлассификаторЕдиницИзмерения ЕдиницаИзмерения {get; set;}
        [Description1C8(Name = "Коэффициент", Comment = "(Общ)", Synonym = "Коэффициент")]
        // Format 10.3
        public decimal Коэффициент {get; set;}
    }
    [Description1C8(Name = "ВозвратнаяТара", Comment = "(Общ)", Synonym = "Возвратная тара")]
    [Table("PeredachaTovarov_VozvratnaiaTara")]
    public class ПередачаТоваров_ВозвратнаяТара
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
        [Description1C8(Name = "СчетУчетаБУ", Comment = "(Регл)", Synonym = "Счет учета")]
        public ПланСчетов.Хозрасчетный СчетУчетаБУ {get; set;}
        [Description1C8(Name = "СхемаРеализации", Comment = "", Synonym = "Схема реализации")]
        public Catalogs.СхемыРеализации СхемаРеализации {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение (НДС)")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        [Description1C8(Name = "НалоговоеНазначениеДоходовИЗатрат", Comment = "", Synonym = "Налоговое назначение (доходов и затрат)")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначениеДоходовИЗатрат {get; set;}
    }
}
