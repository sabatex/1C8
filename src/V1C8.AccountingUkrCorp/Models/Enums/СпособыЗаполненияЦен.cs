using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыЗаполненияЦен", Comment = "(Общ)", Synonym = "Способ заполнения цен")]
    public class СпособыЗаполненияЦен:EnumItem
    {
        public static readonly СпособыЗаполненияЦен ПоЦенамНоменклатуры = new СпособыЗаполненияЦен{Name= "ПоЦенамНоменклатуры",Synonym="По ценам номенклатуры",Comment="(Общ)"};
        public static readonly СпособыЗаполненияЦен ПоЦенамНоменклатурыКонтрагентов = new СпособыЗаполненияЦен{Name= "ПоЦенамНоменклатурыКонтрагентов",Synonym="По ценам номенклатуры контрагентов",Comment="(Упр)"};
        public static readonly СпособыЗаполненияЦен ПоНоменклатуреИЦенамКонтрагентов = new СпособыЗаполненияЦен{Name= "ПоНоменклатуреИЦенамКонтрагентов",Synonym="По номенклатуре и ценам контрагентов",Comment="(Упр)"};
        public static readonly СпособыЗаполненияЦен ПоРозничнымЦенам = new СпособыЗаполненияЦен{Name= "ПоРозничнымЦенам",Synonym="По розничным ценам",Comment="(Общ)"};
    }
}
