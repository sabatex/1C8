using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СостоянияЗапросовНаИспользованиеВнешнихРесурсов:V1C8COMObject
    {
        public СостоянияЗапросовНаИспользованиеВнешнихРесурсов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Новый => GetProperty<EnumItemBase>("Новый");
        public EnumItemBase Применен => GetProperty<EnumItemBase>("Применен");
        public EnumItemBase Проверен => GetProperty<EnumItemBase>("Проверен");
    }
}
