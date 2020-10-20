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
    [Table("ObshchyeDannyeYnformatsyonnohoTsentra")]
    [Description1C8(Name = "ОбщиеДанныеИнформационногоЦентра", Comment = "", Synonym = "Общие данные информационного центра")]
    public class ОбщиеДанныеИнформационногоЦентра:EnumItem
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
    [Description1C8(Name = "Вложения", Comment = "", Synonym = "Вложения")]
    // Сховище значень
    public byte[] Вложения {get; set;}
    [Description1C8(Name = "ВнешняяСсылка", Comment = "", Synonym = "Внешняя ссылка")]
    public string ВнешняяСсылка {get; set;}
    [Description1C8(Name = "Дата", Comment = "", Synonym = "Дата")]
    public DateTime Дата {get; set;}
    [Description1C8(Name = "ДатаНачалаАктуальности", Comment = "", Synonym = "Дата начала актуальности")]
    public DateTime ДатаНачалаАктуальности {get; set;}
    [Description1C8(Name = "ДатаОкончанияАктуальности", Comment = "", Synonym = "Дата окончания актуальности")]
    public DateTime ДатаОкончанияАктуальности {get; set;}
    [Description1C8(Name = "Идентификатор", Comment = "", Synonym = "Идентификатор")]
    public Guid Идентификатор {get; set;}
    [Description1C8(Name = "Критичность", Comment = "", Synonym = "Критичность")]
    // Format 10.0
    public long Критичность {get; set;}
    [Description1C8(Name = "ТекстHTML", Comment = "", Synonym = "Текст HTML")]
    public string ТекстHTML {get; set;}
    [Description1C8(Name = "ТипИнформации", Comment = "", Synonym = "Тип информации")]
    public DBNull ТипИнформации {get; set;}
    #endregion реквізити
    }
}
