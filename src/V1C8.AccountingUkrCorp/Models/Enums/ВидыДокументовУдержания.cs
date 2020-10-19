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
    [Table("VydyDokumentovUderzhanyia")]
    [Description1C8(Name = "ВидыДокументовУдержания", Comment = "", Synonym = "Виды документов удержания")]
    public class ВидыДокументовУдержания:EnumItem
    {
        public static readonly ВидыДокументовУдержания Увольнение = new ВидыДокументовУдержания{Name= "Увольнение",Synonym="Увольнение",Comment=""};
    }
}
