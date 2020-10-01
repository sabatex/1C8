using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ТипДетализацииСтандартныхОтчетов", Comment = "", Synonym = "Тип детализации стандартных отчетов")]
    public enum ТипДетализацииСтандартныхОтчетов
    {
        [Description1C8(Name = "Элементы", Comment = "", Synonym = "Без групп")]
        Элементы,
        [Description1C8(Name = "Иерархия", Comment = "", Synonym = "С группами")]
        Иерархия,
        [Description1C8(Name = "ТолькоИерархия", Comment = "", Synonym = "Только группы")]
        ТолькоИерархия
    }
}
