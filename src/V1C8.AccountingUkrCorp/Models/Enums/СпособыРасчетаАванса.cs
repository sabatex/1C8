using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыРасчетаАванса", Comment = "", Synonym = "Способы расчета аванса")]
    public class СпособыРасчетаАванса:EnumItem
    {
        public static readonly СпособыРасчетаАванса ФиксированнойСуммой = new СпособыРасчетаАванса{Name= "ФиксированнойСуммой",Synonym="Фиксированной суммой",Comment=""};
        public static readonly СпособыРасчетаАванса ПроцентомОтТарифа = new СпособыРасчетаАванса{Name= "ПроцентомОтТарифа",Synonym="Процентом от тарифа",Comment=""};
        public static readonly СпособыРасчетаАванса РасчетомЗаПервуюПоловинуМесяца = new СпособыРасчетаАванса{Name= "РасчетомЗаПервуюПоловинуМесяца",Synonym="Расчетом за первую половину месяца",Comment=""};
    }
}
