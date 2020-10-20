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
    [Table("HrafykyRabotySotrudnykov")]
    [Description1C8(Name = "ГрафикиРаботыСотрудников", Comment = "", Synonym = "Графики работы сотрудников")]
    public class ГрафикиРаботыСотрудников:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "ПроизводственныйКалендарь", Comment = "", Synonym = "Производственный календарь")]
        public Catalogs.ПроизводственныеКалендари ПроизводственныйКалендарь {get; set;}
        [Description1C8(Name = "СуммированныйУчетРабочегоВремени", Comment = "", Synonym = "Суммированный учет рабочего времени")]
        public bool СуммированныйУчетРабочегоВремени {get; set;}
        [Description1C8(Name = "ДатаОтсчета", Comment = "", Synonym = "Дата отсчета")]
        public DateTime ДатаОтсчета {get; set;}
        [Description1C8(Name = "ДлительностьРабочейНедели", Comment = "", Synonym = "Длительность рабочей недели")]
        // Format 7.2
        public decimal ДлительностьРабочейНедели {get; set;}
        [Description1C8(Name = "НеполноеРабочееВремя", Comment = "", Synonym = "Неполное рабочее время")]
        public bool НеполноеРабочееВремя {get; set;}
        [Description1C8(Name = "СокращеннаяРабочаяНеделя", Comment = "", Synonym = "Сокращенная рабочая неделя")]
        public bool СокращеннаяРабочаяНеделя {get; set;}
        [Description1C8(Name = "НеполныйРабочийДень", Comment = "", Synonym = "Неполный рабочий день")]
        public bool НеполныйРабочийДень {get; set;}
        [Description1C8(Name = "ГрафикПолногоРабочегоВремени", Comment = "", Synonym = "График полного рабочего времени")]
        public Catalogs.ГрафикиРаботыСотрудников ГрафикПолногоРабочегоВремени {get; set;}
        [Description1C8(Name = "УчитыватьПраздники", Comment = "", Synonym = "Учитывать праздники")]
        public bool УчитыватьПраздники {get; set;}
        [Description1C8(Name = "СпособЗаполнения", Comment = "", Synonym = "Способ заполнения")]
        public Enums.СпособыЗаполненияГрафикаРаботы СпособЗаполнения {get; set;}
        [Description1C8(Name = "РабочихДнейВНеделе", Comment = "", Synonym = "Рабочих дней в неделе")]
        // Format 1.0
        public long РабочихДнейВНеделе {get; set;}
        [Description1C8(Name = "СпособОпределенияНормыСуммированногоУчета", Comment = "", Synonym = "Способ определения нормы суммированного учета")]
        public Enums.СпособыОпределенияНормыСуммированногоУчета СпособОпределенияНормыСуммированногоУчета {get; set;}
        [Description1C8(Name = "ГрафикНормыПриСуммированномУчете", Comment = "", Synonym = "График нормы при суммированном учете")]
        public Catalogs.ГрафикиРаботыСотрудников ГрафикНормыПриСуммированномУчете {get; set;}
        [Description1C8(Name = "УчитыватьПредпраздничныеДни", Comment = "", Synonym = "Учитывать предпраздничные дни")]
        public bool УчитыватьПредпраздничныеДни {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ШаблонЗаполнения", Comment = "", Synonym = "Шаблон заполнения")]
        public List<ГрафикиРаботыСотрудников_ШаблонЗаполнения> ГрафикиРаботыСотрудниковШаблонЗаполнения {get;set;}
        [Description1C8(Name = "ВидыВремени", Comment = "", Synonym = "Виды времени")]
        public List<ГрафикиРаботыСотрудников_ВидыВремени> ГрафикиРаботыСотрудниковВидыВремени {get;set;}
        [Description1C8(Name = "ДанныеОРабочихЧасах", Comment = "", Synonym = "Данные о рабочих часах")]
        public List<ГрафикиРаботыСотрудников_ДанныеОРабочихЧасах> ГрафикиРаботыСотрудниковДанныеОРабочихЧасах {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ШаблонЗаполнения", Comment = "", Synonym = "Шаблон заполнения")]
    [Table("HrafykyRabotySotrudnykov_ShablonZapolnenyia")]
    public class ГрафикиРаботыСотрудников_ШаблонЗаполнения
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ДеньВключенВГрафик", Comment = "", Synonym = "День включен в график")]
        public bool ДеньВключенВГрафик {get; set;}
    }
    [Description1C8(Name = "ВидыВремени", Comment = "", Synonym = "Виды времени")]
    [Table("HrafykyRabotySotrudnykov_VydyVremeny")]
    public class ГрафикиРаботыСотрудников_ВидыВремени
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ВидВремени", Comment = "", Synonym = "Вид времени")]
        public Catalogs.ВидыИспользованияРабочегоВремени ВидВремени {get; set;}
    }
    [Description1C8(Name = "ДанныеОРабочихЧасах", Comment = "", Synonym = "Данные о рабочих часах")]
    [Table("HrafykyRabotySotrudnykov_DannyeORabochykhChasakh")]
    public class ГрафикиРаботыСотрудников_ДанныеОРабочихЧасах
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "НомерДняЦикла", Comment = "", Synonym = "Номер дня цикла")]
        // Format 2.0
        public long НомерДняЦикла {get; set;}
        [Description1C8(Name = "ВидВремени", Comment = "", Synonym = "Вид времени")]
        public Catalogs.ВидыИспользованияРабочегоВремени ВидВремени {get; set;}
        [Description1C8(Name = "Часов", Comment = "", Synonym = "Часов")]
        // Format 4.2
        public decimal Часов {get; set;}
    }
}
