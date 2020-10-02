using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВариантыОчисткиФайлов", Comment = "", Synonym = "Варианты очистки файлов")]
    public class ВариантыОчисткиФайлов:EnumItem
    {
        public static readonly ВариантыОчисткиФайлов ОчиститьФайлыИВерсии = new ВариантыОчисткиФайлов{Name= "ОчиститьФайлыИВерсии",Synonim="Очистить файлы и версии",Comment=""};
        public static readonly ВариантыОчисткиФайлов ОчиститьФайлы = new ВариантыОчисткиФайлов{Name= "ОчиститьФайлы",Synonim="Очистить файлы",Comment=""};
        public static readonly ВариантыОчисткиФайлов ОчиститьВерсии = new ВариантыОчисткиФайлов{Name= "ОчиститьВерсии",Synonim="Очистить версии",Comment=""};
        public static readonly ВариантыОчисткиФайлов НеОчищать = new ВариантыОчисткиФайлов{Name= "НеОчищать",Synonim="Не очищать",Comment=""};
    }
}
