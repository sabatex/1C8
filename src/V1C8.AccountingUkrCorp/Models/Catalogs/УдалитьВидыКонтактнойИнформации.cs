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
    [Table("UdalytVydyKontaktnoiYnformatsyy")]
    [Description1C8(Name = "УдалитьВидыКонтактнойИнформации", Comment = "", Synonym = "(не используется) Виды контактной информации")]
    public class УдалитьВидыКонтактнойИнформации:CatalogItem
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
    [Description1C8(Name = "Тип", Comment = "", Synonym = "Тип")]
    public Enums.ТипыКонтактнойИнформации Тип {get; set;}
    [Description1C8(Name = "ВидОбъектаКонтактнойИнформации", Comment = "", Synonym = "Вид объекта контактной информации")]
    public Enums.УдалитьВидыОбъектовКонтактнойИнформации ВидОбъектаКонтактнойИнформации {get; set;}
    #endregion реквізити
    }
}
