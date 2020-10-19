using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ТипыРесурсовМеханизмаОнлайнСервисовРО:V1C8COMObject
    {
        public ТипыРесурсовМеханизмаОнлайнСервисовРО(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase СправочникФормИФорматов => GetProperty<EnumItemBase>("СправочникФормИФорматов");
        public EnumItemBase СправочникРелизов => GetProperty<EnumItemBase>("СправочникРелизов");
        public EnumItemBase ИнформацияОРелизе => GetProperty<EnumItemBase>("ИнформацияОРелизе");
    }
}
