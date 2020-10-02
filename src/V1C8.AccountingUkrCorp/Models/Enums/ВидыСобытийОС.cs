using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыСобытийОС", Comment = "(Регл)", Synonym = "Виды событий с основными средствами")]
    public class ВидыСобытийОС:EnumItem
    {
        public static readonly ВидыСобытийОС ВводВЭксплуатацию = new ВидыСобытийОС{Name= "ВводВЭксплуатацию",Synonim="Ввод в эксплуатацию",Comment=""};
        public static readonly ВидыСобытийОС НачислениеАмортизации = new ВидыСобытийОС{Name= "НачислениеАмортизации",Synonim="Начисление амортизации",Comment=""};
        public static readonly ВидыСобытийОС ВнутреннееПеремещение = new ВидыСобытийОС{Name= "ВнутреннееПеремещение",Synonim="Внутреннее перемещение",Comment=""};
        public static readonly ВидыСобытийОС ЧастичнаяЛиквидация = new ВидыСобытийОС{Name= "ЧастичнаяЛиквидация",Synonim="Частичная ликвидация",Comment=""};
        public static readonly ВидыСобытийОС Модернизация = new ВидыСобытийОС{Name= "Модернизация",Synonim="Модернизация и ремонт",Comment=""};
        public static readonly ВидыСобытийОС ПодготовкаКПередаче = new ВидыСобытийОС{Name= "ПодготовкаКПередаче",Synonim="Подготовка к передаче",Comment=""};
        public static readonly ВидыСобытийОС Передача = new ВидыСобытийОС{Name= "Передача",Synonim="Передача",Comment=""};
        public static readonly ВидыСобытийОС Списание = new ВидыСобытийОС{Name= "Списание",Synonim="Списание",Comment=""};
        public static readonly ВидыСобытийОС Прочее = new ВидыСобытийОС{Name= "Прочее",Synonim="Прочее",Comment="Прочие состояния (пользовательские)"};
        public static readonly ВидыСобытийОС Ремонт = new ВидыСобытийОС{Name= "Ремонт",Synonim="Ремонт",Comment=""};
    }
}
