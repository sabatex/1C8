using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "РежимыЗавершенияРаботыПользователей", Comment = "", Synonym = "Режимы завершения работы пользователей")]
    public enum РежимыЗавершенияРаботыПользователей
    {
        [Description1C8(Name = "РазрешитьРаботу", Comment = "", Synonym = "Разрешить работу")]
        РазрешитьРаботу,
        [Description1C8(Name = "ПредупредитьПользователейОЗавершенииРаботы", Comment = "", Synonym = "Завершить при наличии подтверждения пользователя")]
        ПредупредитьПользователейОЗавершенииРаботы,
        [Description1C8(Name = "ЗавершитьССохранениемДанныхПользователей", Comment = "", Synonym = "Завершить после ожидания подтверждения пользователя")]
        ЗавершитьССохранениемДанныхПользователей,
        [Description1C8(Name = "ПрекратитьРаботуБезусловно", Comment = "", Synonym = "Завершить с сохранением данных пользователя")]
        ПрекратитьРаботуБезусловно
    }
}
