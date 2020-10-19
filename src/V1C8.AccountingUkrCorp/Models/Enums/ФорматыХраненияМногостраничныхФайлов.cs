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
    [Table("FormatyKhranenyiaMnohostranychnykhFailov")]
    [Description1C8(Name = "ФорматыХраненияМногостраничныхФайлов", Comment = "", Synonym = "Форматы хранения многостраничных файлов")]
    public class ФорматыХраненияМногостраничныхФайлов:EnumItem
    {
        public static readonly ФорматыХраненияМногостраничныхФайлов PDF = new ФорматыХраненияМногостраничныхФайлов{Name= "PDF",Synonym="PDF",Comment=""};
        public static readonly ФорматыХраненияМногостраничныхФайлов TIF = new ФорматыХраненияМногостраничныхФайлов{Name= "TIF",Synonym="TIF",Comment=""};
    }
}
