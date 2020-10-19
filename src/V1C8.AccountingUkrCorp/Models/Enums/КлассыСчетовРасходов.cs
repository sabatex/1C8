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
    [Table("KlassySchetovRaskhodov")]
    [Description1C8(Name = "КлассыСчетовРасходов", Comment = "(Регл)", Synonym = "Классы счетов расходов")]
    public class КлассыСчетовРасходов:EnumItem
    {
        public static readonly КлассыСчетовРасходов Класс8 = new КлассыСчетовРасходов{Name= "Класс8",Synonym="Класс 8 (элементы затрат)",Comment=""};
        public static readonly КлассыСчетовРасходов Класс9 = new КлассыСчетовРасходов{Name= "Класс9",Synonym="Класс 9 (затраты деятельности)",Comment=""};
        public static readonly КлассыСчетовРасходов Класс8и9 = new КлассыСчетовРасходов{Name= "Класс8и9",Synonym="Классы 8 и 9 (элементы и затраты деятельности)",Comment=""};
    }
}
