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
    [Table("KlassyfykatorUKTVЕD")]
    [Description1C8(Name = "КлассификаторУКТВЭД", Comment = "", Synonym = "Классификатор кодов для НН")]
    public class КлассификаторУКТВЭД:CatalogItem
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
    [Description1C8(Name = "НаименованиеПолное", Comment = "", Synonym = "Полное наименование")]
    [StringLength(500)]
    public string НаименованиеПолное {get; set;}
    [Description1C8(Name = "Вид", Comment = "", Synonym = "Вид")]
    public Enums.ВидыКодовДляНалоговойНакладной Вид {get; set;}
    [Description1C8(Name = "ВыводитьПриПечатиЧека", Comment = "", Synonym = "Требуется выводить код при печати чека")]
    public bool ВыводитьПриПечатиЧека {get; set;}
    [Description1C8(Name = "КодСХДеятельности", Comment = "", Synonym = "Код с/х деятельности")]
    [StringLength(3)]
    public string КодСХДеятельности {get; set;}
    #endregion реквізити
    }
}
