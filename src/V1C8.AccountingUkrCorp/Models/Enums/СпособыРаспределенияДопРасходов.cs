using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыРаспределенияДопРасходов", Comment = "(Общ) Способы распределения суммы по строкам номенклатуры", Synonym = "Способы распределения доп расходов")]
    public class СпособыРаспределенияДопРасходов:EnumItem
    {
        public static readonly СпособыРаспределенияДопРасходов ПоСумме = new СпособыРаспределенияДопРасходов{Name= "ПоСумме",Synonim="По сумме",Comment="(Общ)"};
        public static readonly СпособыРаспределенияДопРасходов ПоКоличеству = new СпособыРаспределенияДопРасходов{Name= "ПоКоличеству",Synonim="По количеству",Comment="(Общ)"};
    }
}
