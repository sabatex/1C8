using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ПорядокРасчетаСреднегоЗаработкаОбщий", Comment = "", Synonym = "Порядок расчета среднего заработка общий")]
    public class ПорядокРасчетаСреднегоЗаработкаОбщий:EnumItem
    {
        public static readonly ПорядокРасчетаСреднегоЗаработкаОбщий Постановление2010 = new ПорядокРасчетаСреднегоЗаработкаОбщий{Name= "Постановление2010",Synonim="Постановление 100 (для прочих)",Comment=""};
        public static readonly ПорядокРасчетаСреднегоЗаработкаОбщий Постановление100Отпускные = new ПорядокРасчетаСреднегоЗаработкаОбщий{Name= "Постановление100Отпускные",Synonim="Постановление 100 (для отпускных)",Comment=""};
    }
}
