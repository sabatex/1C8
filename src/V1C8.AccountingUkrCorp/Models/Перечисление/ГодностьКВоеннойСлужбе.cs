using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ГодностьКВоеннойСлужбе", Comment = "", Synonym = "Годность к военной службе")]
    public enum ГодностьКВоеннойСлужбе
    {
        [Description1C8(Name = "Годен", Comment = "", Synonym = "Годен к военной службе")]
        Годен,
        [Description1C8(Name = "ГоденСОграничениями", Comment = "", Synonym = "Ограниченно годен к военной службе")]
        ГоденСОграничениями,
        [Description1C8(Name = "ОграниченноГоден", Comment = "", Synonym = "Не годен в мирное время, ограниченно годен в военное время")]
        ОграниченноГоден,
        [Description1C8(Name = "ВременноНеГоден", Comment = "", Synonym = "Временно не годен к военной службе")]
        ВременноНеГоден,
        [Description1C8(Name = "НеГоден", Comment = "", Synonym = "Не годен к военной службе")]
        НеГоден
    }
}
