using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыРасчетаУдержаний", Comment = "", Synonym = "Способы расчета удержаний")]
    public class СпособыРасчетаУдержаний:EnumItem
    {
        public static readonly СпособыРасчетаУдержаний ФиксированнойСуммой = new СпособыРасчетаУдержаний{Name= "ФиксированнойСуммой",Synonym="Фиксированной суммой",Comment="(Общ)"};
        public static readonly СпособыРасчетаУдержаний Процентом = new СпособыРасчетаУдержаний{Name= "Процентом",Synonym="Процентом",Comment="(Общ)"};
        public static readonly СпособыРасчетаУдержаний ПроизвольнаяФормула = new СпособыРасчетаУдержаний{Name= "ПроизвольнаяФормула",Synonym="Произвольная формула",Comment=""};
        public static readonly СпособыРасчетаУдержаний ИсполнительныйЛист = new СпособыРасчетаУдержаний{Name= "ИсполнительныйЛист",Synonym="Исполнительный лист",Comment=""};
        public static readonly СпособыРасчетаУдержаний ВознаграждениеПлатежногоАгента = new СпособыРасчетаУдержаний{Name= "ВознаграждениеПлатежногоАгента",Synonym="Вознаграждение платежного агента",Comment=""};
    }
}
