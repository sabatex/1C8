using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВариантыОчисткиФайлов", Comment = "", Synonym = "Варианты очистки файлов")]
    public enum ВариантыОчисткиФайлов
    {
        [Description1C8(Name = "ОчиститьФайлыИВерсии", Comment = "", Synonym = "Очистить файлы и версии")]
        ОчиститьФайлыИВерсии,
        [Description1C8(Name = "ОчиститьФайлы", Comment = "", Synonym = "Очистить файлы")]
        ОчиститьФайлы,
        [Description1C8(Name = "ОчиститьВерсии", Comment = "", Synonym = "Очистить версии")]
        ОчиститьВерсии,
        [Description1C8(Name = "НеОчищать", Comment = "", Synonym = "Не очищать")]
        НеОчищать
    }
}
