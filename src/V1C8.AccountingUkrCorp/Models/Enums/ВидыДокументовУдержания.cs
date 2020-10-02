using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыДокументовУдержания", Comment = "", Synonym = "Виды документов удержания")]
    public class ВидыДокументовУдержания:EnumItem
    {
        public static readonly ВидыДокументовУдержания Увольнение = new ВидыДокументовУдержания{Name= "Увольнение",Synonim="Увольнение",Comment=""};
    }
}
