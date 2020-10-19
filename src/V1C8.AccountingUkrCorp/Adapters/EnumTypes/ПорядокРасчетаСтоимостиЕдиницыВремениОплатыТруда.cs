using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ПорядокРасчетаСтоимостиЕдиницыВремениОплатыТруда:EnumBase
    {
        public ПорядокРасчетаСтоимостиЕдиницыВремениОплатыТруда(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ПоНормеВремениГрафикаСотрудника => GetProperty<EnumItem>("ПоНормеВремениГрафикаСотрудника");
        public EnumItem ПоНормеВремениПроизводственногоКалендаря => GetProperty<EnumItem>("ПоНормеВремениПроизводственногоКалендаря");
        public EnumItem ПоСреднегодовомуЗначению => GetProperty<EnumItem>("ПоСреднегодовомуЗначению");
    }
}
