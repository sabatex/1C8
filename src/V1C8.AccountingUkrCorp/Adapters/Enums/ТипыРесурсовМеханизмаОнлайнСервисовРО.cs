using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ТипыРесурсовМеханизмаОнлайнСервисовРО:V1C8COMObject
    {
        public ТипыРесурсовМеханизмаОнлайнСервисовРО(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase СправочникФормИФорматов => GetProperty<EnumItemBase>();
        public EnumItemBase СправочникРелизов => GetProperty<EnumItemBase>();
        public EnumItemBase ИнформацияОРелизе => GetProperty<EnumItemBase>();
    }
}
