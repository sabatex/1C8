using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "Периодичность", Comment = "(Упр)", Synonym = "Периодичность")]
    public class Периодичность:EnumItem
    {
        public static readonly Периодичность День = new Периодичность{Name= "День",Synonym="День",Comment=""};
        public static readonly Периодичность Неделя = new Периодичность{Name= "Неделя",Synonym="Неделя",Comment=""};
        public static readonly Периодичность Месяц = new Периодичность{Name= "Месяц",Synonym="Месяц",Comment=""};
        public static readonly Периодичность Квартал = new Периодичность{Name= "Квартал",Synonym="Квартал",Comment=""};
        public static readonly Периодичность Год = new Периодичность{Name= "Год",Synonym="Год",Comment=""};
        public static readonly Периодичность Декада = new Периодичность{Name= "Декада",Synonym="Декада",Comment=""};
        public static readonly Периодичность Полугодие = new Периодичность{Name= "Полугодие",Synonym="Полугодие",Comment=""};
    }
}
