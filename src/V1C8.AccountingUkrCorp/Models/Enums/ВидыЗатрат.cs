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
    [Table("VydyZatrat")]
    [Description1C8(Name = "ВидыЗатрат", Comment = "(Общ)", Synonym = "Виды затрат")]
    public class ВидыЗатрат:EnumItem
    {
        public static readonly ВидыЗатрат Материальные = new ВидыЗатрат{Name= "Материальные",Synonym="Материальные",Comment="(Общ)"};
        public static readonly ВидыЗатрат ОплатаТруда = new ВидыЗатрат{Name= "ОплатаТруда",Synonym="Оплата труда",Comment="(Общ)"};
        public static readonly ВидыЗатрат ОтчисленияНаСоциальныеНужды = new ВидыЗатрат{Name= "ОтчисленияНаСоциальныеНужды",Synonym="Отчисления на социальные нужды",Comment=""};
        public static readonly ВидыЗатрат Амортизация = new ВидыЗатрат{Name= "Амортизация",Synonym="Амортизация",Comment="(Общ)"};
        public static readonly ВидыЗатрат Прочие = new ВидыЗатрат{Name= "Прочие",Synonym="Прочие",Comment="(Общ)"};
    }
}
