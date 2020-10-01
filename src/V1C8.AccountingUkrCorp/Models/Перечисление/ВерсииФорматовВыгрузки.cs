using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВерсииФорматовВыгрузки", Comment = "", Synonym = "Версии форматов выгрузки")]
    public enum ВерсииФорматовВыгрузки
    {
        [Description1C8(Name = "ГНСУ_XML", Comment = "", Synonym = "ГНСУ, формат XML")]
        ГНСУ_XML
    }
}
