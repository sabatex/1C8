using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters
{
    public class V1C8Adapter:V1C8COMConnector
    {
        public V1C8Adapter(string connectionString) :base(connectionString)
        {
        }
        public Enums Enums { get => GetProperty<Enums>("Enums"); }
        public Enums Перечисления { get => GetProperty<Enums>("Enums"); }
    }
}
