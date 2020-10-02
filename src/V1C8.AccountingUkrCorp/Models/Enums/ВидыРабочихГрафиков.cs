using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыРабочихГрафиков", Comment = "(Общ)", Synonym = "Виды рабочих графиков")]
    public class ВидыРабочихГрафиков:EnumItem
    {
        public static readonly ВидыРабочихГрафиков Пятидневка = new ВидыРабочихГрафиков{Name= "Пятидневка",Synonym="Пятидневка",Comment="(Общ)"};
        public static readonly ВидыРабочихГрафиков Шестидневка = new ВидыРабочихГрафиков{Name= "Шестидневка",Synonym="Шестидневка",Comment="(Общ)"};
        public static readonly ВидыРабочихГрафиков Сменный = new ВидыРабочихГрафиков{Name= "Сменный",Synonym="Сменный",Comment="(Общ)"};
    }
}
