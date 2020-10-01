using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыРасчетаСреднегоЗаработкаДляОплатыПособия", Comment = "", Synonym = "Способы расчета среднего заработка для оплаты пособия")]
    public enum СпособыРасчетаСреднегоЗаработкаДляОплатыПособия
    {
        [Description1C8(Name = "СреднийЗаработок", Comment = "", Synonym = "Средний заработок")]
        СреднийЗаработок,
        [Description1C8(Name = "ИсходяИзТарифнойСтавки", Comment = "", Synonym = "Исходя из тарифной ставки")]
        ИсходяИзТарифнойСтавки,
        [Description1C8(Name = "ИсходяИзМРОТ", Comment = "", Synonym = "Исходя из МРОТ")]
        ИсходяИзМРОТ
    }
}
