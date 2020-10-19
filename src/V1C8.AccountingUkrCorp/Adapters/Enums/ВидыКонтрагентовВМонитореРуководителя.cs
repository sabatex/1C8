using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыКонтрагентовВМонитореРуководителя:V1C8COMObject
    {
        public ВидыКонтрагентовВМонитореРуководителя(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Покупатели => GetProperty<EnumItemBase>();
        public EnumItemBase Поставщики => GetProperty<EnumItemBase>();
    }
}
