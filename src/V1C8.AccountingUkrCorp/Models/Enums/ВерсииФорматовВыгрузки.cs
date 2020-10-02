using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВерсииФорматовВыгрузки", Comment = "", Synonym = "Версии форматов выгрузки")]
    public class ВерсииФорматовВыгрузки:EnumItem
    {
        public static readonly ВерсииФорматовВыгрузки ГНСУ_XML = new ВерсииФорматовВыгрузки{Name= "ГНСУ_XML",Synonim="ГНСУ, формат XML",Comment=""};
    }
}
