using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыНачисленияАмортизацииНМА", Comment = "(Общ)", Synonym = "Способы начисления амортизации нематериальных активов")]
    public class СпособыНачисленияАмортизацииНМА:EnumItem
    {
        public static readonly СпособыНачисленияАмортизацииНМА Прямолинейный = new СпособыНачисленияАмортизацииНМА{Name= "Прямолинейный",Synonim="Прямолинейный",Comment="(Общ)"};
        public static readonly СпособыНачисленияАмортизацииНМА УменьшенияОстатка = new СпособыНачисленияАмортизацииНМА{Name= "УменьшенияОстатка",Synonim="Уменьшения остатка",Comment="(Общ)"};
        public static readonly СпособыНачисленияАмортизацииНМА Производственный = new СпособыНачисленияАмортизацииНМА{Name= "Производственный",Synonim="Производственный",Comment="Пропорционально объему продукции"};
        public static readonly СпособыНачисленияАмортизацииНМА Кумулятивный = new СпособыНачисленияАмортизацииНМА{Name= "Кумулятивный",Synonim="Кумулятивный (по сумме чисел лет)",Comment=""};
        public static readonly СпособыНачисленияАмортизацииНМА УскоренногоУменьшенияОстатка = new СпособыНачисленияАмортизацииНМА{Name= "УскоренногоУменьшенияОстатка",Synonim="Ускоренного уменьшения остатка",Comment=""};
    }
}
