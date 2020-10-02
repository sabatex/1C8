using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыУдержанийДляТиповыхОтчетов", Comment = "", Synonym = "Виды удержаний для типовых отчетов")]
    public class ВидыУдержанийДляТиповыхОтчетов:EnumItem
    {
        public static readonly ВидыУдержанийДляТиповыхОтчетов ПрофсоюзныеВзносы = new ВидыУдержанийДляТиповыхОтчетов{Name= "ПрофсоюзныеВзносы",Synonim="Профсоюзные взносы",Comment=""};
        public static readonly ВидыУдержанийДляТиповыхОтчетов Алименты = new ВидыУдержанийДляТиповыхОтчетов{Name= "Алименты",Synonim="Алименты",Comment=""};
    }
}
