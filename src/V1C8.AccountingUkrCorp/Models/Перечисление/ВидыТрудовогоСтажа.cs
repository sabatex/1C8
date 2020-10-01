using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыТрудовогоСтажа", Comment = "", Synonym = "Виды трудового стажа")]
    public enum ВидыТрудовогоСтажа
    {
        [Description1C8(Name = "ОбщийТрудовойСтаж", Comment = "", Synonym = "Общий трудовой стаж")]
        ОбщийТрудовойСтаж,
        [Description1C8(Name = "ТерриториальныеУсловия", Comment = "", Synonym = "Территориальные условия")]
        ТерриториальныеУсловия,
        [Description1C8(Name = "ОсобыеУсловияТруда", Comment = "", Synonym = "Особые условия труда")]
        ОсобыеУсловияТруда,
        [Description1C8(Name = "ВыслугаЛет", Comment = "", Synonym = "Выслуга лет")]
        ВыслугаЛет
    }
}
