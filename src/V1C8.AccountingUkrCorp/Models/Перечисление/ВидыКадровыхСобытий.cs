using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыКадровыхСобытий", Comment = "", Synonym = "Виды кадровых событий")]
    public enum ВидыКадровыхСобытий
    {
        [Description1C8(Name = "Прием", Comment = "", Synonym = "Прием")]
        Прием,
        [Description1C8(Name = "Перемещение", Comment = "", Synonym = "Перемещение")]
        Перемещение,
        [Description1C8(Name = "Увольнение", Comment = "", Synonym = "Увольнение")]
        Увольнение,
        [Description1C8(Name = "НачальныеДанные", Comment = "", Synonym = "Начальные данные")]
        НачальныеДанные
    }
}
