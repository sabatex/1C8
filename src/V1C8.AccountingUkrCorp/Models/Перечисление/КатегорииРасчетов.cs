using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "КатегорииРасчетов", Comment = "(Общ)", Synonym = "Категории расчетов")]
    public enum КатегорииРасчетов
    {
        [Description1C8(Name = "Первичное", Comment = "(Общ)", Synonym = "Первичное")]
        Первичное,
        [Description1C8(Name = "ЗависимоеПервогоУровня", Comment = "(Общ)", Synonym = "Зависимое первого уровня")]
        ЗависимоеПервогоУровня,
        [Description1C8(Name = "ЗависимоеВторогоУровня", Comment = "(Общ)", Synonym = "Зависимое второго уровня")]
        ЗависимоеВторогоУровня,
        [Description1C8(Name = "ЗависимоеТретьегоУровня", Comment = "(Общ)", Synonym = "Зависимое третьего уровня")]
        ЗависимоеТретьегоУровня
    }
}
