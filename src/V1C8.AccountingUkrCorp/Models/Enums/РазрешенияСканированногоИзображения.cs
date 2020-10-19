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
    [Table("RazreshenyiaSkanyrovannohoYzobrazhenyia")]
    [Description1C8(Name = "РазрешенияСканированногоИзображения", Comment = "", Synonym = "Разрешения сканированного изображения")]
    public class РазрешенияСканированногоИзображения:EnumItem
    {
        public static readonly РазрешенияСканированногоИзображения dpi200 = new РазрешенияСканированногоИзображения{Name= "dpi200",Synonym="200 dpi",Comment=""};
        public static readonly РазрешенияСканированногоИзображения dpi300 = new РазрешенияСканированногоИзображения{Name= "dpi300",Synonym="300 dpi",Comment=""};
        public static readonly РазрешенияСканированногоИзображения dpi600 = new РазрешенияСканированногоИзображения{Name= "dpi600",Synonym="600 dpi",Comment=""};
        public static readonly РазрешенияСканированногоИзображения dpi1200 = new РазрешенияСканированногоИзображения{Name= "dpi1200",Synonym="1200 dpi",Comment=""};
    }
}
