using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыРасчетаВзносов", Comment = "(Общ)", Synonym = "Способы расчета взносов")]
    public enum СпособыРасчетаВзносов
    {
        [Description1C8(Name = "Взносы", Comment = "(Общ)", Synonym = "Взносы")]
        Взносы,
        [Description1C8(Name = "ВзносыФОТ", Comment = "(Общ)", Synonym = "Взносы ФОТ")]
        ВзносыФОТ
    }
}
