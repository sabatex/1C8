using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыУлучшения", Comment = "", Synonym = "Виды улучшения")]
    public class ВидыУлучшения:EnumItem
    {
        public static readonly ВидыУлучшения Модернизация = new ВидыУлучшения{Name= "Модернизация",Synonim="Модернизация",Comment=""};
        public static readonly ВидыУлучшения Ремонт = new ВидыУлучшения{Name= "Ремонт",Synonim="Ремонт",Comment=""};
    }
}
