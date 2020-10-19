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
    [Table("PrychynyYzmenenyiaSostoianyia")]
    [Description1C8(Name = "ПричиныИзмененияСостояния", Comment = "(Общ)", Synonym = "Причины изменения состояния")]
    public class ПричиныИзмененияСостояния:EnumItem
    {
        public static readonly ПричиныИзмененияСостояния ПриемНаРаботу = new ПричиныИзмененияСостояния{Name= "ПриемНаРаботу",Synonym="Прием на работу",Comment="(Общ)"};
        public static readonly ПричиныИзмененияСостояния Перемещение = new ПричиныИзмененияСостояния{Name= "Перемещение",Synonym="Перемещение",Comment="(Общ)"};
        public static readonly ПричиныИзмененияСостояния Увольнение = new ПричиныИзмененияСостояния{Name= "Увольнение",Synonym="Увольнение",Comment="(Общ)"};
    }
}
