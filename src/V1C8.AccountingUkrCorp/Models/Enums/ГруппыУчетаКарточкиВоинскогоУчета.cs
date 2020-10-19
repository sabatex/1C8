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
    [Table("HruppyUchetaKartochkyVoynskohoUcheta")]
    [Description1C8(Name = "ГруппыУчетаКарточкиВоинскогоУчета", Comment = "", Synonym = "Группы учета карточки воинского учета")]
    public class ГруппыУчетаКарточкиВоинскогоУчета:EnumItem
    {
        public static readonly ГруппыУчетаКарточкиВоинскогоУчета ОфицерскийСостав = new ГруппыУчетаКарточкиВоинскогоУчета{Name= "ОфицерскийСостав",Synonym="Офицерский состав",Comment=""};
        public static readonly ГруппыУчетаКарточкиВоинскогоУчета РедовойСержантскийСтаршинскийСостав = new ГруппыУчетаКарточкиВоинскогоУчета{Name= "РедовойСержантскийСтаршинскийСостав",Synonym="Редовой, сержантский и старшинский состав",Comment=""};
        public static readonly ГруппыУчетаКарточкиВоинскогоУчета Женщины = new ГруппыУчетаКарточкиВоинскогоУчета{Name= "Женщины",Synonym="Женщины",Comment=""};
        public static readonly ГруппыУчетаКарточкиВоинскогоУчета Призывники = new ГруппыУчетаКарточкиВоинскогоУчета{Name= "Призывники",Synonym="Призывники",Comment=""};
    }
}
