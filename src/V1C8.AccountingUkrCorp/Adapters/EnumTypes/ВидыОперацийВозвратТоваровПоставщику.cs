using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОперацийВозвратТоваровПоставщику:EnumBase
    {
        public ВидыОперацийВозвратТоваровПоставщику(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ПокупкаКомиссия => GetProperty<EnumItem>("ПокупкаКомиссия");
        public EnumItem ИзПереработки => GetProperty<EnumItem>("ИзПереработки");
        public EnumItem Оборудование => GetProperty<EnumItem>("Оборудование");
    }
}
