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
    [Table("ShtatnoeRaspysanye")]
    [Description1C8(Name = "ШтатноеРасписание", Comment = "", Synonym = "Штатное расписание")]
    public class ШтатноеРасписание
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
    [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
    public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
    [Description1C8(Name = "Должность", Comment = "", Synonym = "Должность")]
    public Catalogs.Должности Должность {get; set;}
    [Description1C8(Name = "РазрядКатегория", Comment = "", Synonym = "Разряд (категория)")]
    public Catalogs.РазрядыКатегорииДолжностей РазрядКатегория {get; set;}
    [Description1C8(Name = "ГрафикРаботыСотрудников", Comment = "", Synonym = "График работы")]
    public Catalogs.ГрафикиРаботыСотрудников ГрафикРаботыСотрудников {get; set;}
    [Description1C8(Name = "КоличествоСтавок", Comment = "", Synonym = "Количество ставок")]
    // Format 7.2
    public decimal КоличествоСтавок {get; set;}
    [Description1C8(Name = "Утверждена", Comment = "", Synonym = "Утверждена")]
    public bool Утверждена {get; set;}
    [Description1C8(Name = "ДатаУтверждения", Comment = "", Synonym = "Дата утверждения")]
    public DateTime ДатаУтверждения {get; set;}
    [Description1C8(Name = "Закрыта", Comment = "", Synonym = "Закрыта")]
    public bool Закрыта {get; set;}
    [Description1C8(Name = "ДатаЗакрытия", Comment = "", Synonym = "Дата закрытия")]
    public DateTime ДатаЗакрытия {get; set;}
    [Description1C8(Name = "ОкладТариф", Comment = "", Synonym = "Оклад тариф")]
    // Format 15.3
    public decimal ОкладТариф {get; set;}
    [Description1C8(Name = "ОкладТарифМин", Comment = "", Synonym = "Оклад тариф мин")]
    // Format 15.3
    public decimal ОкладТарифМин {get; set;}
    [Description1C8(Name = "ОкладТарифМакс", Comment = "", Synonym = "Оклад тариф макс")]
    // Format 15.3
    public decimal ОкладТарифМакс {get; set;}
    [Description1C8(Name = "Описание", Comment = "", Synonym = "Описание")]
    public string Описание {get; set;}
    [Description1C8(Name = "ФОТ", Comment = "", Synonym = "ФОТ")]
    // Format 19.2
    public decimal ФОТ {get; set;}
    [Description1C8(Name = "ФОТМин", Comment = "", Synonym = "ФОТ, мин.")]
    // Format 19.2
    public decimal ФОТМин {get; set;}
    [Description1C8(Name = "ФОТМакс", Comment = "", Synonym = "ФОТ, макс.")]
    // Format 19.2
    public decimal ФОТМакс {get; set;}
    [Description1C8(Name = "УсловияПриема", Comment = "", Synonym = "Условия приема на работу, характер работы")]
    public string УсловияПриема {get; set;}
    [Description1C8(Name = "СпособОтраженияЗарплатыВБухучете", Comment = "", Synonym = "Способ отражения")]
    public Catalogs.СпособыОтраженияЗарплатыВБухУчете СпособОтраженияЗарплатыВБухучете {get; set;}
    [Description1C8(Name = "СтатьяФинансирования", Comment = "", Synonym = "Финансирование")]
    public Catalogs.СтатьиФинансированияЗарплата СтатьяФинансирования {get; set;}
    [Description1C8(Name = "ТарифнаяСетка", Comment = "", Synonym = "Тарифная группа")]
    public Catalogs.ТарифныеСетки ТарифнаяСетка {get; set;}
    [Description1C8(Name = "ТарифнаяСеткаНадбавки", Comment = "", Synonym = "Тарифная группа надбавки")]
    public Catalogs.ТарифныеСетки ТарифнаяСеткаНадбавки {get; set;}
    [Description1C8(Name = "РазрядКатегорияНадбавки", Comment = "", Synonym = "Разряд (категория) надбавки")]
    public Catalogs.РазрядыКатегорииДолжностей РазрядКатегорияНадбавки {get; set;}
    [Description1C8(Name = "НадбавкаЗаВредностьРазмер", Comment = "", Synonym = "Надбавка за вредность размер")]
    // Format 15.2
    public decimal НадбавкаЗаВредностьРазмер {get; set;}
    [Description1C8(Name = "НадбавкаЗаВредностьРазмерМин", Comment = "", Synonym = "Надбавка за вредность размер мин")]
    // Format 15.2
    public decimal НадбавкаЗаВредностьРазмерМин {get; set;}
    [Description1C8(Name = "НадбавкаЗаВредностьРазмерМакс", Comment = "", Synonym = "Надбавка за вредность размер макс")]
    // Format 15.2
    public decimal НадбавкаЗаВредностьРазмерМакс {get; set;}
    [Description1C8(Name = "ВыплачиваетсяНадбавкаЗаВредность", Comment = "", Synonym = "Выплачивается надбавка за вредность")]
    public bool ВыплачиваетсяНадбавкаЗаВредность {get; set;}
    [Description1C8(Name = "ПроцентНадбавкиЗаВредность", Comment = "", Synonym = "% надбавки")]
    // Format 5.2
    public decimal ПроцентНадбавкиЗаВредность {get; set;}
    #endregion реквізити
    }
}
