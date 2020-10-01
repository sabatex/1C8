using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ГруппыПлательщиковЕдиногоНалога", Comment = "Группы плательщиков единого налога", Synonym = "Группы плательщиков единого налога")]
    public enum ГруппыПлательщиковЕдиногоНалога
    {
        [Description1C8(Name = "ПерваяГруппа", Comment = "", Synonym = "Первая группа")]
        ПерваяГруппа,
        [Description1C8(Name = "ВтораяГруппа", Comment = "", Synonym = "Вторая группа")]
        ВтораяГруппа,
        [Description1C8(Name = "ТретьяГруппа", Comment = "", Synonym = "Третья группа")]
        ТретьяГруппа,
        [Description1C8(Name = "ЧетвертаяГруппа", Comment = "", Synonym = "Четвертая группа")]
        ЧетвертаяГруппа,
        [Description1C8(Name = "ПятаяГруппа", Comment = "", Synonym = "Пятая группа")]
        ПятаяГруппа,
        [Description1C8(Name = "ШестаяГруппа", Comment = "", Synonym = "Шестая группа")]
        ШестаяГруппа
    }
}
