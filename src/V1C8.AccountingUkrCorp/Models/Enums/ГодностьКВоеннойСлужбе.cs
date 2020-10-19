using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Table("HodnostKVoennoiSluzhbe")]
    [Description1C8(Name = "ГодностьКВоеннойСлужбе", Comment = "", Synonym = "Годность к военной службе")]
    public class ГодностьКВоеннойСлужбе:EnumItem
    {
        public static readonly ГодностьКВоеннойСлужбе Годен = new ГодностьКВоеннойСлужбе{Name= "Годен",Synonym="Годен к военной службе",Comment=""};
        public static readonly ГодностьКВоеннойСлужбе ГоденСОграничениями = new ГодностьКВоеннойСлужбе{Name= "ГоденСОграничениями",Synonym="Ограниченно годен к военной службе",Comment=""};
        public static readonly ГодностьКВоеннойСлужбе ОграниченноГоден = new ГодностьКВоеннойСлужбе{Name= "ОграниченноГоден",Synonym="Не годен в мирное время, ограниченно годен в военное время",Comment=""};
        public static readonly ГодностьКВоеннойСлужбе ВременноНеГоден = new ГодностьКВоеннойСлужбе{Name= "ВременноНеГоден",Synonym="Временно не годен к военной службе",Comment=""};
        public static readonly ГодностьКВоеннойСлужбе НеГоден = new ГодностьКВоеннойСлужбе{Name= "НеГоден",Synonym="Не годен к военной службе",Comment=""};
    }
}
