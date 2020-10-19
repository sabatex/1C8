using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ХарактерВыплатыЗарплаты:V1C8COMObject
    {
        public ХарактерВыплатыЗарплаты(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Аванс => GetProperty<EnumItemBase>("Аванс");
        public EnumItemBase Межрасчет => GetProperty<EnumItemBase>("Межрасчет");
        public EnumItemBase Зарплата => GetProperty<EnumItemBase>("Зарплата");
    }
}
