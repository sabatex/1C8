using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ПорядокРасчетаСтоимостиЕдиницыВремениОплатыТруда:V1C8COMObject
    {
        public ПорядокРасчетаСтоимостиЕдиницыВремениОплатыТруда(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПоНормеВремениГрафикаСотрудника => GetProperty<EnumItemBase>("ПоНормеВремениГрафикаСотрудника");
        public EnumItemBase ПоНормеВремениПроизводственногоКалендаря => GetProperty<EnumItemBase>("ПоНормеВремениПроизводственногоКалендаря");
        public EnumItemBase ПоСреднегодовомуЗначению => GetProperty<EnumItemBase>("ПоСреднегодовомуЗначению");
    }
}
