using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыОценкиСтоимостиВстречногоВыпуска", Comment = "(Общ)", Synonym = "Способы оценки стоимости встречного выпуска")]
    public enum СпособыОценкиСтоимостиВстречногоВыпуска
    {
        [Description1C8(Name = "ПоРасчетнойСтоимости", Comment = "(Общ)", Synonym = "По расчетной стоимости")]
        ПоРасчетнойСтоимости,
        [Description1C8(Name = "НеРассчитывается", Comment = "(Общ)", Synonym = "Не рассчитывается")]
        НеРассчитывается
    }
}
