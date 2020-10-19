using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ПорядокРасчетаСтоимостиЕдиницыВремениОплатыТруда:V1C8COMObject
    {
        public ПорядокРасчетаСтоимостиЕдиницыВремениОплатыТруда(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПоНормеВремениГрафикаСотрудника => GetProperty<EnumItemBase>();
        public EnumItemBase ПоНормеВремениПроизводственногоКалендаря => GetProperty<EnumItemBase>();
        public EnumItemBase ПоСреднегодовомуЗначению => GetProperty<EnumItemBase>();
    }
}
