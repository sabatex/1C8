using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВерсииПодсистемыОбменаДанными:EnumBase
    {
        public ВерсииПодсистемыОбменаДанными(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Версия10 => GetProperty<EnumItem>("Версия10");
        public EnumItem Версия20 => GetProperty<EnumItem>("Версия20");
        public EnumItem Версия30 => GetProperty<EnumItem>("Версия30");
    }
}
