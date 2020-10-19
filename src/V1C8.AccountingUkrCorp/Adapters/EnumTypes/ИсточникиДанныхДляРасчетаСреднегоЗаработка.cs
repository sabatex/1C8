using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ИсточникиДанныхДляРасчетаСреднегоЗаработка:EnumBase
    {
        public ИсточникиДанныхДляРасчетаСреднегоЗаработка(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ПереносДанных => GetProperty<EnumItem>("ПереносДанных");
        public EnumItem СведенияДоНачалаЭксплуатации => GetProperty<EnumItem>("СведенияДоНачалаЭксплуатации");
        public EnumItem Начисления => GetProperty<EnumItem>("Начисления");
        public EnumItem Исправления => GetProperty<EnumItem>("Исправления");
    }
}
