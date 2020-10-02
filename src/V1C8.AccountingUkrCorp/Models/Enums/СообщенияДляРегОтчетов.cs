using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СообщенияДляРегОтчетов", Comment = "", Synonym = "Сообщения для рег отчетов")]
    public class СообщенияДляРегОтчетов:EnumItem
    {
        public static readonly СообщенияДляРегОтчетов СдачаОтчета = new СообщенияДляРегОтчетов{Name= "СдачаОтчета",Synonim="Сдача отчета",Comment=""};
        public static readonly СообщенияДляРегОтчетов УплатаНалога = new СообщенияДляРегОтчетов{Name= "УплатаНалога",Synonim="Уплата налога",Comment=""};
    }
}
