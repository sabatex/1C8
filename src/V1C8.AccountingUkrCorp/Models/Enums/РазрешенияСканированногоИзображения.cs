using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "РазрешенияСканированногоИзображения", Comment = "", Synonym = "Разрешения сканированного изображения")]
    public class РазрешенияСканированногоИзображения:EnumItem
    {
        public static readonly РазрешенияСканированногоИзображения dpi200 = new РазрешенияСканированногоИзображения{Name= "dpi200",Synonim="200 dpi",Comment=""};
        public static readonly РазрешенияСканированногоИзображения dpi300 = new РазрешенияСканированногоИзображения{Name= "dpi300",Synonim="300 dpi",Comment=""};
        public static readonly РазрешенияСканированногоИзображения dpi600 = new РазрешенияСканированногоИзображения{Name= "dpi600",Synonim="600 dpi",Comment=""};
        public static readonly РазрешенияСканированногоИзображения dpi1200 = new РазрешенияСканированногоИзображения{Name= "dpi1200",Synonim="1200 dpi",Comment=""};
    }
}
