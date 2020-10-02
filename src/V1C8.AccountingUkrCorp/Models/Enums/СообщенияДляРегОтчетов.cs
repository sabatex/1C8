using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СообщенияДляРегОтчетов", Comment = "", Synonym = "Сообщения для рег отчетов")]
    public class СообщенияДляРегОтчетов:EnumItem
    {
        public static readonly СообщенияДляРегОтчетов СдачаОтчета = new СообщенияДляРегОтчетов{Name= "СдачаОтчета",Synonym="Сдача отчета",Comment=""};
        public static readonly СообщенияДляРегОтчетов УплатаНалога = new СообщенияДляРегОтчетов{Name= "УплатаНалога",Synonym="Уплата налога",Comment=""};
    }
}
