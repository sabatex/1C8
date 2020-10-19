using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ХарактерВыплатыЗарплаты:EnumBase
    {
        public ХарактерВыплатыЗарплаты(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Аванс => GetProperty<EnumItem>("Аванс");
        public EnumItem Межрасчет => GetProperty<EnumItem>("Межрасчет");
        public EnumItem Зарплата => GetProperty<EnumItem>("Зарплата");
    }
}
