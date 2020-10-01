using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "УстарелоВидыЗанятости", Comment = "(Регл)", Synonym = "Устарело виды занятости")]
    public enum УстарелоВидыЗанятости
    {
        [Description1C8(Name = "ОсновноеМестоРаботы", Comment = "", Synonym = "Основное место работы")]
        ОсновноеМестоРаботы,
        [Description1C8(Name = "Совместительство", Comment = "", Synonym = "Совместительство")]
        Совместительство,
        [Description1C8(Name = "ВнутреннееСовместительство", Comment = "", Synonym = "Внутреннее совместительство")]
        ВнутреннееСовместительство
    }
}
