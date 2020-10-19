using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Table("SposobyPredostavlenyiaZaimaSotrudnyku")]
    [Description1C8(Name = "СпособыПредоставленияЗаймаСотруднику", Comment = "", Synonym = "Способы предоставления займа сотруднику")]
    public class СпособыПредоставленияЗаймаСотруднику:EnumItem
    {
        public static readonly СпособыПредоставленияЗаймаСотруднику Единовременно = new СпособыПредоставленияЗаймаСотруднику{Name= "Единовременно",Synonym="Единовременно",Comment=""};
        public static readonly СпособыПредоставленияЗаймаСотруднику Траншами = new СпособыПредоставленияЗаймаСотруднику{Name= "Траншами",Synonym="Отдельными траншами",Comment=""};
    }
}
