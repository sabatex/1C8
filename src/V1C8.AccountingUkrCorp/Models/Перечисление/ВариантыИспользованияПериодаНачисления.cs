using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВариантыИспользованияПериодаНачисления", Comment = "", Synonym = "Варианты использования периода начисления")]
    public enum ВариантыИспользованияПериодаНачисления
    {
        [Description1C8(Name = "ПериодДействия", Comment = "", Synonym = "Период действия")]
        ПериодДействия,
        [Description1C8(Name = "БазовыйПериод", Comment = "", Synonym = "Базовый период")]
        БазовыйПериод,
        [Description1C8(Name = "НеИспользовать", Comment = "", Synonym = "Не использовать")]
        НеИспользовать
    }
}
