using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "УчетНачисленийВСреднемЗаработкеОбщий", Comment = "", Synonym = "Учет начислений в среднем заработке общий")]
    public enum УчетНачисленийВСреднемЗаработкеОбщий
    {
        [Description1C8(Name = "ОбщийЗаработок", Comment = "Общий заработок", Synonym = "Общий заработок")]
        ОбщийЗаработок,
        [Description1C8(Name = "ПремияФиксированнойСуммой", Comment = "Премия, учитываемая пропорционально отработанному времени", Synonym = "Премия, учитываемая пропорционально")]
        ПремияФиксированнойСуммой,
        [Description1C8(Name = "ПремияПроцентом", Comment = "Премия, полностью учитываемая", Synonym = "Премия, полностью учитываемая")]
        ПремияПроцентом,
        [Description1C8(Name = "ПремияГодоваяФиксированнойСуммой", Comment = "Годовая премия, учитываемая пропорционально отработанному времени", Synonym = "Годовая премия, учитываемая пропорционально")]
        ПремияГодоваяФиксированнойСуммой,
        [Description1C8(Name = "ПремияГодоваяПроцентом", Comment = "Годовая премия, полностью учитываемая", Synonym = "Годовая премия, полностью учитываемая")]
        ПремияГодоваяПроцентом,
        [Description1C8(Name = "НеВключать", Comment = "Не включать", Synonym = "Не включать")]
        НеВключать
    }
}
