using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ПричиныИзмененияСостояния", Comment = "(Общ)", Synonym = "Причины изменения состояния")]
    public class ПричиныИзмененияСостояния:EnumItem
    {
        public static readonly ПричиныИзмененияСостояния ПриемНаРаботу = new ПричиныИзмененияСостояния{Name= "ПриемНаРаботу",Synonim="Прием на работу",Comment="(Общ)"};
        public static readonly ПричиныИзмененияСостояния Перемещение = new ПричиныИзмененияСостояния{Name= "Перемещение",Synonim="Перемещение",Comment="(Общ)"};
        public static readonly ПричиныИзмененияСостояния Увольнение = new ПричиныИзмененияСостояния{Name= "Увольнение",Synonim="Увольнение",Comment="(Общ)"};
    }
}
