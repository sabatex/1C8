using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыКонтрагентовВМонитореРуководителя:EnumBase
    {
        public ВидыКонтрагентовВМонитореРуководителя(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Покупатели => GetProperty<EnumItem>("Покупатели");
        public EnumItem Поставщики => GetProperty<EnumItem>("Поставщики");
    }
}
