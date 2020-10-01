using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыПрофессиональнойПодготовки", Comment = "", Synonym = "Виды профессиональной подготовки")]
    public enum ВидыПрофессиональнойПодготовки
    {
        [Description1C8(Name = "Переподготовка", Comment = "", Synonym = "Переподготовка")]
        Переподготовка,
        [Description1C8(Name = "ПовышениеКвалификации", Comment = "", Synonym = "Повышение квалификации")]
        ПовышениеКвалификации
    }
}
