using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВариантыИспользованияПериодаНачисления", Comment = "", Synonym = "Варианты использования периода начисления")]
    public class ВариантыИспользованияПериодаНачисления:EnumItem
    {
        public static readonly ВариантыИспользованияПериодаНачисления ПериодДействия = new ВариантыИспользованияПериодаНачисления{Name= "ПериодДействия",Synonim="Период действия",Comment=""};
        public static readonly ВариантыИспользованияПериодаНачисления БазовыйПериод = new ВариантыИспользованияПериодаНачисления{Name= "БазовыйПериод",Synonim="Базовый период",Comment=""};
        public static readonly ВариантыИспользованияПериодаНачисления НеИспользовать = new ВариантыИспользованияПериодаНачисления{Name= "НеИспользовать",Synonim="Не использовать",Comment=""};
    }
}
