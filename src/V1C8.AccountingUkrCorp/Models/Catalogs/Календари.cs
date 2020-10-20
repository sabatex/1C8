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
    [Table("Kalendary")]
    [Description1C8(Name = "Календари", Comment = "", Synonym = "ѳ(устарело) Графики работы")]
    public class Календари:CatalogItem
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
    [Description1C8(Name = "ПроизводственныйКалендарь", Comment = "", Synonym = "Производственный календарь")]
    public Catalogs.ПроизводственныеКалендари ПроизводственныйКалендарь {get; set;}
    [Description1C8(Name = "СпособЗаполнения", Comment = "", Synonym = "Способ заполнения")]
    public Enums.СпособыЗаполненияГрафикаРаботы СпособЗаполнения {get; set;}
    [Description1C8(Name = "ДатаНачала", Comment = "", Synonym = "Дата начала")]
    public DateTime ДатаНачала {get; set;}
    [Description1C8(Name = "ДатаОкончания", Comment = "", Synonym = "Дата окончания")]
    public DateTime ДатаОкончания {get; set;}
    [Description1C8(Name = "ДатаОтсчета", Comment = "", Synonym = "Дата отсчета")]
    public DateTime ДатаОтсчета {get; set;}
    [Description1C8(Name = "УчитыватьПраздники", Comment = "", Synonym = "Учитывать праздники")]
    public bool УчитыватьПраздники {get; set;}
    [Description1C8(Name = "Описание", Comment = "", Synonym = "Описание")]
    public string Описание {get; set;}
    [Description1C8(Name = "ГоризонтПланирования", Comment = "", Synonym = "Горизонт планирования")]
    // Format 3.0
    public long ГоризонтПланирования {get; set;}
    [Description1C8(Name = "ВладелецГрафика", Comment = "", Synonym = "Владелец графика")]
    public Catalogs.СпособыОтраженияЗарплатыВБухУчете ВладелецГрафика {get; set;}
    [Description1C8(Name = "УдалитьВидКалендаря", Comment = "", Synonym = "(Не используется) вид календаря")]
    public Enums.УдалитьВидыКалендарей УдалитьВидКалендаря {get; set;}
    #endregion реквізити
    }
}
