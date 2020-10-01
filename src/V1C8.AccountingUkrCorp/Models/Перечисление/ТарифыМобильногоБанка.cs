using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ТарифыМобильногоБанка", Comment = "", Synonym = "Тарифы мобильного банка")]
    public enum ТарифыМобильногоБанка
    {
        [Description1C8(Name = "Экономный", Comment = "", Synonym = "Экономный")]
        Экономный,
        [Description1C8(Name = "Полный", Comment = "", Synonym = "Полный")]
        Полный
    }
}
