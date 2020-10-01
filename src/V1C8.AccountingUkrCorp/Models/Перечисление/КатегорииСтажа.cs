using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "КатегорииСтажа", Comment = "", Synonym = "Категории стажа")]
    public enum КатегорииСтажа
    {
        [Description1C8(Name = "ВыслугаЛет", Comment = "", Synonym = "Выслуга лет")]
        ВыслугаЛет,
        [Description1C8(Name = "Медицинский", Comment = "", Synonym = "Медицинский")]
        Медицинский,
        [Description1C8(Name = "Непрерывный", Comment = "", Synonym = "Непрерывный")]
        Непрерывный,
        [Description1C8(Name = "Общий", Comment = "", Synonym = "Общий")]
        Общий,
        [Description1C8(Name = "ОбщийНаучноПедагогический", Comment = "", Synonym = "Общий научно-педагогический")]
        ОбщийНаучноПедагогический,
        [Description1C8(Name = "Педагогический", Comment = "", Synonym = "Педагогический")]
        Педагогический,
        [Description1C8(Name = "Прочее", Comment = "", Synonym = "Прочее")]
        Прочее,
        [Description1C8(Name = "РасширенныйСтраховой", Comment = "", Synonym = "Расширенный страховой")]
        РасширенныйСтраховой,
        [Description1C8(Name = "Северный", Comment = "", Synonym = "Северный")]
        Северный,
        [Description1C8(Name = "Страховой", Comment = "", Synonym = "Страховой")]
        Страховой,
        [Description1C8(Name = "ВыслугаЛетНаГосударственнойСлужбе", Comment = "", Synonym = "Выслуга лет на государственной (муниципальной) службе")]
        ВыслугаЛетНаГосударственнойСлужбе,
        [Description1C8(Name = "ВыслугаЛетНаВоеннойСлужбе", Comment = "", Synonym = "Выслуга лет на военной службе")]
        ВыслугаЛетНаВоеннойСлужбе
    }
}
