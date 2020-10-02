using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыОценкиСтоимостиВстречногоВыпуска", Comment = "(Общ)", Synonym = "Способы оценки стоимости встречного выпуска")]
    public class СпособыОценкиСтоимостиВстречногоВыпуска:EnumItem
    {
        public static readonly СпособыОценкиСтоимостиВстречногоВыпуска ПоРасчетнойСтоимости = new СпособыОценкиСтоимостиВстречногоВыпуска{Name= "ПоРасчетнойСтоимости",Synonim="По расчетной стоимости",Comment="(Общ)"};
        public static readonly СпособыОценкиСтоимостиВстречногоВыпуска НеРассчитывается = new СпособыОценкиСтоимостиВстречногоВыпуска{Name= "НеРассчитывается",Synonim="Не рассчитывается",Comment="(Общ)"};
    }
}
