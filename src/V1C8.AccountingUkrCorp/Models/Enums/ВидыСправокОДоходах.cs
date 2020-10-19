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
    [Table("VydySpravokODokhodakh")]
    [Description1C8(Name = "ВидыСправокОДоходах", Comment = "", Synonym = "Виды справок о доходах")]
    public class ВидыСправокОДоходах:EnumItem
    {
        public static readonly ВидыСправокОДоходах Произвольная = new ВидыСправокОДоходах{Name= "Произвольная",Synonym="Справка в свободной форме",Comment=""};
        public static readonly ВидыСправокОДоходах Соцстрах2015 = new ВидыСправокОДоходах{Name= "Соцстрах2015",Synonym="Для выплат по соц. страхованию",Comment=""};
        public static readonly ВидыСправокОДоходах Субсидия2015 = new ВидыСправокОДоходах{Name= "Субсидия2015",Synonym="Для оформления субсидии",Comment=""};
        public static readonly ВидыСправокОДоходах Пенсия2015 = new ВидыСправокОДоходах{Name= "Пенсия2015",Synonym="Для расчета пенсии",Comment=""};
        public static readonly ВидыСправокОДоходах ДоходыИНалоги = new ВидыСправокОДоходах{Name= "ДоходыИНалоги",Synonym="Доходы и налоги",Comment=""};
        public static readonly ВидыСправокОДоходах Соцстрах = new ВидыСправокОДоходах{Name= "Соцстрах",Synonym="(устарело) Для назначения помощи по нетрудоспособности",Comment=""};
        public static readonly ВидыСправокОДоходах Безработица = new ВидыСправокОДоходах{Name= "Безработица",Synonym="(устарело) Для расчета выплат по безработице",Comment=""};
        public static readonly ВидыСправокОДоходах Пенсия = new ВидыСправокОДоходах{Name= "Пенсия",Synonym="(устарело) Для расчета пенсии",Comment=""};
        public static readonly ВидыСправокОДоходах Субсидия = new ВидыСправокОДоходах{Name= "Субсидия",Synonym="(устарело) Для оформления субсидии",Comment=""};
    }
}
