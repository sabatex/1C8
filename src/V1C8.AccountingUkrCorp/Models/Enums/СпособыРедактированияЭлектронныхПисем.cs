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
    [Table("SposobyRedaktyrovanyiaЕlektronnykhPysem")]
    [Description1C8(Name = "СпособыРедактированияЭлектронныхПисем", Comment = "", Synonym = "Способы редактирования электронных писем")]
    public class СпособыРедактированияЭлектронныхПисем:EnumItem
    {
        public static readonly СпособыРедактированияЭлектронныхПисем ОбычныйТекст = new СпособыРедактированияЭлектронныхПисем{Name= "ОбычныйТекст",Synonym="Обычный текст",Comment=""};
        public static readonly СпособыРедактированияЭлектронныхПисем HTML = new СпособыРедактированияЭлектронныхПисем{Name= "HTML",Synonym="HTML",Comment=""};
    }
}
