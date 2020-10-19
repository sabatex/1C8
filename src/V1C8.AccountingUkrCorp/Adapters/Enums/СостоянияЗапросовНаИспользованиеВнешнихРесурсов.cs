using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СостоянияЗапросовНаИспользованиеВнешнихРесурсов:V1C8COMObject
    {
        public СостоянияЗапросовНаИспользованиеВнешнихРесурсов(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Новый => GetProperty<EnumItemBase>();
        public EnumItemBase Применен => GetProperty<EnumItemBase>();
        public EnumItemBase Проверен => GetProperty<EnumItemBase>();
    }
}
