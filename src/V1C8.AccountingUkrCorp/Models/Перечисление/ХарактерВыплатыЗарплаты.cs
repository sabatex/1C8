using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ХарактерВыплатыЗарплаты", Comment = "Выплата конкретного начисления, аванса или окончательная выплата зарплаты 'под расчет'", Synonym = "Характер выплаты зарплаты")]
    public enum ХарактерВыплатыЗарплаты
    {
        [Description1C8(Name = "Аванс", Comment = "", Synonym = "С авансом")]
        Аванс,
        [Description1C8(Name = "Межрасчет", Comment = "", Synonym = "В межрасчетный период")]
        Межрасчет,
        [Description1C8(Name = "Зарплата", Comment = "", Synonym = "С зарплатой")]
        Зарплата
    }
}
