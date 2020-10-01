using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыСравненияВерсийФайлов", Comment = "", Synonym = "Способы сравнения версий файлов")]
    public enum СпособыСравненияВерсийФайлов
    {
        [Description1C8(Name = "MicrosoftOfficeWord", Comment = "", Synonym = "Microsoft Office Word")]
        MicrosoftOfficeWord,
        [Description1C8(Name = "OpenOfficeOrgWriter", Comment = "", Synonym = "OpenOffice.org Writer")]
        OpenOfficeOrgWriter
    }
}
