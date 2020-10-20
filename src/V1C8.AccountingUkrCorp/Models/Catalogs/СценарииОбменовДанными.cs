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
    [Table("StsenaryyObmenovDannymy")]
    [Description1C8(Name = "СценарииОбменовДанными", Comment = "", Synonym = "Сценарии синхронизации данных")]
    public class СценарииОбменовДанными:CatalogItem
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
    [Description1C8(Name = "ИспользоватьРегламентноеЗадание", Comment = "", Synonym = "Использовать регламентное задание")]
    public bool ИспользоватьРегламентноеЗадание {get; set;}
    [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
    public string Комментарий {get; set;}
    [Description1C8(Name = "РегламентноеЗаданиеGUID", Comment = "", Synonym = "Регламентное задание GUID")]
    [StringLength(40)]
    public string РегламентноеЗаданиеGUID {get; set;}
    #endregion реквізити
    }
}
