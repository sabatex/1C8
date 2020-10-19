using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыКонтрагентовВМонитореРуководителя:V1C8COMObject
    {
        public ВидыКонтрагентовВМонитореРуководителя(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Покупатели => GetProperty<EnumItemBase>("Покупатели");
        public EnumItemBase Поставщики => GetProperty<EnumItemBase>("Поставщики");
    }
}
