using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "РежимыЗавершенияРаботыПользователей", Comment = "", Synonym = "Режимы завершения работы пользователей")]
    public class РежимыЗавершенияРаботыПользователей:EnumItem
    {
        public static readonly РежимыЗавершенияРаботыПользователей РазрешитьРаботу = new РежимыЗавершенияРаботыПользователей{Name= "РазрешитьРаботу",Synonym="Разрешить работу",Comment=""};
        public static readonly РежимыЗавершенияРаботыПользователей ПредупредитьПользователейОЗавершенииРаботы = new РежимыЗавершенияРаботыПользователей{Name= "ПредупредитьПользователейОЗавершенииРаботы",Synonym="Завершить при наличии подтверждения пользователя",Comment=""};
        public static readonly РежимыЗавершенияРаботыПользователей ЗавершитьССохранениемДанныхПользователей = new РежимыЗавершенияРаботыПользователей{Name= "ЗавершитьССохранениемДанныхПользователей",Synonym="Завершить после ожидания подтверждения пользователя",Comment=""};
        public static readonly РежимыЗавершенияРаботыПользователей ПрекратитьРаботуБезусловно = new РежимыЗавершенияРаботыПользователей{Name= "ПрекратитьРаботуБезусловно",Synonym="Завершить с сохранением данных пользователя",Comment=""};
    }
}
