using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ИсточникиПравилДляОбменаДанными:EnumBase
    {
        public ИсточникиПравилДляОбменаДанными(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem МакетКонфигурации => GetProperty<EnumItem>("МакетКонфигурации");
        public EnumItem Файл => GetProperty<EnumItem>("Файл");
    }
}
