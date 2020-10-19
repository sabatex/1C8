using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОперацийВозвратТоваровПоставщику:V1C8COMObject
    {
        public ВидыОперацийВозвратТоваровПоставщику(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПокупкаКомиссия => GetProperty<EnumItemBase>("ПокупкаКомиссия");
        public EnumItemBase ИзПереработки => GetProperty<EnumItemBase>("ИзПереработки");
        public EnumItemBase Оборудование => GetProperty<EnumItemBase>("Оборудование");
    }
}
