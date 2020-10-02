using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СостоянияОС", Comment = "(Общ)", Synonym = "Состояния ОС")]
    public class СостоянияОС:EnumItem
    {
        public static readonly СостоянияОС ВведеноВЭксплуатацию = new СостоянияОС{Name= "ВведеноВЭксплуатацию",Synonim="Введено в эксплуатацию",Comment="(Общ)"};
        public static readonly СостоянияОС СнятоСУчета = new СостоянияОС{Name= "СнятоСУчета",Synonim="Снято с учета",Comment="(Общ)"};
    }
}
