using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыСобытийОС", Comment = "(Регл)", Synonym = "Виды событий с основными средствами")]
    public class ВидыСобытийОС:EnumItem
    {
        public static readonly ВидыСобытийОС ВводВЭксплуатацию = new ВидыСобытийОС{Name= "ВводВЭксплуатацию",Synonym="Ввод в эксплуатацию",Comment=""};
        public static readonly ВидыСобытийОС НачислениеАмортизации = new ВидыСобытийОС{Name= "НачислениеАмортизации",Synonym="Начисление амортизации",Comment=""};
        public static readonly ВидыСобытийОС ВнутреннееПеремещение = new ВидыСобытийОС{Name= "ВнутреннееПеремещение",Synonym="Внутреннее перемещение",Comment=""};
        public static readonly ВидыСобытийОС ЧастичнаяЛиквидация = new ВидыСобытийОС{Name= "ЧастичнаяЛиквидация",Synonym="Частичная ликвидация",Comment=""};
        public static readonly ВидыСобытийОС Модернизация = new ВидыСобытийОС{Name= "Модернизация",Synonym="Модернизация и ремонт",Comment=""};
        public static readonly ВидыСобытийОС ПодготовкаКПередаче = new ВидыСобытийОС{Name= "ПодготовкаКПередаче",Synonym="Подготовка к передаче",Comment=""};
        public static readonly ВидыСобытийОС Передача = new ВидыСобытийОС{Name= "Передача",Synonym="Передача",Comment=""};
        public static readonly ВидыСобытийОС Списание = new ВидыСобытийОС{Name= "Списание",Synonym="Списание",Comment=""};
        public static readonly ВидыСобытийОС Прочее = new ВидыСобытийОС{Name= "Прочее",Synonym="Прочее",Comment="Прочие состояния (пользовательские)"};
        public static readonly ВидыСобытийОС Ремонт = new ВидыСобытийОС{Name= "Ремонт",Synonym="Ремонт",Comment=""};
    }
}
