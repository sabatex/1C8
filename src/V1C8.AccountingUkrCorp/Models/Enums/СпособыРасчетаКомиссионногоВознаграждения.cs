using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыРасчетаКомиссионногоВознаграждения", Comment = "(Общ)", Synonym = "Способы расчета комиссионного вознаграждения")]
    public class СпособыРасчетаКомиссионногоВознаграждения:EnumItem
    {
        public static readonly СпособыРасчетаКомиссионногоВознаграждения НеРассчитывается = new СпособыРасчетаКомиссионногоВознаграждения{Name= "НеРассчитывается",Synonim="Не рассчитывается",Comment="(Общ) Не рассчитывается (указывается вручную)"};
        public static readonly СпособыРасчетаКомиссионногоВознаграждения ПроцентОтРазностиСуммПродажиИПоступления = new СпособыРасчетаКомиссионногоВознаграждения{Name= "ПроцентОтРазностиСуммПродажиИПоступления",Synonim="Процент от разности сумм продажи и поступления",Comment="(Общ)"};
        public static readonly СпособыРасчетаКомиссионногоВознаграждения ПроцентОтСуммыПродажи = new СпособыРасчетаКомиссионногоВознаграждения{Name= "ПроцентОтСуммыПродажи",Synonim="Процент от суммы продажи",Comment="(Общ)"};
    }
}
