using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыКомпенсацииПереработки", Comment = "", Synonym = "Способы компенсации переработки")]
    public enum СпособыКомпенсацииПереработки
    {
        [Description1C8(Name = "ПовышеннаяОплата", Comment = "", Synonym = "Повышенная оплата")]
        ПовышеннаяОплата,
        [Description1C8(Name = "Отгул", Comment = "", Synonym = "Отгул")]
        Отгул
    }
}
