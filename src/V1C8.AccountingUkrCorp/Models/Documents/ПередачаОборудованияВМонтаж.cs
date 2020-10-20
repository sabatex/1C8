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
    [Table("PeredachaOborudovanyiaVMontazh")]
    [Description1C8(Name = "ПередачаОборудованияВМонтаж", Comment = "(Общ)", Synonym = "Передача оборудования в монтаж")]
    public class ПередачаОборудованияВМонтаж:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "(Общ)", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "ОбъектСтроительства", Comment = "(Общ)", Synonym = "Объект строительства")]
        public Catalogs.ОбъектыСтроительства ОбъектСтроительства {get; set;}
        [Description1C8(Name = "Склад", Comment = "(Общ)", Synonym = "Склад")]
        public Catalogs.Склады Склад {get; set;}
        [Description1C8(Name = "СчетУчетаБУОбъектаСтроительства", Comment = "(Регл)", Synonym = "Счет учета объекта строительства")]
        public ПланСчетов.Хозрасчетный СчетУчетаБУОбъектаСтроительства {get; set;}
        [Description1C8(Name = "СтатьяЗатрат", Comment = "(Общ)", Synonym = "Статья затрат")]
        public Catalogs.СтатьиЗатрат СтатьяЗатрат {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "(Общ)", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "(Обш)", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "РучнаяКорректировка", Comment = "", Synonym = "Ручная корректировка")]
        public bool РучнаяКорректировка {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Оборудование", Comment = "", Synonym = "Оборудование")]
        public List<ПередачаОборудованияВМонтаж_Оборудование> ПередачаОборудованияВМонтажОборудование {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Оборудование", Comment = "", Synonym = "Оборудование")]
    [Table("PeredachaOborudovanyiaVMontazh_Oborudovanye")]
    public class ПередачаОборудованияВМонтаж_Оборудование
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
        [Description1C8(Name = "ЕдиницаИзмерения", Comment = "(Общ)", Synonym = "Единица измерения")]
        public Catalogs.КлассификаторЕдиницИзмерения ЕдиницаИзмерения {get; set;}
        [Description1C8(Name = "Коэффициент", Comment = "(Общ)", Synonym = "Коэффициент")]
        // Format 10.3
        public decimal Коэффициент {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
    }
}
