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
    [Table("Dolzhnosty")]
    [Description1C8(Name = "Должности", Comment = "", Synonym = "Должности")]
    public class Должности:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "РеквизитДопУпорядочивания", Comment = "", Synonym = "Порядок")]
        // Format 5.0
        public long РеквизитДопУпорядочивания {get; set;}
        [Description1C8(Name = "ДатаВвода", Comment = "", Synonym = "Дата ввода")]
        public DateTime ДатаВвода {get; set;}
        [Description1C8(Name = "ИсключенаИзШтатногоРасписания", Comment = "", Synonym = "Исключена из штатного расписания")]
        public bool ИсключенаИзШтатногоРасписания {get; set;}
        [Description1C8(Name = "ДатаИсключения", Comment = "", Synonym = "Дата исключения")]
        public DateTime ДатаИсключения {get; set;}
        [Description1C8(Name = "ВведенаВШтатноеРасписание", Comment = "", Synonym = "Введена в штатное расписание")]
        public bool ВведенаВШтатноеРасписание {get; set;}
        [Description1C8(Name = "ЯвляетсяДолжностьюЛетногоЭкипажа", Comment = "", Synonym = "Является должностью летного экипажа")]
        public bool ЯвляетсяДолжностьюЛетногоЭкипажа {get; set;}
        [Description1C8(Name = "ЯвляетсяШахтерскойДолжностью", Comment = "", Synonym = "Является шахтерской должностью")]
        public bool ЯвляетсяШахтерскойДолжностью {get; set;}
        [Description1C8(Name = "НаименованиеКраткое", Comment = "", Synonym = "Краткое наименование")]
        [StringLength(25)]
        public string НаименованиеКраткое {get; set;}
        [Description1C8(Name = "ТарифнаяСетка", Comment = "", Synonym = "Тарифная группа")]
        public Catalogs.ТарифныеСетки ТарифнаяСетка {get; set;}
        [Description1C8(Name = "РазрядКатегория", Comment = "", Synonym = "Разряд (категория)")]
        public Catalogs.РазрядыКатегорииДолжностей РазрядКатегория {get; set;}
        [Description1C8(Name = "ТарифнаяСеткаНадбавки", Comment = "", Synonym = "Тарифная группа надбавки")]
        public Catalogs.ТарифныеСетки ТарифнаяСеткаНадбавки {get; set;}
        [Description1C8(Name = "РазрядКатегорияНадбавки", Comment = "", Synonym = "Разряд (категория) надбавки")]
        public Catalogs.РазрядыКатегорииДолжностей РазрядКатегорияНадбавки {get; set;}
        [Description1C8(Name = "ПроцентНадбавкиЗаВредность", Comment = "", Synonym = "% надбавки")]
        // Format 5.2
        public decimal ПроцентНадбавкиЗаВредность {get; set;}
        [Description1C8(Name = "ВыплачиваетсяНадбавкаЗаВредность", Comment = "", Synonym = "Выплачивается надбавка за вредность")]
        public bool ВыплачиваетсяНадбавкаЗаВредность {get; set;}
        [Description1C8(Name = "КоличествоДнейДополнительногоОтпускаВГод", Comment = "", Synonym = "Количество дней дополнительного отпуска за вредность (в год)")]
        // Format 2.0
        public long КоличествоДнейДополнительногоОтпускаВГод {get; set;}
        [Description1C8(Name = "КодКП", Comment = "", Synonym = "Код КП")]
        [StringLength(6)]
        public string КодКП {get; set;}
        [Description1C8(Name = "Категория", Comment = "", Synonym = "Категория")]
        public Catalogs.КатегорииДолжностей Категория {get; set;}
        [Description1C8(Name = "ЯвляетсяДолжностьюСпециальныхРабот", Comment = "", Synonym = "Является должностью специальных работ")]
        public bool ЯвляетсяДолжностьюСпециальныхРабот {get; set;}
        [Description1C8(Name = "НаименованиеПоКП", Comment = "Наименование по классификатору профессий", Synonym = "Наименование по КП")]
        [StringLength(300)]
        public string НаименованиеПоКП {get; set;}
        [Description1C8(Name = "КодЗКППТР", Comment = "Код ЗКППТР", Synonym = "Код ЗКППТР")]
        [StringLength(6)]
        public string КодЗКППТР {get; set;}
        [Description1C8(Name = "УстарелоДолжность", Comment = "", Synonym = "")]
        public Catalogs.УстарелоДолжности УстарелоДолжность {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ДополнительныеРеквизиты", Comment = "", Synonym = "Дополнительные реквизиты")]
        public List<Должности_ДополнительныеРеквизиты> ДолжностиДополнительныеРеквизиты {get;set;}
        [Description1C8(Name = "Специальности", Comment = "", Synonym = "Специальности")]
        public List<Должности_Специальности> ДолжностиСпециальности {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ДополнительныеРеквизиты", Comment = "", Synonym = "Дополнительные реквизиты")]
    [Table("Dolzhnosty_DopolnytelnyeRekvyzyty")]
    public class Должности_ДополнительныеРеквизиты
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
    [Description1C8(Name = "Специальности", Comment = "", Synonym = "Специальности")]
    [Table("Dolzhnosty_Spetsyalnosty")]
    public class Должности_Специальности
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Специальность", Comment = "", Synonym = "Специальность")]
        public Catalogs.КлассификаторСпециальностейПоОбразованию Специальность {get; set;}
    }
}
