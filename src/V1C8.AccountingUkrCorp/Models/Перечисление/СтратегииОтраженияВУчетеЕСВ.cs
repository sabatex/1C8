using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СтратегииОтраженияВУчетеЕСВ", Comment = "", Synonym = "Стратегии отражения в учете ЕСВ")]
    public enum СтратегииОтраженияВУчетеЕСВ
    {
        [Description1C8(Name = "КакНачисление", Comment = "", Synonym = "Как начисление")]
        КакНачисление,
        [Description1C8(Name = "КакОсновноеНачислениеСотрудника", Comment = "", Synonym = "Как основное начисление сотрудника")]
        КакОсновноеНачислениеСотрудника,
        [Description1C8(Name = "ОсобымСпособом", Comment = "", Synonym = "Особым способом")]
        ОсобымСпособом
    }
}
