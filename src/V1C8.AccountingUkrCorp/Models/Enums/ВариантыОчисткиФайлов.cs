using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Table("VaryantyOchystkyFailov")]
    [Description1C8(Name = "ВариантыОчисткиФайлов", Comment = "", Synonym = "Варианты очистки файлов")]
    public class ВариантыОчисткиФайлов:EnumItem
    {
        public static readonly ВариантыОчисткиФайлов ОчиститьФайлыИВерсии = new ВариантыОчисткиФайлов{Name= "ОчиститьФайлыИВерсии",Synonym="Очистить файлы и версии",Comment=""};
        public static readonly ВариантыОчисткиФайлов ОчиститьФайлы = new ВариантыОчисткиФайлов{Name= "ОчиститьФайлы",Synonym="Очистить файлы",Comment=""};
        public static readonly ВариантыОчисткиФайлов ОчиститьВерсии = new ВариантыОчисткиФайлов{Name= "ОчиститьВерсии",Synonym="Очистить версии",Comment=""};
        public static readonly ВариантыОчисткиФайлов НеОчищать = new ВариантыОчисткиФайлов{Name= "НеОчищать",Synonym="Не очищать",Comment=""};
    }
}
