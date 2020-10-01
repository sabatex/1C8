using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ПорядокРасчетаСреднегоЗаработкаФСС", Comment = "", Synonym = "Порядок расчета среднего заработка ФСС")]
    public enum ПорядокРасчетаСреднегоЗаработкаФСС
    {
        [Description1C8(Name = "Постановление2010", Comment = "", Synonym = "По правилам для событий, произошедших после 4 июля 2015 года")]
        Постановление2010,
        [Description1C8(Name = "Постановление2011", Comment = "", Synonym = "По правилам для событий, произошедших до 4 июля 2015 года")]
        Постановление2011
    }
}
