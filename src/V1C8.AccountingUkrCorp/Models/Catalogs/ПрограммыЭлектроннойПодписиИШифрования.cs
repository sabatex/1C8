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
    [Table("ProhrammyЕlektronnoiPodpysyYShyfrovanyia")]
    [Description1C8(Name = "ПрограммыЭлектроннойПодписиИШифрования", Comment = "", Synonym = "Программы электронной подписи и шифрования")]
    public class ПрограммыЭлектроннойПодписиИШифрования:EnumItem
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
    [Description1C8(Name = "ИмяПрограммы", Comment = "", Synonym = "Имя программы")]
    [StringLength(430)]
    public string ИмяПрограммы {get; set;}
    [Description1C8(Name = "ТипПрограммы", Comment = "", Synonym = "Тип программы")]
    public DBNull ТипПрограммы {get; set;}
    [Description1C8(Name = "АлгоритмПодписи", Comment = "", Synonym = "Алгоритм подписи")]
    [StringLength(100)]
    public string АлгоритмПодписи {get; set;}
    [Description1C8(Name = "АлгоритмХеширования", Comment = "", Synonym = "Алгоритм хеширования")]
    [StringLength(100)]
    public string АлгоритмХеширования {get; set;}
    [Description1C8(Name = "АлгоритмШифрования", Comment = "", Synonym = "Алгоритм шифрования")]
    [StringLength(100)]
    public string АлгоритмШифрования {get; set;}
    [Description1C8(Name = "ЭтоПрограммаОблачногоСервиса", Comment = "", Synonym = "Это программа облачного сервиса")]
    public bool ЭтоПрограммаОблачногоСервиса {get; set;}
    #endregion реквізити
    }
}
