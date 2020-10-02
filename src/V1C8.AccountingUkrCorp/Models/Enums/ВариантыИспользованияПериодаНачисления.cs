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
        public static readonly ВариантыИспользованияПериодаНачисления ПериодДействия = new ВариантыИспользованияПериодаНачисления{Name= "ПериодДействия",Synonym="Период действия",Comment=""};
        public static readonly ВариантыИспользованияПериодаНачисления БазовыйПериод = new ВариантыИспользованияПериодаНачисления{Name= "БазовыйПериод",Synonym="Базовый период",Comment=""};
        public static readonly ВариантыИспользованияПериодаНачисления НеИспользовать = new ВариантыИспользованияПериодаНачисления{Name= "НеИспользовать",Synonym="Не использовать",Comment=""};
    }
}
