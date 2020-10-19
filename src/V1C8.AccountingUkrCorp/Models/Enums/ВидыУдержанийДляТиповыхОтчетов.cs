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
    [Table("VydyUderzhanyiDliaTypovykhOtchetov")]
    [Description1C8(Name = "ВидыУдержанийДляТиповыхОтчетов", Comment = "", Synonym = "Виды удержаний для типовых отчетов")]
    public class ВидыУдержанийДляТиповыхОтчетов:EnumItem
    {
        public static readonly ВидыУдержанийДляТиповыхОтчетов ПрофсоюзныеВзносы = new ВидыУдержанийДляТиповыхОтчетов{Name= "ПрофсоюзныеВзносы",Synonym="Профсоюзные взносы",Comment=""};
        public static readonly ВидыУдержанийДляТиповыхОтчетов Алименты = new ВидыУдержанийДляТиповыхОтчетов{Name= "Алименты",Synonym="Алименты",Comment=""};
    }
}
