using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыРасчетаСебестоимостиПродукции", Comment = "(Общ)", Synonym = "Способы расчета себестоимости продукции")]
    public class СпособыРасчетаСебестоимостиПродукции:EnumItem
    {
        public static readonly СпособыРасчетаСебестоимостиПродукции ПоПеределам = new СпособыРасчетаСебестоимостиПродукции{Name= "ПоПеределам",Synonym="По переделам",Comment="(Общ)"};
        public static readonly СпособыРасчетаСебестоимостиПродукции ПоПодразделениям = new СпособыРасчетаСебестоимостиПродукции{Name= "ПоПодразделениям",Synonym="По подразделениям",Comment="(Общ)"};
    }
}
