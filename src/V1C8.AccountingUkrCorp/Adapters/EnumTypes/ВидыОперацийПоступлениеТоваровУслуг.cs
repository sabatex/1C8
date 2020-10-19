using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОперацийПоступлениеТоваровУслуг:V1C8COMObject
    {
        public ВидыОперацийПоступлениеТоваровУслуг(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПокупкаКомиссия => GetProperty<EnumItemBase>("ПокупкаКомиссия");
        public EnumItemBase ВПереработку => GetProperty<EnumItemBase>("ВПереработку");
        public EnumItemBase Оборудование => GetProperty<EnumItemBase>("Оборудование");
        public EnumItemBase ОбъектыСтроительства => GetProperty<EnumItemBase>("ОбъектыСтроительства");
        public EnumItemBase БланкиСтрогогоУчета => GetProperty<EnumItemBase>("БланкиСтрогогоУчета");
    }
}
