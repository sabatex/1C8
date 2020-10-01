using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СоциальныеГруппыНаселения", Comment = "", Synonym = "Социальные группы населения")]
    public enum СоциальныеГруппыНаселения
    {
        [Description1C8(Name = "ДетиДо6", Comment = "", Synonym = "Дети до 6 лет")]
        ДетиДо6,
        [Description1C8(Name = "ДетиДо18", Comment = "", Synonym = "Дети от 6 до18 лет")]
        ДетиДо18,
        [Description1C8(Name = "Трудоспособные", Comment = "", Synonym = "Трудоспособные")]
        Трудоспособные,
        [Description1C8(Name = "НеТрудоспособные", Comment = "", Synonym = "Нетрудоспособные")]
        НеТрудоспособные
    }
}
