using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыБазыУдержанияПоИсполнительномуДокументу", Comment = "", Synonym = "Виды базы удержания по исполнительному документу")]
    public enum ВидыБазыУдержанияПоИсполнительномуДокументу
    {
        [Description1C8(Name = "Заработок", Comment = "", Synonym = "Заработок")]
        Заработок,
        [Description1C8(Name = "ПрожиточныйМинимум", Comment = "", Synonym = "Прожиточный минимум")]
        ПрожиточныйМинимум
    }
}
