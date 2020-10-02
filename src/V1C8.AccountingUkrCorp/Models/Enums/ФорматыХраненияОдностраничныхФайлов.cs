using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ФорматыХраненияОдностраничныхФайлов", Comment = "", Synonym = "Форматы хранения одностраничных файлов")]
    public class ФорматыХраненияОдностраничныхФайлов:EnumItem
    {
        public static readonly ФорматыХраненияОдностраничныхФайлов BMP = new ФорматыХраненияОдностраничныхФайлов{Name= "BMP",Synonim="BMP",Comment=""};
        public static readonly ФорматыХраненияОдностраничныхФайлов GIF = new ФорматыХраненияОдностраничныхФайлов{Name= "GIF",Synonim="GIF",Comment=""};
        public static readonly ФорматыХраненияОдностраничныхФайлов JPG = new ФорматыХраненияОдностраничныхФайлов{Name= "JPG",Synonim="JPG",Comment=""};
        public static readonly ФорматыХраненияОдностраничныхФайлов PDF = new ФорматыХраненияОдностраничныхФайлов{Name= "PDF",Synonim="PDF",Comment=""};
        public static readonly ФорматыХраненияОдностраничныхФайлов PNG = new ФорматыХраненияОдностраничныхФайлов{Name= "PNG",Synonim="PNG",Comment=""};
        public static readonly ФорматыХраненияОдностраничныхФайлов TIF = new ФорматыХраненияОдностраничныхФайлов{Name= "TIF",Synonim="TIF",Comment=""};
    }
}
