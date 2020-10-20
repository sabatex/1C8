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
    [Table("OprykhodovanyeTovarov")]
    [Description1C8(Name = "ОприходованиеТоваров", Comment = "(Общ)", Synonym = "Оприходование товаров")]
    public class ОприходованиеТоваров:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "ВидОперации", Comment = "", Synonym = "Вид операции")]
        public Enums.ВидыОперацийОприходованиеТоваров ВидОперации {get; set;}
        [Description1C8(Name = "Организация", Comment = "(Общ)", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Склад", Comment = "(Общ)", Synonym = "Склад")]
        public Catalogs.Склады Склад {get; set;}
        [Description1C8(Name = "ИнвентаризацияТоваровНаСкладе", Comment = "(Общ)", Synonym = "Инвентаризация товаров на складе")]
        public Документ.ИнвентаризацияТоваровНаСкладе ИнвентаризацияТоваровНаСкладе {get; set;}
        [Description1C8(Name = "ТипЦен", Comment = "(Общ)", Synonym = "Тип цен")]
        public Catalogs.ТипыЦенНоменклатуры ТипЦен {get; set;}
        [Description1C8(Name = "СуммаДокумента", Comment = "(Общ) Сумма в валюте документа, налоги включены согласно флагам", Synonym = "Сумма")]
        // Format 15.2
        public decimal СуммаДокумента {get; set;}
        [Description1C8(Name = "Основание", Comment = "(Общ) Основание (статья) оприходования", Synonym = "Основание")]
        public string Основание {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "(Общ)", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "СуммаДокументаРегл", Comment = "(Регл.) Сумма в валюте регламентированного учета, налоги включены согласно флагам", Synonym = "Сумма (регл.)")]
        // Format 15.2
        public decimal СуммаДокументаРегл {get; set;}
        [Description1C8(Name = "СчетКт", Comment = "(Регл)", Synonym = "Счет доходов")]
        public ПланСчетов.Хозрасчетный СчетКт {get; set;}
        [Description1C8(Name = "СубконтоКт1", Comment = "(Регл)", Synonym = "Субконто кредита 1")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоКт1 {get; set;}
        [Description1C8(Name = "СубконтоКт2", Comment = "(Регл)", Synonym = "Субконто кредита 2")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоКт2 {get; set;}
        [Description1C8(Name = "СубконтоКт3", Comment = "(Регл)", Synonym = "Субконто кредита 3")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоКт3 {get; set;}
        [Description1C8(Name = "ПредседательКомиссии", Comment = "", Synonym = "Председатель комиссии")]
        public Catalogs.ФизическиеЛица ПредседательКомиссии {get; set;}
        [Description1C8(Name = "ПервыйЧленКомиссии", Comment = "", Synonym = "Первый член комиссии")]
        public Catalogs.ФизическиеЛица ПервыйЧленКомиссии {get; set;}
        [Description1C8(Name = "ВторойЧленКомиссии", Comment = "", Synonym = "Второй член комиссии")]
        public Catalogs.ФизическиеЛица ВторойЧленКомиссии {get; set;}
        [Description1C8(Name = "ТретийЧленКомиссии", Comment = "", Synonym = "Третий член комиссии")]
        public Catalogs.ФизическиеЛица ТретийЧленКомиссии {get; set;}
        [Description1C8(Name = "РучнаяКорректировка", Comment = "", Synonym = "Ручная корректировка")]
        public bool РучнаяКорректировка {get; set;}
        [Description1C8(Name = "НалоговоеНазначениеДоходовИЗатрат", Comment = "", Synonym = "Налоговое назначение доходов")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначениеДоходовИЗатрат {get; set;}
        [Description1C8(Name = "ПризнаватьДоходомПлательщикаЕН", Comment = "", Synonym = "Признавать доходом плательщика единого налога")]
        public bool ПризнаватьДоходомПлательщикаЕН {get; set;}
        [Description1C8(Name = "ПризнаватьЗатратыВНУ", Comment = "", Synonym = "Признавать затраты в НУ")]
        public bool ПризнаватьЗатратыВНУ {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Товары", Comment = "(Общ)", Synonym = "Товары")]
        public List<ОприходованиеТоваров_Товары> ОприходованиеТоваровТовары {get;set;}
        [Description1C8(Name = "БланкиСтрогогоУчета", Comment = "", Synonym = "Бланки строгого учета")]
        public List<ОприходованиеТоваров_БланкиСтрогогоУчета> ОприходованиеТоваровБланкиСтрогогоУчета {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Товары", Comment = "(Общ)", Synonym = "Товары")]
    [Table("OprykhodovanyeTovarov_Tovary")]
    public class ОприходованиеТоваров_Товары
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
        [Description1C8(Name = "Сумма", Comment = "(Общ)", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "ЦенаВРознице", Comment = "(Общ)", Synonym = "Цена в рознице")]
        // Format 15.2
        public decimal ЦенаВРознице {get; set;}
        [Description1C8(Name = "СуммаВРознице", Comment = "(Общ)", Synonym = "Сумма в рознице")]
        // Format 15.2
        public decimal СуммаВРознице {get; set;}
        [Description1C8(Name = "СтавкаНДСВРознице", Comment = "(Общ)", Synonym = "% НДС в рознице")]
        public Enums.СтавкиНДС СтавкаНДСВРознице {get; set;}
        [Description1C8(Name = "СчетУчетаБУ", Comment = "(Регл)", Synonym = "Счет учета")]
        public ПланСчетов.Хозрасчетный СчетУчетаБУ {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        [Description1C8(Name = "СуммаНУ", Comment = "", Synonym = "Сумма НУ")]
        // Format 15.2
        public decimal СуммаНУ {get; set;}
    }
    [Description1C8(Name = "БланкиСтрогогоУчета", Comment = "", Synonym = "Бланки строгого учета")]
    [Table("OprykhodovanyeTovarov_BlankyStrohohoUcheta")]
    public class ОприходованиеТоваров_БланкиСтрогогоУчета
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Номенклатура", Comment = "", Synonym = "Номенклатура")]
        public Catalogs.Номенклатура Номенклатура {get; set;}
        [Description1C8(Name = "ЕдиницаИзмерения", Comment = "(Общ)", Synonym = "Единица измерения")]
        public Catalogs.КлассификаторЕдиницИзмерения ЕдиницаИзмерения {get; set;}
        [Description1C8(Name = "Коэффициент", Comment = "(Общ)", Synonym = "Коэффициент")]
        // Format 10.3
        public decimal Коэффициент {get; set;}
        [Description1C8(Name = "Количество", Comment = "", Synonym = "Количество")]
        // Format 15.3
        public decimal Количество {get; set;}
        [Description1C8(Name = "Цена", Comment = "", Synonym = "Цена")]
        // Format 15.2
        public decimal Цена {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "СчетУчетаБУ", Comment = "(Регл)", Synonym = "Счет учета")]
        public ПланСчетов.Хозрасчетный СчетУчетаБУ {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        [Description1C8(Name = "ЦенаНоминальная", Comment = "", Synonym = "Цена номинальная")]
        // Format 15.2
        public decimal ЦенаНоминальная {get; set;}
        [Description1C8(Name = "СуммаНоминальная", Comment = "", Synonym = "Сумма номинальная")]
        // Format 15.2
        public decimal СуммаНоминальная {get; set;}
        [Description1C8(Name = "СчетУчетаЗабалансовыйБУ", Comment = "", Synonym = "Счет учета забалансовый")]
        public ПланСчетов.Хозрасчетный СчетУчетаЗабалансовыйБУ {get; set;}
        [Description1C8(Name = "СуммаНУ", Comment = "", Synonym = "Сумма НУ")]
        // Format 15.2
        public decimal СуммаНУ {get; set;}
    }
}
