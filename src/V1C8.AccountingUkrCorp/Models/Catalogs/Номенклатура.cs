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
    [Table("Nomenklatura")]
    [Description1C8(Name = "Номенклатура", Comment = "(Общ)", Synonym = "Номенклатура")]
    public class Номенклатура:CatalogItem
    {
    #region Стандартні реквізити
    public Guid Id {get; set;}
    public bool IsFolder {get; set;}
    public bool DeletionMark {get; set;}
    public bool Predefined {get; set;}
    public string Code {get; set;}
    public string Description {get; set;}
    public Guid? Parent {get; set;}
    public Guid? Owner {get; set;}
    #endregion Стандартні реквізити
    #region реквізити
    [Description1C8(Name = "НаименованиеПолное", Comment = "(Общ) Полное наименование, например, для печати", Synonym = "Полное наименование")]
    [StringLength(1000)]
    public string НаименованиеПолное {get; set;}
    [Description1C8(Name = "Артикул", Comment = "(Общ) Код производителя", Synonym = "Артикул")]
    [StringLength(25)]
    public string Артикул {get; set;}
    [Description1C8(Name = "БазоваяЕдиницаИзмерения", Comment = "(Общ)", Synonym = "Базовая единица")]
    public Catalogs.КлассификаторЕдиницИзмерения БазоваяЕдиницаИзмерения {get; set;}
    [Description1C8(Name = "СтавкаНДС", Comment = "(Общ) Ставка НДС по умолчанию для оформления документов", Synonym = "% НДС")]
    public Enums.СтавкиНДС СтавкаНДС {get; set;}
    [Description1C8(Name = "Комментарий", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий")]
    public string Комментарий {get; set;}
    [Description1C8(Name = "Услуга", Comment = "(Общ)", Synonym = "Услуга")]
    public bool Услуга {get; set;}
    [Description1C8(Name = "ТранспортнаяУслуга", Comment = "Является ли услуга транспортной", Synonym = "Транспортная услуга")]
    public bool ТранспортнаяУслуга {get; set;}
    [Description1C8(Name = "ИзмеряетсяТолькоВСуммовомВыражении", Comment = "", Synonym = "Измеряется в суммовом выражении")]
    public bool ИзмеряетсяТолькоВСуммовомВыражении {get; set;}
    [Description1C8(Name = "ТекстДляПечатиВКолонкеКоличествоНалоговойНакладной", Comment = "", Synonym = "Текст для печати в НН")]
    [StringLength(40)]
    public string ТекстДляПечатиВКолонкеКоличествоНалоговойНакладной {get; set;}
    [Description1C8(Name = "ЛьготаНДС", Comment = "Льгота по НДС", Synonym = "Льгота по НДС")]
    [StringLength(128)]
    public string ЛьготаНДС {get; set;}
    [Description1C8(Name = "БланкСтрогогоУчета", Comment = "", Synonym = "Бланк строгого учета")]
    public bool БланкСтрогогоУчета {get; set;}
    [Description1C8(Name = "УчитываетсяПоНоминальнойСтоимости", Comment = "", Synonym = "Учитывается по номинальной стоимости")]
    public bool УчитываетсяПоНоминальнойСтоимости {get; set;}
    [Description1C8(Name = "НоменклатурнаяГруппа", Comment = "(Общ)", Synonym = "Номенклатурная группа")]
    public Catalogs.НоменклатурныеГруппы НоменклатурнаяГруппа {get; set;}
    [Description1C8(Name = "СтатьяЗатрат", Comment = "", Synonym = "Статья затрат")]
    public Catalogs.СтатьиЗатрат СтатьяЗатрат {get; set;}
    [Description1C8(Name = "ОсновнаяСпецификацияНоменклатуры", Comment = "", Synonym = "Спецификация")]
    public Catalogs.СпецификацииНоменклатуры ОсновнаяСпецификацияНоменклатуры {get; set;}
    [Description1C8(Name = "НоменклатураГТД", Comment = "", Synonym = "Код для НН (по-умолч.)")]
    public Catalogs.НоменклатураГТД НоменклатураГТД {get; set;}
    [Description1C8(Name = "ПодакцизныйТовар", Comment = "", Synonym = "Облагается акцизным налогом в рознице")]
    public bool ПодакцизныйТовар {get; set;}
    [Description1C8(Name = "СтатьяДекларацииПоАкцизномуНалогу", Comment = "", Synonym = "Статья декларации по акцизному налогу")]
    public Catalogs.СтатьиНалоговыхДеклараций СтатьяДекларацииПоАкцизномуНалогу {get; set;}
    [Description1C8(Name = "КодЛьготы", Comment = "", Synonym = "Код льготы по НДС (согласно Справочников налоговых льгот)")]
    [StringLength(8)]
    public string КодЛьготы {get; set;}
    #endregion реквізити
    }
}
