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
    [Table("VydyZadolzhennosty")]
    [Description1C8(Name = "ВидыЗадолженности", Comment = "Виды задолженности: дебиторская, кредиторская", Synonym = "Виды задолженности")]
    public class ВидыЗадолженности:EnumItem
    {
        public static readonly ВидыЗадолженности Дебиторская = new ВидыЗадолженности{Name= "Дебиторская",Synonym="Дебиторская",Comment="Дебиторская"};
        public static readonly ВидыЗадолженности Кредиторская = new ВидыЗадолженности{Name= "Кредиторская",Synonym="Кредиторская",Comment="Кредиторская"};
    }
}
