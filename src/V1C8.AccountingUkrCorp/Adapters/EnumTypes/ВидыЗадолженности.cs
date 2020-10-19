using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыЗадолженности:EnumBase
    {
        public ВидыЗадолженности(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Дебиторская => GetProperty<EnumItem>("Дебиторская");
        public EnumItem Кредиторская => GetProperty<EnumItem>("Кредиторская");
    }
}
