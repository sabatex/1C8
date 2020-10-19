using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class РезультатыОбработкиЗапросовНаИспользованиеВнешнихРесурсовВМоделиСервиса:EnumBase
    {
        public РезультатыОбработкиЗапросовНаИспользованиеВнешнихРесурсовВМоделиСервиса(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ЗапросОдобрен => GetProperty<EnumItem>("ЗапросОдобрен");
        public EnumItem ЗапросОтклонен => GetProperty<EnumItem>("ЗапросОтклонен");
    }
}
