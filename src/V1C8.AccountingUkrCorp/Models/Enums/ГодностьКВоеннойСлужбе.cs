using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ГодностьКВоеннойСлужбе", Comment = "", Synonym = "Годность к военной службе")]
    public class ГодностьКВоеннойСлужбе:EnumItem
    {
        public static readonly ГодностьКВоеннойСлужбе Годен = new ГодностьКВоеннойСлужбе{Name= "Годен",Synonim="Годен к военной службе",Comment=""};
        public static readonly ГодностьКВоеннойСлужбе ГоденСОграничениями = new ГодностьКВоеннойСлужбе{Name= "ГоденСОграничениями",Synonim="Ограниченно годен к военной службе",Comment=""};
        public static readonly ГодностьКВоеннойСлужбе ОграниченноГоден = new ГодностьКВоеннойСлужбе{Name= "ОграниченноГоден",Synonim="Не годен в мирное время, ограниченно годен в военное время",Comment=""};
        public static readonly ГодностьКВоеннойСлужбе ВременноНеГоден = new ГодностьКВоеннойСлужбе{Name= "ВременноНеГоден",Synonim="Временно не годен к военной службе",Comment=""};
        public static readonly ГодностьКВоеннойСлужбе НеГоден = new ГодностьКВоеннойСлужбе{Name= "НеГоден",Synonim="Не годен к военной службе",Comment=""};
    }
}
