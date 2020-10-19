using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Table("VydyDeistvyiKalendariaBukhhaltera")]
    [Description1C8(Name = "ВидыДействийКалендаряБухгалтера", Comment = "", Synonym = "Виды действий календаря бухгалтера")]
    public class ВидыДействийКалендаряБухгалтера:EnumItem
    {
        public static readonly ВидыДействийКалендаряБухгалтера Отчет = new ВидыДействийКалендаряБухгалтера{Name= "Отчет",Synonym="Отчет",Comment=""};
        public static readonly ВидыДействийКалендаряБухгалтера УплатаНалога = new ВидыДействийКалендаряБухгалтера{Name= "УплатаНалога",Synonym="Уплата налога",Comment=""};
    }
}
