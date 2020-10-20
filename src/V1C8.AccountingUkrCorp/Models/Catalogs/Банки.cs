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
    [Table("Banky")]
    [Description1C8(Name = "Банки", Comment = "", Synonym = "Банки")]
    public class Банки:CatalogItem
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
    [Description1C8(Name = "КоррСчет", Comment = "", Synonym = "Корр. счет")]
    [StringLength(20)]
    public string КоррСчет {get; set;}
    [Description1C8(Name = "Город", Comment = "", Synonym = "Город")]
    [StringLength(50)]
    public string Город {get; set;}
    [Description1C8(Name = "Адрес", Comment = "", Synonym = "Адрес")]
    [StringLength(500)]
    public string Адрес {get; set;}
    [Description1C8(Name = "Телефоны", Comment = "", Synonym = "Телефоны")]
    [StringLength(250)]
    public string Телефоны {get; set;}
    [Description1C8(Name = "КодПоЕДРПОУ", Comment = "Код по ЕДРПОУ", Synonym = "Код по ЕДРПОУ")]
    [StringLength(10)]
    public string КодПоЕДРПОУ {get; set;}
    [Description1C8(Name = "РучноеИзменение", Comment = "", Synonym = "Ручное изменение")]
    // Format 1.0
    public long РучноеИзменение {get; set;}
    #endregion реквізити
    }
}
