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
    [Table("OsnovnyeSredstva")]
    [Description1C8(Name = "ОсновныеСредства", Comment = "", Synonym = "Основные средства")]
    public class ОсновныеСредства:EnumItem
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
    [Description1C8(Name = "НаименованиеПолное", Comment = "(Общ)", Synonym = "Полное наименование")]
    [StringLength(1000)]
    public string НаименованиеПолное {get; set;}
    [Description1C8(Name = "Изготовитель", Comment = "(Общ) Организация-изготовитель", Synonym = "Изготовитель")]
    [StringLength(250)]
    public string Изготовитель {get; set;}
    [Description1C8(Name = "ЗаводскойНомер", Comment = "(Общ)", Synonym = "Заводской номер")]
    [StringLength(100)]
    public string ЗаводскойНомер {get; set;}
    [Description1C8(Name = "НомерПаспорта", Comment = "(Общ)", Synonym = "Номер паспорта (регистрационный)")]
    [StringLength(100)]
    public string НомерПаспорта {get; set;}
    [Description1C8(Name = "ДатаВыпуска", Comment = "(Общ)", Synonym = "Дата выпуска (постройки)")]
    public DateTime ДатаВыпуска {get; set;}
    [Description1C8(Name = "Автотранспорт", Comment = "(Общ)", Synonym = "Признак автотранспорта")]
    public bool Автотранспорт {get; set;}
    [Description1C8(Name = "Комментарий", Comment = "(Общ)", Synonym = "Комментарий")]
    public string Комментарий {get; set;}
    [Description1C8(Name = "Модель", Comment = "(Регл)", Synonym = "Модель, тип, марка")]
    public string Модель {get; set;}
    #endregion реквізити
    }
}
