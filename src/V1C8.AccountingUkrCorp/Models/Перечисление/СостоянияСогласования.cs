using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СостоянияСогласования", Comment = "", Synonym = "Состояния согласования")]
    public enum СостоянияСогласования
    {
        [Description1C8(Name = "Отклонено", Comment = "", Synonym = "Отклонено")]
        Отклонено,
        [Description1C8(Name = "Рассматривается", Comment = "", Synonym = "Рассматривается")]
        Рассматривается,
        [Description1C8(Name = "Согласовано", Comment = "", Synonym = "Согласовано")]
        Согласовано
    }
}
