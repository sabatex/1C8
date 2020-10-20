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
    [Table("LystokSoobshchenyiaDliaVoenkomata")]
    [Description1C8(Name = "ЛистокСообщенияДляВоенкомата", Comment = "", Synonym = "Листок сообщения об изменениях")]
    public class ЛистокСообщенияДляВоенкомата:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "Статус", Comment = "", Synonym = "Статус")]
        public Enums.СтатусыЛистковСообщения Статус {get; set;}
        [Description1C8(Name = "ДатаВрученияСотруднику", Comment = "", Synonym = "Дата вручения сотруднику")]
        public DateTime ДатаВрученияСотруднику {get; set;}
        [Description1C8(Name = "ПричинаНевручения", Comment = "", Synonym = "Причина невручения")]
        [StringLength(500)]
        public string ПричинаНевручения {get; set;}
        [Description1C8(Name = "ОписаниеИзменений", Comment = "", Synonym = "Описание изменений")]
        [StringLength(350)]
        public string ОписаниеИзменений {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "Должность", Comment = "", Synonym = "Должность")]
        public Catalogs.Должности Должность {get; set;}
        [Description1C8(Name = "ДатаРождения", Comment = "Дата рождения", Synonym = "Дата рождения")]
        public DateTime ДатаРождения {get; set;}
        [Description1C8(Name = "Образование", Comment = "", Synonym = "Образование")]
        public Catalogs.ВидыОбразованияФизическихЛиц Образование {get; set;}
        [Description1C8(Name = "СемейноеПоложение", Comment = "", Synonym = "Семейное положение")]
        public Catalogs.СостояниеВБраке СемейноеПоложение {get; set;}
        [Description1C8(Name = "Звание", Comment = "", Synonym = "Воинское звание")]
        public Catalogs.ЗванияГражданскогоВоинскогоУчета Звание {get; set;}
        [Description1C8(Name = "ВУС", Comment = "", Synonym = "ВУС")]
        [StringLength(10)]
        public string ВУС {get; set;}
        [Description1C8(Name = "СостояниеЗдоровья", Comment = "", Synonym = "Состояние здоровья")]
        public string СостояниеЗдоровья {get; set;}
        [Description1C8(Name = "АдресМестаПроживанияПредставление", Comment = "", Synonym = "Адрес места проживания")]
        [StringLength(150)]
        public string АдресМестаПроживанияПредставление {get; set;}
        [Description1C8(Name = "СоставСемьи", Comment = "", Synonym = "Состав семьи")]
        public string СоставСемьи {get; set;}
        [Description1C8(Name = "ОтветственныйЗаВУР", Comment = "", Synonym = "Ответственный за ВУ")]
        public Catalogs.ФизическиеЛица ОтветственныйЗаВУР {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ФиксацияИзменений", Comment = "", Synonym = "Фиксация изменений")]
        public List<ЛистокСообщенияДляВоенкомата_ФиксацияИзменений> ЛистокСообщенияДляВоенкоматаФиксацияИзменений {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ФиксацияИзменений", Comment = "", Synonym = "Фиксация изменений")]
    [Table("LystokSoobshchenyiaDliaVoenkomata_FyksatsyiaYzmenenyi")]
    public class ЛистокСообщенияДляВоенкомата_ФиксацияИзменений
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ИмяРеквизита", Comment = "", Synonym = "Имя реквизита")]
        public string ИмяРеквизита {get; set;}
        [Description1C8(Name = "Путь", Comment = "", Synonym = "Путь")]
        public string Путь {get; set;}
        [Description1C8(Name = "ИдентификаторСтроки", Comment = "", Synonym = "Идентификатор строки")]
        // Format 5.0
        public long ИдентификаторСтроки {get; set;}
    }
}
