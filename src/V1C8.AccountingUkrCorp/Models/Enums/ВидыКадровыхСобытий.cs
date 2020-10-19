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
    [Table("VydyKadrovykhSobytyi")]
    [Description1C8(Name = "ВидыКадровыхСобытий", Comment = "", Synonym = "Виды кадровых событий")]
    public class ВидыКадровыхСобытий:EnumItem
    {
        public static readonly ВидыКадровыхСобытий Прием = new ВидыКадровыхСобытий{Name= "Прием",Synonym="Прием",Comment=""};
        public static readonly ВидыКадровыхСобытий Перемещение = new ВидыКадровыхСобытий{Name= "Перемещение",Synonym="Перемещение",Comment=""};
        public static readonly ВидыКадровыхСобытий Увольнение = new ВидыКадровыхСобытий{Name= "Увольнение",Synonym="Увольнение",Comment=""};
        public static readonly ВидыКадровыхСобытий НачальныеДанные = new ВидыКадровыхСобытий{Name= "НачальныеДанные",Synonym="Начальные данные",Comment=""};
    }
}
