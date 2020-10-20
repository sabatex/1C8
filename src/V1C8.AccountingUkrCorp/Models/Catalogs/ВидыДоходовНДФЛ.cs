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
    [Table("VydyDokhodovNDFL")]
    [Description1C8(Name = "ВидыДоходовНДФЛ", Comment = "", Synonym = "Виды доходов НДФЛ")]
    public class ВидыДоходовНДФЛ:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "ВидСтавкиРезидента", Comment = "", Synonym = "Ставка налога")]
        public Enums.ВидыСтавокНДФЛ ВидСтавкиРезидента {get; set;}
        [Description1C8(Name = "СоответствуетОплатеТруда", Comment = "", Synonym = "Соответствует оплате труда")]
        public bool СоответствуетОплатеТруда {get; set;}
        [Description1C8(Name = "УчитыватьВзносы", Comment = "", Synonym = "Учитывать взносы")]
        public bool УчитыватьВзносы {get; set;}
        [Description1C8(Name = "ВидСтавкиУвеличенная", Comment = "", Synonym = "Увеличенная ставка")]
        public Enums.ВидыСтавокНДФЛ ВидСтавкиУвеличенная {get; set;}
        [Description1C8(Name = "УчитыватьНСЛ", Comment = "", Synonym = "Учитывать НСЛ")]
        public bool УчитыватьНСЛ {get; set;}
        [Description1C8(Name = "ОблагаетсяВоеннымСбором", Comment = "", Synonym = "Облагается военным сбором")]
        public Catalogs.ВидыДоходовНДФЛ ОблагаетсяВоеннымСбором {get; set;}
        [Description1C8(Name = "ОблагаетсяСверхПредела", Comment = "", Synonym = "Облагается сверх предела")]
        public Catalogs.ВидыДоходовНДФЛ ОблагаетсяСверхПредела {get; set;}
        #endregion реквізити
        #region tables
        #endregion tables
    }
}
