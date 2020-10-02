using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ФормыОбучения", Comment = "", Synonym = "Формы обучения")]
    public class ФормыОбучения:EnumItem
    {
        public static readonly ФормыОбучения Очная = new ФормыОбучения{Name= "Очная",Synonym="Очная",Comment=""};
        public static readonly ФормыОбучения Заочная = new ФормыОбучения{Name= "Заочная",Synonym="Заочная",Comment=""};
        public static readonly ФормыОбучения Вечерняя = new ФормыОбучения{Name= "Вечерняя",Synonym="Вечерняя",Comment=""};
        public static readonly ФормыОбучения Экстернат = new ФормыОбучения{Name= "Экстернат",Synonym="Экстернат",Comment=""};
        public static readonly ФормыОбучения Прочее = new ФормыОбучения{Name= "Прочее",Synonym="Прочее",Comment=""};
    }
}
