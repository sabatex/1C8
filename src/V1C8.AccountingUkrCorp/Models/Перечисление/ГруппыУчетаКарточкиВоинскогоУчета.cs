using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ГруппыУчетаКарточкиВоинскогоУчета", Comment = "", Synonym = "Группы учета карточки воинского учета")]
    public enum ГруппыУчетаКарточкиВоинскогоУчета
    {
        [Description1C8(Name = "ОфицерскийСостав", Comment = "", Synonym = "Офицерский состав")]
        ОфицерскийСостав,
        [Description1C8(Name = "РедовойСержантскийСтаршинскийСостав", Comment = "", Synonym = "Редовой, сержантский и старшинский состав")]
        РедовойСержантскийСтаршинскийСостав,
        [Description1C8(Name = "Женщины", Comment = "", Synonym = "Женщины")]
        Женщины,
        [Description1C8(Name = "Призывники", Comment = "", Synonym = "Призывники")]
        Призывники
    }
}
