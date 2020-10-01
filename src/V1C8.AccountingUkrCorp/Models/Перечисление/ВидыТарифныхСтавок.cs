using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыТарифныхСтавок", Comment = "", Synonym = "Виды тарифных ставок")]
    public enum ВидыТарифныхСтавок
    {
        [Description1C8(Name = "МесячнаяТарифнаяСтавка", Comment = "", Synonym = "Месячная тарифная ставка")]
        МесячнаяТарифнаяСтавка,
        [Description1C8(Name = "ЧасоваяТарифнаяСтавка", Comment = "", Synonym = "Часовая тарифная ставка")]
        ЧасоваяТарифнаяСтавка,
        [Description1C8(Name = "ДневнаяТарифнаяСтавка", Comment = "", Synonym = "Дневная тарифная ставка")]
        ДневнаяТарифнаяСтавка
    }
}
