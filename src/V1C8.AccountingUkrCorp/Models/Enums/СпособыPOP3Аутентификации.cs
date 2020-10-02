using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыPOP3Аутентификации", Comment = "", Synonym = "Способы POP3 аутентификации")]
    public class СпособыPOP3Аутентификации:EnumItem
    {
        public static readonly СпособыPOP3Аутентификации APOP = new СпособыPOP3Аутентификации{Name= "APOP",Synonim="APOP",Comment=""};
        public static readonly СпособыPOP3Аутентификации CramMD5 = new СпособыPOP3Аутентификации{Name= "CramMD5",Synonim="Cram MD5",Comment=""};
        public static readonly СпособыPOP3Аутентификации Обычная = new СпособыPOP3Аутентификации{Name= "Обычная",Synonim="Обычная",Comment=""};
    }
}
