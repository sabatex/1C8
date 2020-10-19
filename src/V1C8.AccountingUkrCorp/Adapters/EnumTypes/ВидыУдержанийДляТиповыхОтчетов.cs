using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыУдержанийДляТиповыхОтчетов:EnumBase
    {
        public ВидыУдержанийДляТиповыхОтчетов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ПрофсоюзныеВзносы => GetProperty<EnumItem>("ПрофсоюзныеВзносы");
        public EnumItem Алименты => GetProperty<EnumItem>("Алименты");
    }
}
