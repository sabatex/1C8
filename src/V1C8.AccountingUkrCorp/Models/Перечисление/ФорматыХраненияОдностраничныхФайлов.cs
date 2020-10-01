using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ФорматыХраненияОдностраничныхФайлов", Comment = "", Synonym = "Форматы хранения одностраничных файлов")]
    public enum ФорматыХраненияОдностраничныхФайлов
    {
        [Description1C8(Name = "BMP", Comment = "", Synonym = "BMP")]
        BMP,
        [Description1C8(Name = "GIF", Comment = "", Synonym = "GIF")]
        GIF,
        [Description1C8(Name = "JPG", Comment = "", Synonym = "JPG")]
        JPG,
        [Description1C8(Name = "PDF", Comment = "", Synonym = "PDF")]
        PDF,
        [Description1C8(Name = "PNG", Comment = "", Synonym = "PNG")]
        PNG,
        [Description1C8(Name = "TIF", Comment = "", Synonym = "TIF")]
        TIF
    }
}
