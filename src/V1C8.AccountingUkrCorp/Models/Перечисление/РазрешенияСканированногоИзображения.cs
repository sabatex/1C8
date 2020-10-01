using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "РазрешенияСканированногоИзображения", Comment = "", Synonym = "Разрешения сканированного изображения")]
    public enum РазрешенияСканированногоИзображения
    {
        [Description1C8(Name = "dpi200", Comment = "", Synonym = "200 dpi")]
        dpi200,
        [Description1C8(Name = "dpi300", Comment = "", Synonym = "300 dpi")]
        dpi300,
        [Description1C8(Name = "dpi600", Comment = "", Synonym = "600 dpi")]
        dpi600,
        [Description1C8(Name = "dpi1200", Comment = "", Synonym = "1200 dpi")]
        dpi1200
    }
}
