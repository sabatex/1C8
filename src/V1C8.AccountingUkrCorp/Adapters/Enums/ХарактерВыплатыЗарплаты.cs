using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ХарактерВыплатыЗарплаты:V1C8COMObject
    {
        public ХарактерВыплатыЗарплаты(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Аванс => GetProperty<EnumItemBase>();
        public EnumItemBase Межрасчет => GetProperty<EnumItemBase>();
        public EnumItemBase Зарплата => GetProperty<EnumItemBase>();
    }
}
