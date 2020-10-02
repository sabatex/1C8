using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ПорядокРасчетаСреднегоЗаработкаФСС", Comment = "", Synonym = "Порядок расчета среднего заработка ФСС")]
    public class ПорядокРасчетаСреднегоЗаработкаФСС:EnumItem
    {
        public static readonly ПорядокРасчетаСреднегоЗаработкаФСС Постановление2010 = new ПорядокРасчетаСреднегоЗаработкаФСС{Name= "Постановление2010",Synonym="По правилам для событий, произошедших после 4 июля 2015 года",Comment=""};
        public static readonly ПорядокРасчетаСреднегоЗаработкаФСС Постановление2011 = new ПорядокРасчетаСреднегоЗаработкаФСС{Name= "Постановление2011",Synonym="По правилам для событий, произошедших до 4 июля 2015 года",Comment=""};
    }
}
