using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыРасчетаВзносов", Comment = "(Общ)", Synonym = "Способы расчета взносов")]
    public class СпособыРасчетаВзносов:EnumItem
    {
        public static readonly СпособыРасчетаВзносов Взносы = new СпособыРасчетаВзносов{Name= "Взносы",Synonym="Взносы",Comment="(Общ)"};
        public static readonly СпособыРасчетаВзносов ВзносыФОТ = new СпособыРасчетаВзносов{Name= "ВзносыФОТ",Synonym="Взносы ФОТ",Comment="(Общ)"};
    }
}
