using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ИсточникиДанныхДляРасчетаСреднегоЗаработка", Comment = "", Synonym = "Источники данных для расчета среднего заработка")]
    public class ИсточникиДанныхДляРасчетаСреднегоЗаработка:EnumItem
    {
        public static readonly ИсточникиДанныхДляРасчетаСреднегоЗаработка ПереносДанных = new ИсточникиДанныхДляРасчетаСреднегоЗаработка{Name= "ПереносДанных",Synonym="Перенос данных",Comment=""};
        public static readonly ИсточникиДанныхДляРасчетаСреднегоЗаработка СведенияДоНачалаЭксплуатации = new ИсточникиДанныхДляРасчетаСреднегоЗаработка{Name= "СведенияДоНачалаЭксплуатации",Synonym="Сведения до начала эксплуатации",Comment=""};
        public static readonly ИсточникиДанныхДляРасчетаСреднегоЗаработка Начисления = new ИсточникиДанныхДляРасчетаСреднегоЗаработка{Name= "Начисления",Synonym="Начисления",Comment=""};
        public static readonly ИсточникиДанныхДляРасчетаСреднегоЗаработка Исправления = new ИсточникиДанныхДляРасчетаСреднегоЗаработка{Name= "Исправления",Synonym="Исправления",Comment=""};
    }
}
