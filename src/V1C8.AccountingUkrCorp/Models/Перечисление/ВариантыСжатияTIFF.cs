using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВариантыСжатияTIFF", Comment = "", Synonym = "Варианты сжатия TIFF")]
    public enum ВариантыСжатияTIFF
    {
        [Description1C8(Name = "CCITT3", Comment = "", Synonym = "CCITT3")]
        CCITT3,
        [Description1C8(Name = "CCITT4", Comment = "", Synonym = "CCITT4")]
        CCITT4,
        [Description1C8(Name = "LZW", Comment = "", Synonym = "LZW")]
        LZW,
        [Description1C8(Name = "RLE", Comment = "", Synonym = "RLE")]
        RLE,
        [Description1C8(Name = "БезСжатия", Comment = "", Synonym = "Без сжатия")]
        БезСжатия
    }
}
