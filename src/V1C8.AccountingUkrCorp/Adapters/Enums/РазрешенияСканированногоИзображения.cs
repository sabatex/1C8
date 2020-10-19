using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class РазрешенияСканированногоИзображения:V1C8COMObject
    {
        public РазрешенияСканированногоИзображения(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase dpi200 => GetProperty<EnumItemBase>();
        public EnumItemBase dpi300 => GetProperty<EnumItemBase>();
        public EnumItemBase dpi600 => GetProperty<EnumItemBase>();
        public EnumItemBase dpi1200 => GetProperty<EnumItemBase>();
    }
}
