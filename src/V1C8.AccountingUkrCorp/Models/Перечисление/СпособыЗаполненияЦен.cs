using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыЗаполненияЦен", Comment = "(Общ)", Synonym = "Способ заполнения цен")]
    public enum СпособыЗаполненияЦен
    {
        [Description1C8(Name = "ПоЦенамНоменклатуры", Comment = "(Общ)", Synonym = "По ценам номенклатуры")]
        ПоЦенамНоменклатуры,
        [Description1C8(Name = "ПоЦенамНоменклатурыКонтрагентов", Comment = "(Упр)", Synonym = "По ценам номенклатуры контрагентов")]
        ПоЦенамНоменклатурыКонтрагентов,
        [Description1C8(Name = "ПоНоменклатуреИЦенамКонтрагентов", Comment = "(Упр)", Synonym = "По номенклатуре и ценам контрагентов")]
        ПоНоменклатуреИЦенамКонтрагентов,
        [Description1C8(Name = "ПоРозничнымЦенам", Comment = "(Общ)", Synonym = "По розничным ценам")]
        ПоРозничнымЦенам
    }
}
