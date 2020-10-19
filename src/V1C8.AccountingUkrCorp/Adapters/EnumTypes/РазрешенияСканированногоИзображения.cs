using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class РазрешенияСканированногоИзображения:V1C8COMObject
    {
        public РазрешенияСканированногоИзображения(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase dpi200 => GetProperty<EnumItemBase>("dpi200");
        public EnumItemBase dpi300 => GetProperty<EnumItemBase>("dpi300");
        public EnumItemBase dpi600 => GetProperty<EnumItemBase>("dpi600");
        public EnumItemBase dpi1200 => GetProperty<EnumItemBase>("dpi1200");
    }
}
