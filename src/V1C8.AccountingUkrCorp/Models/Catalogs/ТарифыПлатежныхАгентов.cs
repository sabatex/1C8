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
    [Table("TaryfyPlatezhnykhAhentov")]
    [Description1C8(Name = "ТарифыПлатежныхАгентов", Comment = "", Synonym = "Тарифы платежных агентов")]
    public class ТарифыПлатежныхАгентов:EnumItem
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
    [Description1C8(Name = "ИспользуетсяШкала", Comment = "", Synonym = "Использовать шкалу")]
    public bool ИспользуетсяШкала {get; set;}
    [Description1C8(Name = "СпособВводаСуммы", Comment = "Способ ввода суммы по тарифу. 0 — процент взимается с полной суммы перевода, 1 — процент взимается с суммы перевода, превышающей предыдущий порог", Synonym = "Способ ввода суммы")]
    public DBNull СпособВводаСуммы {get; set;}
    #endregion реквізити
    }
}
