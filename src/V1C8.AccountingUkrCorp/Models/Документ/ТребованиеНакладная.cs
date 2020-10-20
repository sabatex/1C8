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
    [Table("TrebovanyeNakladnaia")]
    [Description1C8(Name = "ТребованиеНакладная", Comment = "(Общ)", Synonym = "Требование-накладная")]
    public class ТребованиеНакладная:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "(Общ)", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Склад", Comment = "(Общ)", Synonym = "Склад")]
        public Catalogs.Склады Склад {get; set;}
        [Description1C8(Name = "СчетаУчетаЗатратВТаблице", Comment = "", Synonym = "Счета учета затрат в таблице")]
        public bool СчетаУчетаЗатратВТаблице {get; set;}
        [Description1C8(Name = "СчетЗатрат", Comment = "(Регл)", Synonym = "Счет затрат")]
        public ПланСчетов.Хозрасчетный СчетЗатрат {get; set;}
        [Description1C8(Name = "ПодразделениеОрганизации", Comment = "(Регл)", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций ПодразделениеОрганизации {get; set;}
        [Description1C8(Name = "Субконто1", Comment = "(Регл)", Synonym = "Субконто 1")]
        public Catalogs.ВидыНалоговойДеятельности Субконто1 {get; set;}
        [Description1C8(Name = "Субконто2", Comment = "(Регл)", Synonym = "Субконто 2")]
        public Catalogs.ВидыНалоговойДеятельности Субконто2 {get; set;}
        [Description1C8(Name = "Субконто3", Comment = "(Регл)", Synonym = "Субконто 3")]
        public Catalogs.ВидыНалоговойДеятельности Субконто3 {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "(Общ)", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "ВидОперации", Comment = "", Synonym = "Вид операции")]
        public Enums.ВидыОперацийТребованиеНакладная ВидОперации {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "Контрагент", Comment = "", Synonym = "Контрагент")]
        public Catalogs.Контрагенты Контрагент {get; set;}
        [Description1C8(Name = "РучнаяКорректировка", Comment = "", Synonym = "Ручная корректировка")]
        public bool РучнаяКорректировка {get; set;}
        [Description1C8(Name = "НалоговоеНазначениеДоходовИЗатрат", Comment = "", Synonym = "Нал. назн. затрат")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначениеДоходовИЗатрат {get; set;}
        [Description1C8(Name = "ДокументОснование", Comment = "", Synonym = "Документ основание")]
        public Документ.ОтчетПроизводстваЗаСмену ДокументОснование {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Материалы", Comment = "(Общ)", Synonym = "Материалы")]
        public List<ТребованиеНакладная_Материалы> ТребованиеНакладнаяМатериалы {get;set;}
        [Description1C8(Name = "МатериалыЗаказчика", Comment = "(Общ)", Synonym = "Материалы заказчика")]
        public List<ТребованиеНакладная_МатериалыЗаказчика> ТребованиеНакладнаяМатериалыЗаказчика {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Материалы", Comment = "(Общ)", Synonym = "Материалы")]
    [Table("TrebovanyeNakladnaia_Materyaly")]
    public class ТребованиеНакладная_Материалы
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
        [Description1C8(Name = "Счет", Comment = "(Регл)", Synonym = "Счет")]
        public ПланСчетов.Хозрасчетный Счет {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Нал. назн. (НДС)")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        [Description1C8(Name = "Себестоимость", Comment = "", Synonym = "Себестоимость")]
        // Format 15.2
        public decimal Себестоимость {get; set;}
        [Description1C8(Name = "ДокументОприходования", Comment = "", Synonym = "Документ оприходования")]
        public Документ.ОтчетПроизводстваЗаСмену ДокументОприходования {get; set;}
        [Description1C8(Name = "НоменклатурнаяГруппа", Comment = "(Регл)", Synonym = "Номенклатурная группа")]
        public Catalogs.НоменклатурныеГруппы НоменклатурнаяГруппа {get; set;}
        [Description1C8(Name = "СчетЗатрат", Comment = "(Регл)", Synonym = "Счет затрат")]
        public ПланСчетов.Хозрасчетный СчетЗатрат {get; set;}
        [Description1C8(Name = "СтатьяЗатрат", Comment = "", Synonym = "Статья затрат")]
        public Catalogs.СтатьиЗатрат СтатьяЗатрат {get; set;}
        [Description1C8(Name = "СебестоимостьНУ", Comment = "", Synonym = "Себестоимость (НУ)")]
        // Format 15.2
        public decimal СебестоимостьНУ {get; set;}
        [Description1C8(Name = "НалоговоеНазначениеДоходовИЗатрат", Comment = "", Synonym = "Нал. назн. затрат")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначениеДоходовИЗатрат {get; set;}
    }
    [Description1C8(Name = "МатериалыЗаказчика", Comment = "(Общ)", Synonym = "Материалы заказчика")]
    [Table("TrebovanyeNakladnaia_MateryalyZakazchyka")]
    public class ТребованиеНакладная_МатериалыЗаказчика
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Номенклатура", Comment = "(Общ)", Synonym = "Номенклатура")]
        public Catalogs.Номенклатура Номенклатура {get; set;}
        [Description1C8(Name = "Количество", Comment = "(Общ)", Synonym = "Количество")]
        // Format 15.3
        public decimal Количество {get; set;}
        [Description1C8(Name = "Счет", Comment = "(Регл)", Synonym = "Счет")]
        public ПланСчетов.Хозрасчетный Счет {get; set;}
        [Description1C8(Name = "СчетПередачи", Comment = "(Регл)", Synonym = "Счет учета материалов заказчика в производстве")]
        public ПланСчетов.Хозрасчетный СчетПередачи {get; set;}
        [Description1C8(Name = "ЕдиницаИзмерения", Comment = "(Общ)", Synonym = "Единица измерения")]
        public Catalogs.КлассификаторЕдиницИзмерения ЕдиницаИзмерения {get; set;}
        [Description1C8(Name = "Коэффициент", Comment = "(Общ)", Synonym = "Коэффициент")]
        // Format 10.3
        public decimal Коэффициент {get; set;}
    }
}
