using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters
{
    public class V1C8Adapter:V1C8COMConnector
    {
        public EnumsType Enums { get => GetProperty<EnumsType>("Enums"); }
        public EnumsType Перечисления { get => GetProperty<EnumsType>("Enums"); }
    }
}
