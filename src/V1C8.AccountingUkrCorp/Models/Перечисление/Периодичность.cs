using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "Периодичность", Comment = "(Упр)", Synonym = "Периодичность")]
    public enum Периодичность
    {
        [Description1C8(Name = "День", Comment = "", Synonym = "День")]
        День,
        [Description1C8(Name = "Неделя", Comment = "", Synonym = "Неделя")]
        Неделя,
        [Description1C8(Name = "Месяц", Comment = "", Synonym = "Месяц")]
        Месяц,
        [Description1C8(Name = "Квартал", Comment = "", Synonym = "Квартал")]
        Квартал,
        [Description1C8(Name = "Год", Comment = "", Synonym = "Год")]
        Год,
        [Description1C8(Name = "Декада", Comment = "", Synonym = "Декада")]
        Декада,
        [Description1C8(Name = "Полугодие", Comment = "", Synonym = "Полугодие")]
        Полугодие
    }
}
