using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВариантыСжатияTIFF", Comment = "", Synonym = "Варианты сжатия TIFF")]
    public class ВариантыСжатияTIFF:EnumItem
    {
        public static readonly ВариантыСжатияTIFF CCITT3 = new ВариантыСжатияTIFF{Name= "CCITT3",Synonim="CCITT3",Comment=""};
        public static readonly ВариантыСжатияTIFF CCITT4 = new ВариантыСжатияTIFF{Name= "CCITT4",Synonim="CCITT4",Comment=""};
        public static readonly ВариантыСжатияTIFF LZW = new ВариантыСжатияTIFF{Name= "LZW",Synonim="LZW",Comment=""};
        public static readonly ВариантыСжатияTIFF RLE = new ВариантыСжатияTIFF{Name= "RLE",Synonim="RLE",Comment=""};
        public static readonly ВариантыСжатияTIFF БезСжатия = new ВариантыСжатияTIFF{Name= "БезСжатия",Synonim="Без сжатия",Comment=""};
    }
}
