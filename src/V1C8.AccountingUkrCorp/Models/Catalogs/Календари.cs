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
        #region tables
        [Description1C8(Name = "ШаблонЗаполнения", Comment = "", Synonym = "Шаблон заполнения")]
        public List<Календари_ШаблонЗаполнения> КалендариШаблонЗаполнения {get;set;}
        [Description1C8(Name = "РасписаниеРаботы", Comment = "", Synonym = "Расписание работы")]
        public List<Календари_РасписаниеРаботы> КалендариРасписаниеРаботы {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ШаблонЗаполнения", Comment = "", Synonym = "Шаблон заполнения")]
    [Table("Kalendary_ShablonZapolnenyia")]
    public class Календари_ШаблонЗаполнения
    {
    public long Id {get;set;}
    public Guid Owner {get;set;}
        [Description1C8(Name = "ДеньВключенВГрафик", Comment = "", Synonym = "День включен в график")]
        public bool ДеньВключенВГрафик {get; set;}
    }
    [Description1C8(Name = "РасписаниеРаботы", Comment = "", Synonym = "Расписание работы")]
    [Table("Kalendary_RaspysanyeRaboty")]
    public class Календари_РасписаниеРаботы
    {
    public long Id {get;set;}
    public Guid Owner {get;set;}
        [Description1C8(Name = "НомерДня", Comment = "", Synonym = "Номер дня")]
        // Format 7.0
        public long НомерДня {get; set;}
        [Description1C8(Name = "ВремяНачала", Comment = "", Synonym = "Время начала")]
        public DateTime ВремяНачала {get; set;}
        [Description1C8(Name = "ВремяОкончания", Comment = "", Synonym = "Время окончания")]
        public DateTime ВремяОкончания {get; set;}
    }
}
