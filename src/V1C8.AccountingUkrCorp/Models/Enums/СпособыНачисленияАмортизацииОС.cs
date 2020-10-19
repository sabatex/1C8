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
    [Table("SposobyNachyslenyiaAmortyzatsyyOS")]
    [Description1C8(Name = "СпособыНачисленияАмортизацииОС", Comment = "(Общ)", Synonym = "Способы начисления амортизации основных средств")]
    public class СпособыНачисленияАмортизацииОС:EnumItem
    {
        public static readonly СпособыНачисленияАмортизацииОС Прямолинейный = new СпособыНачисленияАмортизацииОС{Name= "Прямолинейный",Synonym="Прямолинейный",Comment=""};
        public static readonly СпособыНачисленияАмортизацииОС Налоговый = new СпособыНачисленияАмортизацииОС{Name= "Налоговый",Synonym="Налоговый (с 01.04.2011 не актуален)",Comment=""};
        public static readonly СпособыНачисленияАмортизацииОС УменьшенияОстатка = new СпособыНачисленияАмортизацииОС{Name= "УменьшенияОстатка",Synonym="Уменьшения остатка",Comment=""};
        public static readonly СпособыНачисленияАмортизацииОС Кумулятивный = new СпособыНачисленияАмортизацииОС{Name= "Кумулятивный",Synonym="Кумулятивный (по сумме чисел лет)",Comment=""};
        public static readonly СпособыНачисленияАмортизацииОС Производственный = new СпособыНачисленияАмортизацииОС{Name= "Производственный",Synonym="Производственный",Comment="Пропорционально объему продукции"};
        public static readonly СпособыНачисленияАмортизацииОС УскоренногоУменьшенияОстатка = new СпособыНачисленияАмортизацииОС{Name= "УскоренногоУменьшенияОстатка",Synonym="Ускоренного уменьшения остатка",Comment=""};
        public static readonly СпособыНачисленияАмортизацииОС _100 = new СпособыНачисленияАмортизацииОС{Name= "_100",Synonym="100%",Comment="100% в первый месяц эксплуатации"};
        public static readonly СпособыНачисленияАмортизацииОС _50_50 = new СпособыНачисленияАмортизацииОС{Name= "_50_50",Synonym="50% - 50%",Comment="50% в первый месяц эксплуатации, 50% при списании"};
    }
}
