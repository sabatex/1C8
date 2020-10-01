using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыНазначенияДатЗапрета", Comment = "", Synonym = "Виды назначения дат запрета")]
    public enum ВидыНазначенияДатЗапрета
    {
        [Description1C8(Name = "ДляВсехПользователей", Comment = "", Synonym = "Для всех пользователей")]
        ДляВсехПользователей,
        [Description1C8(Name = "ДляВсехИнформационныхБаз", Comment = "", Synonym = "Для всех информационных баз")]
        ДляВсехИнформационныхБаз
    }
}
