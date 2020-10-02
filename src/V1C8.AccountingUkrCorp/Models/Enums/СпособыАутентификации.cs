using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыАутентификации", Comment = "", Synonym = "Способы аутентификации")]
    public class СпособыАутентификации:EnumItem
    {
        public static readonly СпособыАутентификации Анонимный = new СпособыАутентификации{Name= "Анонимный",Synonim="Анонимный (Anonymous)",Comment=""};
        public static readonly СпособыАутентификации ОбычнаяПроверка = new СпособыАутентификации{Name= "ОбычнаяПроверка",Synonim="Обычная проверка (Basic)",Comment=""};
    }
}
