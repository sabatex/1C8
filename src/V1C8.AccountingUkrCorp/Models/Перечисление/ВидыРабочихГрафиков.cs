using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыРабочихГрафиков", Comment = "(Общ)", Synonym = "Виды рабочих графиков")]
    public enum ВидыРабочихГрафиков
    {
        [Description1C8(Name = "Пятидневка", Comment = "(Общ)", Synonym = "Пятидневка")]
        Пятидневка,
        [Description1C8(Name = "Шестидневка", Comment = "(Общ)", Synonym = "Шестидневка")]
        Шестидневка,
        [Description1C8(Name = "Сменный", Comment = "(Общ)", Synonym = "Сменный")]
        Сменный
    }
}
