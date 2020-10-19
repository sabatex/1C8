using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ТипыУслуг:EnumBase
    {
        public ТипыУслуг(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Безлимитная => GetProperty<EnumItem>("Безлимитная");
        public EnumItem Лимитированная => GetProperty<EnumItem>("Лимитированная");
        public EnumItem Уникальная => GetProperty<EnumItem>("Уникальная");
    }
}
