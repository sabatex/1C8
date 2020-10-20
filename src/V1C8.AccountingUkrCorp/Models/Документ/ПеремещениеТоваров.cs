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
    [Table("PeremeshchenyeTovarov")]
    [Description1C8(Name = "ПеремещениеТоваров", Comment = "(Общ)", Synonym = "Перемещение товаров")]
    public class ПеремещениеТоваров:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "ВидОперации", Comment = "", Synonym = "Вид операции")]
        public Enums.ВидыОперацийПеремещениеТоваров ВидОперации {get; set;}
        [Description1C8(Name = "Организация", Comment = "(Общ)", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "СкладОтправитель", Comment = "(Общ)", Synonym = "Склад отправитель")]
        public Catalogs.Склады СкладОтправитель {get; set;}
        [Description1C8(Name = "СкладПолучатель", Comment = "(Общ)", Synonym = "Склад получатель")]
        public Catalogs.Склады СкладПолучатель {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "(Общ)", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "РучнаяКорректировка", Comment = "", Synonym = "Ручная корректировка")]
        public bool РучнаяКорректировка {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Товары", Comment = "(Общ)", Synonym = "Товары")]
        public List<ПеремещениеТоваров_Товары> ПеремещениеТоваровТовары {get;set;}
        [Description1C8(Name = "ТоварыНаКомиссии", Comment = "(Общ)", Synonym = "Товары на комиссии")]
        public List<ПеремещениеТоваров_ТоварыНаКомиссии> ПеремещениеТоваровТоварыНаКомиссии {get;set;}
        [Description1C8(Name = "ВозвратнаяТара", Comment = "(Общ)", Synonym = "Возвратная тара")]
        public List<ПеремещениеТоваров_ВозвратнаяТара> ПеремещениеТоваровВозвратнаяТара {get;set;}
        [Description1C8(Name = "БланкиСтрогогоУчета", Comment = "(Общ)", Synonym = "Бланки строгого учета")]
        public List<ПеремещениеТоваров_БланкиСтрогогоУчета> ПеремещениеТоваровБланкиСтрогогоУчета {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Товары", Comment = "(Общ)", Synonym = "Товары")]
    [Table("PeremeshchenyeTovarov_Tovary")]
    public class ПеремещениеТоваров_Товары
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
        [Description1C8(Name = "Цена", Comment = "(Общ) Розничная цена в розничной торговле", Synonym = "Цена")]
        // Format 15.2
        public decimal Цена {get; set;}
        [Description1C8(Name = "СчетУчетаБУ", Comment = "(Регл)", Synonym = "Счет отправителя")]
        public ПланСчетов.Хозрасчетный СчетУчетаБУ {get; set;}
        [Description1C8(Name = "НовыйСчетУчетаБУ", Comment = "(Регл)", Synonym = "Счет получателя")]
        public ПланСчетов.Хозрасчетный НовыйСчетУчетаБУ {get; set;}
        [Description1C8(Name = "ЦенаВРознице", Comment = "(Общ)", Synonym = "Цена в рознице")]
        // Format 15.2
        public decimal ЦенаВРознице {get; set;}
        [Description1C8(Name = "СуммаВРознице", Comment = "(Общ)", Synonym = "Сумма в рознице")]
        // Format 15.2
        public decimal СуммаВРознице {get; set;}
        [Description1C8(Name = "СтавкаНДСВРознице", Comment = "(Общ)", Synonym = "% НДС в рознице")]
        public Enums.СтавкиНДС СтавкаНДСВРознице {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "(Регл)", Synonym = "Нал. назн. (НДС)")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        [Description1C8(Name = "ДокументОприходования", Comment = "", Synonym = "Документ оприходования")]
        public Документ.ОтчетПроизводстваЗаСмену ДокументОприходования {get; set;}
    }
    [Description1C8(Name = "ТоварыНаКомиссии", Comment = "(Общ)", Synonym = "Товары на комиссии")]
    [Table("PeremeshchenyeTovarov_TovaryNaKomyssyy")]
    public class ПеремещениеТоваров_ТоварыНаКомиссии
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
        [Description1C8(Name = "Цена", Comment = "(Общ) Розничная цена в розничной торговле", Synonym = "Цена")]
        // Format 15.2
        public decimal Цена {get; set;}
        [Description1C8(Name = "СчетУчетаБУ", Comment = "(Регл)", Synonym = "Счет учета")]
        public ПланСчетов.Хозрасчетный СчетУчетаБУ {get; set;}
        [Description1C8(Name = "НовыйСчетУчетаБУ", Comment = "(Регл)", Synonym = "Новый счет учета")]
        public ПланСчетов.Хозрасчетный НовыйСчетУчетаБУ {get; set;}
    }
    [Description1C8(Name = "ВозвратнаяТара", Comment = "(Общ)", Synonym = "Возвратная тара")]
    [Table("PeremeshchenyeTovarov_VozvratnaiaTara")]
    public class ПеремещениеТоваров_ВозвратнаяТара
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
        [Description1C8(Name = "НовыйСчетУчетаБУ", Comment = "(Регл)", Synonym = "Новый счет учета")]
        public ПланСчетов.Хозрасчетный НовыйСчетУчетаБУ {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "(Регл)", Synonym = "Налоговое назначение")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
    }
    [Description1C8(Name = "БланкиСтрогогоУчета", Comment = "(Общ)", Synonym = "Бланки строгого учета")]
    [Table("PeremeshchenyeTovarov_BlankyStrohohoUcheta")]
    public class ПеремещениеТоваров_БланкиСтрогогоУчета
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Номенклатура", Comment = "(Общ)", Synonym = "Номенклатура")]
        public Catalogs.Номенклатура Номенклатура {get; set;}
        [Description1C8(Name = "ЕдиницаИзмерения", Comment = "(Общ)", Synonym = "Единица измерения")]
        public Catalogs.КлассификаторЕдиницИзмерения ЕдиницаИзмерения {get; set;}
        [Description1C8(Name = "Количество", Comment = "(Общ)", Synonym = "Количество")]
        // Format 15.3
        public decimal Количество {get; set;}
        [Description1C8(Name = "Коэффициент", Comment = "(Общ)", Synonym = "Коэффициент")]
        // Format 10.3
        public decimal Коэффициент {get; set;}
        [Description1C8(Name = "Цена", Comment = "(Общ) Розничная цена в розничной торговле", Synonym = "Цена")]
        // Format 15.2
        public decimal Цена {get; set;}
        [Description1C8(Name = "СчетУчетаБУ", Comment = "(Регл)", Synonym = "Счет учета")]
        public ПланСчетов.Хозрасчетный СчетУчетаБУ {get; set;}
        [Description1C8(Name = "НовыйСчетУчетаБУ", Comment = "(Регл)", Synonym = "Новый счет учета")]
        public ПланСчетов.Хозрасчетный НовыйСчетУчетаБУ {get; set;}
        [Description1C8(Name = "СчетУчетаЗабалансовыйБУ", Comment = "", Synonym = "Счет учета забалансовый")]
        public ПланСчетов.Хозрасчетный СчетУчетаЗабалансовыйБУ {get; set;}
        [Description1C8(Name = "НовыйСчетУчетаЗабалансовыйБУ", Comment = "", Synonym = "Счет учета забалансовый")]
        public ПланСчетов.Хозрасчетный НовыйСчетУчетаЗабалансовыйБУ {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "(Регл)", Synonym = "Налоговое назначение")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
    }
}
