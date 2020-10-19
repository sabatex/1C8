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
    [Table("SposobySMTPAutentyfykatsyy")]
    [Description1C8(Name = "СпособыSMTPАутентификации", Comment = "", Synonym = "Способы SMTP аутентификации")]
    public class СпособыSMTPАутентификации:EnumItem
    {
        public static readonly СпособыSMTPАутентификации CramMD5 = new СпособыSMTPАутентификации{Name= "CramMD5",Synonym="Cram MD5",Comment=""};
        public static readonly СпособыSMTPАутентификации Login = new СпособыSMTPАутентификации{Name= "Login",Synonym="Login",Comment=""};
        public static readonly СпособыSMTPАутентификации Plain = new СпособыSMTPАутентификации{Name= "Plain",Synonym="Plain",Comment=""};
        public static readonly СпособыSMTPАутентификации БезАутентификации = new СпособыSMTPАутентификации{Name= "БезАутентификации",Synonym="Без аутентификации",Comment=""};
        public static readonly СпособыSMTPАутентификации ПоУмолчанию = new СпособыSMTPАутентификации{Name= "ПоУмолчанию",Synonym="По умолчанию",Comment=""};
    }
}
