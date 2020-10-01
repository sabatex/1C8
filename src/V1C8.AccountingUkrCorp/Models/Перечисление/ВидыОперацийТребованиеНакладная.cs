using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОперацийТребованиеНакладная", Comment = "(Общ)", Synonym = "Виды операций документа 'Требование-накладная'")]
    public enum ВидыОперацийТребованиеНакладная
    {
        [Description1C8(Name = "Материалы", Comment = "", Synonym = "Материалы")]
        Материалы,
        [Description1C8(Name = "Оборудование", Comment = "", Synonym = "Оборудование")]
        Оборудование
    }
}
