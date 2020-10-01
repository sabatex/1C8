using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ЮридическоеФизическоеЛицо", Comment = "Определяет, является ли организация или контрагент юридическим лицом или нет.", Synonym = "Юридическое / физическое лицо")]
    public enum ЮридическоеФизическоеЛицо
    {
        [Description1C8(Name = "ЮридическоеЛицо", Comment = "", Synonym = "Юридическое лицо")]
        ЮридическоеЛицо,
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        ФизическоеЛицо
    }
}
