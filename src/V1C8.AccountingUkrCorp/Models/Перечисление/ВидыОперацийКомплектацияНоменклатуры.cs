using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОперацийКомплектацияНоменклатуры", Comment = "", Synonym = "Виды операций документа 'Комплектация нменклатуры'")]
    public enum ВидыОперацийКомплектацияНоменклатуры
    {
        [Description1C8(Name = "Комплектация", Comment = "", Synonym = "Комплектация")]
        Комплектация,
        [Description1C8(Name = "Разукомплектация", Comment = "", Synonym = "Разукомплектация")]
        Разукомплектация
    }
}
