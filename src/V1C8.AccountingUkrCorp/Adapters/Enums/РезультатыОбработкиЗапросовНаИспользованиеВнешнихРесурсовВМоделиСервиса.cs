using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class РезультатыОбработкиЗапросовНаИспользованиеВнешнихРесурсовВМоделиСервиса:V1C8COMObject
    {
        public РезультатыОбработкиЗапросовНаИспользованиеВнешнихРесурсовВМоделиСервиса(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ЗапросОдобрен => GetProperty<EnumItemBase>();
        public EnumItemBase ЗапросОтклонен => GetProperty<EnumItemBase>();
    }
}
