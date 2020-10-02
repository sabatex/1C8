using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ХарактерВыплатыЗарплаты", Comment = "Выплата конкретного начисления, аванса или окончательная выплата зарплаты 'под расчет'", Synonym = "Характер выплаты зарплаты")]
    public class ХарактерВыплатыЗарплаты:EnumItem
    {
        public static readonly ХарактерВыплатыЗарплаты Аванс = new ХарактерВыплатыЗарплаты{Name= "Аванс",Synonym="С авансом",Comment=""};
        public static readonly ХарактерВыплатыЗарплаты Межрасчет = new ХарактерВыплатыЗарплаты{Name= "Межрасчет",Synonym="В межрасчетный период",Comment=""};
        public static readonly ХарактерВыплатыЗарплаты Зарплата = new ХарактерВыплатыЗарплаты{Name= "Зарплата",Synonym="С зарплатой",Comment=""};
    }
}
