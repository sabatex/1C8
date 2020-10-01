using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыSMTPАутентификации", Comment = "", Synonym = "Способы SMTP аутентификации")]
    public enum СпособыSMTPАутентификации
    {
        [Description1C8(Name = "CramMD5", Comment = "", Synonym = "Cram MD5")]
        CramMD5,
        [Description1C8(Name = "Login", Comment = "", Synonym = "Login")]
        Login,
        [Description1C8(Name = "Plain", Comment = "", Synonym = "Plain")]
        Plain,
        [Description1C8(Name = "БезАутентификации", Comment = "", Synonym = "Без аутентификации")]
        БезАутентификации,
        [Description1C8(Name = "ПоУмолчанию", Comment = "", Synonym = "По умолчанию")]
        ПоУмолчанию
    }
}
