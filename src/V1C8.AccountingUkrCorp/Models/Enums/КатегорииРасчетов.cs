using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "КатегорииРасчетов", Comment = "(Общ)", Synonym = "Категории расчетов")]
    public class КатегорииРасчетов:EnumItem
    {
        public static readonly КатегорииРасчетов Первичное = new КатегорииРасчетов{Name= "Первичное",Synonim="Первичное",Comment="(Общ)"};
        public static readonly КатегорииРасчетов ЗависимоеПервогоУровня = new КатегорииРасчетов{Name= "ЗависимоеПервогоУровня",Synonim="Зависимое первого уровня",Comment="(Общ)"};
        public static readonly КатегорииРасчетов ЗависимоеВторогоУровня = new КатегорииРасчетов{Name= "ЗависимоеВторогоУровня",Synonim="Зависимое второго уровня",Comment="(Общ)"};
        public static readonly КатегорииРасчетов ЗависимоеТретьегоУровня = new КатегорииРасчетов{Name= "ЗависимоеТретьегоУровня",Synonim="Зависимое третьего уровня",Comment="(Общ)"};
    }
}
