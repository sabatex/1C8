using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыНачисленияАмортизацииНМА", Comment = "(Общ)", Synonym = "Способы начисления амортизации нематериальных активов")]
    public class СпособыНачисленияАмортизацииНМА:EnumItem
    {
        public static readonly СпособыНачисленияАмортизацииНМА Прямолинейный = new СпособыНачисленияАмортизацииНМА{Name= "Прямолинейный",Synonym="Прямолинейный",Comment="(Общ)"};
        public static readonly СпособыНачисленияАмортизацииНМА УменьшенияОстатка = new СпособыНачисленияАмортизацииНМА{Name= "УменьшенияОстатка",Synonym="Уменьшения остатка",Comment="(Общ)"};
        public static readonly СпособыНачисленияАмортизацииНМА Производственный = new СпособыНачисленияАмортизацииНМА{Name= "Производственный",Synonym="Производственный",Comment="Пропорционально объему продукции"};
        public static readonly СпособыНачисленияАмортизацииНМА Кумулятивный = new СпособыНачисленияАмортизацииНМА{Name= "Кумулятивный",Synonym="Кумулятивный (по сумме чисел лет)",Comment=""};
        public static readonly СпособыНачисленияАмортизацииНМА УскоренногоУменьшенияОстатка = new СпособыНачисленияАмортизацииНМА{Name= "УскоренногоУменьшенияОстатка",Synonym="Ускоренного уменьшения остатка",Comment=""};
    }
}
