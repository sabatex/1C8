using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СообщенияДляРегОтчетов", Comment = "", Synonym = "Сообщения для рег отчетов")]
    public enum СообщенияДляРегОтчетов
    {
        [Description1C8(Name = "СдачаОтчета", Comment = "", Synonym = "Сдача отчета")]
        СдачаОтчета,
        [Description1C8(Name = "УплатаНалога", Comment = "", Synonym = "Уплата налога")]
        УплатаНалога
    }
}
