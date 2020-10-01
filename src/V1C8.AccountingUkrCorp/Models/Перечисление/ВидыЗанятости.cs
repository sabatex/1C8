using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыЗанятости", Comment = "", Synonym = "Виды занятости")]
    public enum ВидыЗанятости
    {
        [Description1C8(Name = "ОсновноеМестоРаботы", Comment = "", Synonym = "Основное место работы")]
        ОсновноеМестоРаботы,
        [Description1C8(Name = "Совместительство", Comment = "", Synonym = "Внешнее совместительство")]
        Совместительство,
        [Description1C8(Name = "ВнутреннееСовместительство", Comment = "", Synonym = "Внутреннее совместительство")]
        ВнутреннееСовместительство,
        [Description1C8(Name = "Подработка", Comment = "", Synonym = "Подработка")]
        Подработка
    }
}
