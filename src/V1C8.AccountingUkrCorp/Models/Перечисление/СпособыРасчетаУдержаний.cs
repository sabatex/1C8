using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыРасчетаУдержаний", Comment = "", Synonym = "Способы расчета удержаний")]
    public enum СпособыРасчетаУдержаний
    {
        [Description1C8(Name = "ФиксированнойСуммой", Comment = "(Общ)", Synonym = "Фиксированной суммой")]
        ФиксированнойСуммой,
        [Description1C8(Name = "Процентом", Comment = "(Общ)", Synonym = "Процентом")]
        Процентом,
        [Description1C8(Name = "ПроизвольнаяФормула", Comment = "", Synonym = "Произвольная формула")]
        ПроизвольнаяФормула,
        [Description1C8(Name = "ИсполнительныйЛист", Comment = "", Synonym = "Исполнительный лист")]
        ИсполнительныйЛист,
        [Description1C8(Name = "ВознаграждениеПлатежногоАгента", Comment = "", Synonym = "Вознаграждение платежного агента")]
        ВознаграждениеПлатежногоАгента
    }
}
