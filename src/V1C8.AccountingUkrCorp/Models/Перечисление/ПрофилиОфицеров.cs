using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ПрофилиОфицеров", Comment = "(Регл)", Synonym = "Профили офицеров")]
    public enum ПрофилиОфицеров
    {
        [Description1C8(Name = "Командный", Comment = "", Synonym = "Командный")]
        Командный,
        [Description1C8(Name = "Инженерный", Comment = "", Synonym = "Инженерный")]
        Инженерный,
        [Description1C8(Name = "Технический", Comment = "", Synonym = "Технический")]
        Технический,
        [Description1C8(Name = "Юридический", Comment = "", Synonym = "Юридический")]
        Юридический,
        [Description1C8(Name = "Медицинский", Comment = "", Synonym = "Медицинский")]
        Медицинский,
        [Description1C8(Name = "Ветеринарный", Comment = "", Synonym = "Ветеринарный")]
        Ветеринарный,
        [Description1C8(Name = "Оперативный", Comment = "", Synonym = "Оперативный")]
        Оперативный,
        [Description1C8(Name = "Административный", Comment = "", Synonym = "Административный")]
        Административный,
        [Description1C8(Name = "ОперативноТехнический", Comment = "", Synonym = "Оперативно-технический")]
        ОперативноТехнический
    }
}
