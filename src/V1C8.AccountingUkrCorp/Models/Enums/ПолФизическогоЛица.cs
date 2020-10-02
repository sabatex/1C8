using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ПолФизическогоЛица", Comment = "", Synonym = "Пол физического лица")]
    public class ПолФизическогоЛица:EnumItem
    {
        public static readonly ПолФизическогоЛица Мужской = new ПолФизическогоЛица{Name= "Мужской",Synonym="Мужской",Comment=""};
        public static readonly ПолФизическогоЛица Женский = new ПолФизическогоЛица{Name= "Женский",Synonym="Женский",Comment=""};
    }
}
