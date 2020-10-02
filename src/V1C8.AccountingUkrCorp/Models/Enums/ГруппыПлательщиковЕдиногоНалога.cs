using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ГруппыПлательщиковЕдиногоНалога", Comment = "Группы плательщиков единого налога", Synonym = "Группы плательщиков единого налога")]
    public class ГруппыПлательщиковЕдиногоНалога:EnumItem
    {
        public static readonly ГруппыПлательщиковЕдиногоНалога ПерваяГруппа = new ГруппыПлательщиковЕдиногоНалога{Name= "ПерваяГруппа",Synonym="Первая группа",Comment=""};
        public static readonly ГруппыПлательщиковЕдиногоНалога ВтораяГруппа = new ГруппыПлательщиковЕдиногоНалога{Name= "ВтораяГруппа",Synonym="Вторая группа",Comment=""};
        public static readonly ГруппыПлательщиковЕдиногоНалога ТретьяГруппа = new ГруппыПлательщиковЕдиногоНалога{Name= "ТретьяГруппа",Synonym="Третья группа",Comment=""};
        public static readonly ГруппыПлательщиковЕдиногоНалога ЧетвертаяГруппа = new ГруппыПлательщиковЕдиногоНалога{Name= "ЧетвертаяГруппа",Synonym="Четвертая группа",Comment=""};
        public static readonly ГруппыПлательщиковЕдиногоНалога ПятаяГруппа = new ГруппыПлательщиковЕдиногоНалога{Name= "ПятаяГруппа",Synonym="Пятая группа",Comment=""};
        public static readonly ГруппыПлательщиковЕдиногоНалога ШестаяГруппа = new ГруппыПлательщиковЕдиногоНалога{Name= "ШестаяГруппа",Synonym="Шестая группа",Comment=""};
    }
}
