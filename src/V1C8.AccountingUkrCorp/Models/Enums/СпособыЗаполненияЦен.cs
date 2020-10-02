using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыЗаполненияЦен", Comment = "(Общ)", Synonym = "Способ заполнения цен")]
    public class СпособыЗаполненияЦен:EnumItem
    {
        public static readonly СпособыЗаполненияЦен ПоЦенамНоменклатуры = new СпособыЗаполненияЦен{Name= "ПоЦенамНоменклатуры",Synonim="По ценам номенклатуры",Comment="(Общ)"};
        public static readonly СпособыЗаполненияЦен ПоЦенамНоменклатурыКонтрагентов = new СпособыЗаполненияЦен{Name= "ПоЦенамНоменклатурыКонтрагентов",Synonim="По ценам номенклатуры контрагентов",Comment="(Упр)"};
        public static readonly СпособыЗаполненияЦен ПоНоменклатуреИЦенамКонтрагентов = new СпособыЗаполненияЦен{Name= "ПоНоменклатуреИЦенамКонтрагентов",Synonim="По номенклатуре и ценам контрагентов",Comment="(Упр)"};
        public static readonly СпособыЗаполненияЦен ПоРозничнымЦенам = new СпособыЗаполненияЦен{Name= "ПоРозничнымЦенам",Synonim="По розничным ценам",Comment="(Общ)"};
    }
}
