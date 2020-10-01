using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ДействияСУдержаниями", Comment = "", Synonym = "Действия с удержаниями")]
    public enum ДействияСУдержаниями
    {
        [Description1C8(Name = "Начать", Comment = "", Synonym = "Начать")]
        Начать,
        [Description1C8(Name = "Изменить", Comment = "", Synonym = "Изменить")]
        Изменить,
        [Description1C8(Name = "Прекратить", Comment = "", Synonym = "Прекратить")]
        Прекратить
    }
}
