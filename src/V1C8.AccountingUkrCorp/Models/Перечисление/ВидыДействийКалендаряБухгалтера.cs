using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыДействийКалендаряБухгалтера", Comment = "", Synonym = "Виды действий календаря бухгалтера")]
    public enum ВидыДействийКалендаряБухгалтера
    {
        [Description1C8(Name = "Отчет", Comment = "", Synonym = "Отчет")]
        Отчет,
        [Description1C8(Name = "УплатаНалога", Comment = "", Synonym = "Уплата налога")]
        УплатаНалога
    }
}
