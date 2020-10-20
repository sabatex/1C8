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
        #region tables
        [Description1C8(Name = "ЕдиницыИзмерения", Comment = "", Synonym = "Единицы измерения")]
        public List<Номенклатура_ЕдиницыИзмерения> НоменклатураЕдиницыИзмерения {get;set;}
        [Description1C8(Name = "ДополнительныеРеквизиты", Comment = "", Synonym = "Дополнительные реквизиты")]
        public List<Номенклатура_ДополнительныеРеквизиты> НоменклатураДополнительныеРеквизиты {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ЕдиницыИзмерения", Comment = "", Synonym = "Единицы измерения")]
    [Table("Nomenklatura_EdynytsyYzmerenyia")]
    public class Номенклатура_ЕдиницыИзмерения
    {
    public long Id {get;set;}
    public Guid Owner {get;set;}
        [Description1C8(Name = "ЕдиницаИзмерения", Comment = "", Synonym = "Единица измерения")]
        public Catalogs.КлассификаторЕдиницИзмерения ЕдиницаИзмерения {get; set;}
        [Description1C8(Name = "Коэффициент", Comment = "", Synonym = "Коэффициент")]
        // Format 10.3
        public decimal Коэффициент {get; set;}
    }
    [Description1C8(Name = "ДополнительныеРеквизиты", Comment = "", Synonym = "Дополнительные реквизиты")]
    [Table("Nomenklatura_DopolnytelnyeRekvyzyty")]
    public class Номенклатура_ДополнительныеРеквизиты
    {
    public long Id {get;set;}
    public Guid Owner {get;set;}
        [Description1C8(Name = "Свойство", Comment = "", Synonym = "Свойство")]
        public ПланВидовХарактеристик.ДополнительныеРеквизитыИСведения Свойство {get; set;}
        [Description1C8(Name = "Значение", Comment = "", Synonym = "Значение")]
        public Catalogs.Склады Значение {get; set;}
        [Description1C8(Name = "ТекстоваяСтрока", Comment = "", Synonym = "Текстовая строка")]
        public string ТекстоваяСтрока {get; set;}
    }
}
