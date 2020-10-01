using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыРасчетаКомиссионногоВознаграждения", Comment = "(Общ)", Synonym = "Способы расчета комиссионного вознаграждения")]
    public enum СпособыРасчетаКомиссионногоВознаграждения
    {
        [Description1C8(Name = "НеРассчитывается", Comment = "(Общ) Не рассчитывается (указывается вручную)", Synonym = "Не рассчитывается")]
        НеРассчитывается,
        [Description1C8(Name = "ПроцентОтРазностиСуммПродажиИПоступления", Comment = "(Общ)", Synonym = "Процент от разности сумм продажи и поступления")]
        ПроцентОтРазностиСуммПродажиИПоступления,
        [Description1C8(Name = "ПроцентОтСуммыПродажи", Comment = "(Общ)", Synonym = "Процент от суммы продажи")]
        ПроцентОтСуммыПродажи
    }
}
