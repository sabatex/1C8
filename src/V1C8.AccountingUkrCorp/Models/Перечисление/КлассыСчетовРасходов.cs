using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "КлассыСчетовРасходов", Comment = "(Регл)", Synonym = "Классы счетов расходов")]
    public enum КлассыСчетовРасходов
    {
        [Description1C8(Name = "Класс8", Comment = "", Synonym = "Класс 8 (элементы затрат)")]
        Класс8,
        [Description1C8(Name = "Класс9", Comment = "", Synonym = "Класс 9 (затраты деятельности)")]
        Класс9,
        [Description1C8(Name = "Класс8и9", Comment = "", Synonym = "Классы 8 и 9 (элементы и затраты деятельности)")]
        Класс8и9
    }
}
