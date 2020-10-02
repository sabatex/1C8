using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыДействийКалендаряБухгалтера", Comment = "", Synonym = "Виды действий календаря бухгалтера")]
    public class ВидыДействийКалендаряБухгалтера:EnumItem
    {
        public static readonly ВидыДействийКалендаряБухгалтера Отчет = new ВидыДействийКалендаряБухгалтера{Name= "Отчет",Synonim="Отчет",Comment=""};
        public static readonly ВидыДействийКалендаряБухгалтера УплатаНалога = new ВидыДействийКалендаряБухгалтера{Name= "УплатаНалога",Synonim="Уплата налога",Comment=""};
    }
}
