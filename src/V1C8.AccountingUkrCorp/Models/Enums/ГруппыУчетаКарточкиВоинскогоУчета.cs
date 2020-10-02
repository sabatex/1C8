using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ГруппыУчетаКарточкиВоинскогоУчета", Comment = "", Synonym = "Группы учета карточки воинского учета")]
    public class ГруппыУчетаКарточкиВоинскогоУчета:EnumItem
    {
        public static readonly ГруппыУчетаКарточкиВоинскогоУчета ОфицерскийСостав = new ГруппыУчетаКарточкиВоинскогоУчета{Name= "ОфицерскийСостав",Synonim="Офицерский состав",Comment=""};
        public static readonly ГруппыУчетаКарточкиВоинскогоУчета РедовойСержантскийСтаршинскийСостав = new ГруппыУчетаКарточкиВоинскогоУчета{Name= "РедовойСержантскийСтаршинскийСостав",Synonim="Редовой, сержантский и старшинский состав",Comment=""};
        public static readonly ГруппыУчетаКарточкиВоинскогоУчета Женщины = new ГруппыУчетаКарточкиВоинскогоУчета{Name= "Женщины",Synonim="Женщины",Comment=""};
        public static readonly ГруппыУчетаКарточкиВоинскогоУчета Призывники = new ГруппыУчетаКарточкиВоинскогоУчета{Name= "Призывники",Synonim="Призывники",Comment=""};
    }
}
