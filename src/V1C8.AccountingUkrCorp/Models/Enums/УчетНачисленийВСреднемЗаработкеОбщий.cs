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
    [Table("UchetNachyslenyiVSrednemZarabotkeObshchyi")]
    [Description1C8(Name = "УчетНачисленийВСреднемЗаработкеОбщий", Comment = "", Synonym = "Учет начислений в среднем заработке общий")]
    public class УчетНачисленийВСреднемЗаработкеОбщий:EnumItem
    {
        public static readonly УчетНачисленийВСреднемЗаработкеОбщий ОбщийЗаработок = new УчетНачисленийВСреднемЗаработкеОбщий{Name= "ОбщийЗаработок",Synonym="Общий заработок",Comment="Общий заработок"};
        public static readonly УчетНачисленийВСреднемЗаработкеОбщий ПремияФиксированнойСуммой = new УчетНачисленийВСреднемЗаработкеОбщий{Name= "ПремияФиксированнойСуммой",Synonym="Премия, учитываемая пропорционально",Comment="Премия, учитываемая пропорционально отработанному времени"};
        public static readonly УчетНачисленийВСреднемЗаработкеОбщий ПремияПроцентом = new УчетНачисленийВСреднемЗаработкеОбщий{Name= "ПремияПроцентом",Synonym="Премия, полностью учитываемая",Comment="Премия, полностью учитываемая"};
        public static readonly УчетНачисленийВСреднемЗаработкеОбщий ПремияГодоваяФиксированнойСуммой = new УчетНачисленийВСреднемЗаработкеОбщий{Name= "ПремияГодоваяФиксированнойСуммой",Synonym="Годовая премия, учитываемая пропорционально",Comment="Годовая премия, учитываемая пропорционально отработанному времени"};
        public static readonly УчетНачисленийВСреднемЗаработкеОбщий ПремияГодоваяПроцентом = new УчетНачисленийВСреднемЗаработкеОбщий{Name= "ПремияГодоваяПроцентом",Synonym="Годовая премия, полностью учитываемая",Comment="Годовая премия, полностью учитываемая"};
        public static readonly УчетНачисленийВСреднемЗаработкеОбщий НеВключать = new УчетНачисленийВСреднемЗаработкеОбщий{Name= "НеВключать",Synonym="Не включать",Comment="Не включать"};
    }
}
