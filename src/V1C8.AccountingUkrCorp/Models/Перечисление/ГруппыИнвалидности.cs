using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ГруппыИнвалидности", Comment = "(Регл)", Synonym = "Группы инвалидности")]
    public enum ГруппыИнвалидности
    {
        [Description1C8(Name = "ПерваяГруппа", Comment = "", Synonym = "Первая (I)")]
        ПерваяГруппа,
        [Description1C8(Name = "ВтораяГруппа", Comment = "", Synonym = "Вторая (II)")]
        ВтораяГруппа,
        [Description1C8(Name = "ТретьяГруппа", Comment = "", Synonym = "Третья (III)")]
        ТретьяГруппа
    }
}
