using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОперацийОтчетОРозничныхПродажах", Comment = "", Synonym = "Виды операций отчет о розничных продажах")]
    public enum ВидыОперацийОтчетОРозничныхПродажах
    {
        [Description1C8(Name = "ОтчетККМОПродажах", Comment = "", Synonym = "ККМ")]
        ОтчетККМОПродажах,
        [Description1C8(Name = "ОтчетНТТОПродажах", Comment = "", Synonym = "НТТ")]
        ОтчетНТТОПродажах
    }
}
