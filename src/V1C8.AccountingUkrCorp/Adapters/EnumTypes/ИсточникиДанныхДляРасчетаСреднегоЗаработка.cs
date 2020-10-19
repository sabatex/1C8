using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ИсточникиДанныхДляРасчетаСреднегоЗаработка:V1C8COMObject
    {
        public ИсточникиДанныхДляРасчетаСреднегоЗаработка(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПереносДанных => GetProperty<EnumItemBase>("ПереносДанных");
        public EnumItemBase СведенияДоНачалаЭксплуатации => GetProperty<EnumItemBase>("СведенияДоНачалаЭксплуатации");
        public EnumItemBase Начисления => GetProperty<EnumItemBase>("Начисления");
        public EnumItemBase Исправления => GetProperty<EnumItemBase>("Исправления");
    }
}
