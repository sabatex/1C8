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
    [Table("UstareloVydyDokhodovNDFL")]
    [Description1C8(Name = "УстарелоВидыДоходовНДФЛ", Comment = "(Регл)", Synonym = "ѳ(устарело) Виды доходов НДФЛ")]
    public class УстарелоВидыДоходовНДФЛ:CatalogItem
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
    [Description1C8(Name = "ВидСтавкиРезидента", Comment = "", Synonym = "Ставка налога")]
    public Enums.ВидыСтавокНДФЛ ВидСтавкиРезидента {get; set;}
    [Description1C8(Name = "УДАЛИТЬВидСтавкиНеРезидента", Comment = "", Synonym = "(не используется) Вид ставки нерезидента")]
    public Enums.ВидыСтавокНДФЛ УДАЛИТЬВидСтавкиНеРезидента {get; set;}
    [Description1C8(Name = "УчитыватьВзносы", Comment = "", Synonym = "Учитывать взносы")]
    public bool УчитыватьВзносы {get; set;}
    [Description1C8(Name = "СпособОтраженияВРеглУчете", Comment = "", Synonym = "Способ отражения")]
    public Catalogs.УстарелоСпособыОтраженияЗарплатыВРеглУчете СпособОтраженияВРеглУчете {get; set;}
    [Description1C8(Name = "УдалитьЛьгота", Comment = "", Synonym = "(не используется) Льгота")]
    public Catalogs.УстарелоВидыЛьготПоНДФЛ УдалитьЛьгота {get; set;}
    [Description1C8(Name = "УдалитьУчитыватьВзносы", Comment = "", Synonym = "(не используется) Учитывать взносы")]
    public bool УдалитьУчитыватьВзносы {get; set;}
    [Description1C8(Name = "УдалитьВидВзаиморасчетов", Comment = "", Synonym = "(не используется) Вид взаиморасчетов")]
    public Enums.УдалитьВидыВзаиморасчетовСРаботниками УдалитьВидВзаиморасчетов {get; set;}
    [Description1C8(Name = "ВидСтавкиШахтера", Comment = "", Synonym = "Ставка для шахтеров")]
    public Enums.ВидыСтавокНДФЛ ВидСтавкиШахтера {get; set;}
    [Description1C8(Name = "ВидСтавкиУвеличенная", Comment = "", Synonym = "Увеличенная ставка")]
    public Enums.ВидыСтавокНДФЛ ВидСтавкиУвеличенная {get; set;}
    [Description1C8(Name = "УДАЛИТЬКодДо2011", Comment = "", Synonym = "(не используется) Код до 2011 года")]
    [StringLength(2)]
    public string УДАЛИТЬКодДо2011 {get; set;}
    [Description1C8(Name = "ВидСтавкиВоенныйСбор", Comment = "", Synonym = "Вид ставки военный сбор")]
    public Enums.ВидыСтавокНДФЛ ВидСтавкиВоенныйСбор {get; set;}
    [Description1C8(Name = "УчитыватьНСЛ", Comment = "", Synonym = "Учитывать НСЛ")]
    public bool УчитыватьНСЛ {get; set;}
    #endregion реквізити
    }
}
