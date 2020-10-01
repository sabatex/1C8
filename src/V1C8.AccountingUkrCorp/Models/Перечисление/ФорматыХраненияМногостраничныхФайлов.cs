using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ФорматыХраненияМногостраничныхФайлов", Comment = "", Synonym = "Форматы хранения многостраничных файлов")]
    public enum ФорматыХраненияМногостраничныхФайлов
    {
        [Description1C8(Name = "PDF", Comment = "", Synonym = "PDF")]
        PDF,
        [Description1C8(Name = "TIF", Comment = "", Synonym = "TIF")]
        TIF
    }
}
