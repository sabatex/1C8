using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыУдержанийДляТиповыхОтчетов", Comment = "", Synonym = "Виды удержаний для типовых отчетов")]
    public enum ВидыУдержанийДляТиповыхОтчетов
    {
        [Description1C8(Name = "ПрофсоюзныеВзносы", Comment = "", Synonym = "Профсоюзные взносы")]
        ПрофсоюзныеВзносы,
        [Description1C8(Name = "Алименты", Comment = "", Synonym = "Алименты")]
        Алименты
    }
}
