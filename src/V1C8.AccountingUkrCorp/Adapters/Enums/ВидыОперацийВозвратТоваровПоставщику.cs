using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыОперацийВозвратТоваровПоставщику:V1C8COMObject
    {
        public ВидыОперацийВозвратТоваровПоставщику(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПокупкаКомиссия => GetProperty<EnumItemBase>();
        public EnumItemBase ИзПереработки => GetProperty<EnumItemBase>();
        public EnumItemBase Оборудование => GetProperty<EnumItemBase>();
    }
}
