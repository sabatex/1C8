using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВариантыСжатияTIFF:EnumBase
    {
        public ВариантыСжатияTIFF(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem CCITT3 => GetProperty<EnumItem>("CCITT3");
        public EnumItem CCITT4 => GetProperty<EnumItem>("CCITT4");
        public EnumItem LZW => GetProperty<EnumItem>("LZW");
        public EnumItem RLE => GetProperty<EnumItem>("RLE");
        public EnumItem БезСжатия => GetProperty<EnumItem>("БезСжатия");
    }
}
