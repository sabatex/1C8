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
    [Table("ObshchyeVneshnyeKomponenty")]
    [Description1C8(Name = "ОбщиеВнешниеКомпоненты", Comment = "", Synonym = "Общие внешние компоненты")]
    public class ОбщиеВнешниеКомпоненты:CatalogItem
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
    [Description1C8(Name = "Идентификатор", Comment = "", Synonym = "Идентификатор")]
    [StringLength(150)]
    public string Идентификатор {get; set;}
    [Description1C8(Name = "Версия", Comment = "", Synonym = "Версия")]
    [StringLength(20)]
    public string Версия {get; set;}
    [Description1C8(Name = "ДатаВерсии", Comment = "", Synonym = "Дата версии")]
    public DateTime ДатаВерсии {get; set;}
    [Description1C8(Name = "ХранилищеКомпоненты", Comment = "", Synonym = "Хранилище компоненты")]
    // Сховище значень
    public byte[] ХранилищеКомпоненты {get; set;}
    [Description1C8(Name = "Windows_x86", Comment = "", Synonym = "Windows x86")]
    public bool Windows_x86 {get; set;}
    [Description1C8(Name = "Windows_x86_64", Comment = "", Synonym = "Windows x86_64")]
    public bool Windows_x86_64 {get; set;}
    [Description1C8(Name = "Linux_x86", Comment = "", Synonym = "Linux x86")]
    public bool Linux_x86 {get; set;}
    [Description1C8(Name = "Linux_x86_64", Comment = "", Synonym = "Linux x86_64")]
    public bool Linux_x86_64 {get; set;}
    [Description1C8(Name = "Windows_x86_Firefox", Comment = "", Synonym = "Windows x86 Firefox")]
    public bool Windows_x86_Firefox {get; set;}
    [Description1C8(Name = "Linux_x86_Firefox", Comment = "", Synonym = "Linux x86 Firefox")]
    public bool Linux_x86_Firefox {get; set;}
    [Description1C8(Name = "Linux_x86_64_Firefox", Comment = "", Synonym = "Linux x86_64 Firefox")]
    public bool Linux_x86_64_Firefox {get; set;}
    [Description1C8(Name = "Windows_x86_MSIE", Comment = "", Synonym = "Windows x86 MSIE")]
    public bool Windows_x86_MSIE {get; set;}
    [Description1C8(Name = "Windows_x86_64_MSIE", Comment = "", Synonym = "Windows x86_64 MSIE")]
    public bool Windows_x86_64_MSIE {get; set;}
    [Description1C8(Name = "Windows_x86_Chrome", Comment = "", Synonym = "Windows x86 Chrome")]
    public bool Windows_x86_Chrome {get; set;}
    [Description1C8(Name = "Linux_x86_Chrome", Comment = "", Synonym = "Linux x86 Chrome")]
    public bool Linux_x86_Chrome {get; set;}
    [Description1C8(Name = "Linux_x86_64_Chrome", Comment = "", Synonym = "Linux x86_64 Chrome")]
    public bool Linux_x86_64_Chrome {get; set;}
    [Description1C8(Name = "MacOS_x86_64_Safari", Comment = "", Synonym = "Mac OS x86_64 Safari")]
    public bool MacOS_x86_64_Safari {get; set;}
    #endregion реквізити
    }
}
