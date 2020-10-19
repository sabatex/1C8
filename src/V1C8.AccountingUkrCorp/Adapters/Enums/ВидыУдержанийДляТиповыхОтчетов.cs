using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыУдержанийДляТиповыхОтчетов:V1C8COMObject
    {
        public ВидыУдержанийДляТиповыхОтчетов(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПрофсоюзныеВзносы => GetProperty<EnumItemBase>();
        public EnumItemBase Алименты => GetProperty<EnumItemBase>();
    }
}
