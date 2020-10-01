using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ПорядокОпределенияРасчетногоПериодаСреднегоЗаработка", Comment = "", Synonym = "Порядок определения расчетного периода среднего заработка")]
    public enum ПорядокОпределенияРасчетногоПериодаСреднегоЗаработка
    {
        [Description1C8(Name = "ПоТрудовомуЗаконодательству", Comment = "", Synonym = "В соответствии с законодательством")]
        ПоТрудовомуЗаконодательству,
        [Description1C8(Name = "ПоКолдоговору", Comment = "", Synonym = "В соответствии с коллективным договором")]
        ПоКолдоговору
    }
}
