using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыУдержанийДляТиповыхОтчетов:V1C8COMObject
    {
        public ВидыУдержанийДляТиповыхОтчетов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПрофсоюзныеВзносы => GetProperty<EnumItemBase>("ПрофсоюзныеВзносы");
        public EnumItemBase Алименты => GetProperty<EnumItemBase>("Алименты");
    }
}
