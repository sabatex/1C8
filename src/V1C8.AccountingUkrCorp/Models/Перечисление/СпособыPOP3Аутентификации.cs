using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыPOP3Аутентификации", Comment = "", Synonym = "Способы POP3 аутентификации")]
    public enum СпособыPOP3Аутентификации
    {
        [Description1C8(Name = "APOP", Comment = "", Synonym = "APOP")]
        APOP,
        [Description1C8(Name = "CramMD5", Comment = "", Synonym = "Cram MD5")]
        CramMD5,
        [Description1C8(Name = "Обычная", Comment = "", Synonym = "Обычная")]
        Обычная
    }
}
