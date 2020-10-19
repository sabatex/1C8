using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class РазрешенияСканированногоИзображения:EnumBase
    {
        public РазрешенияСканированногоИзображения(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem dpi200 => GetProperty<EnumItem>("dpi200");
        public EnumItem dpi300 => GetProperty<EnumItem>("dpi300");
        public EnumItem dpi600 => GetProperty<EnumItem>("dpi600");
        public EnumItem dpi1200 => GetProperty<EnumItem>("dpi1200");
    }
}
