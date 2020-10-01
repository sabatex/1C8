using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОбъектовДоступа", Comment = "", Synonym = "Виды объектов доступа")]
    public enum ВидыОбъектовДоступа
    {
        [Description1C8(Name = "Организации", Comment = "", Synonym = "Организации")]
        Организации,
        [Description1C8(Name = "ВнешниеОбработки", Comment = "", Synonym = "Внешние обработки")]
        ВнешниеОбработки
    }
}
