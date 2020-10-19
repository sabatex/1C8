using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВариантыСжатияTIFF:V1C8COMObject
    {
        public ВариантыСжатияTIFF(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase CCITT3 => GetProperty<EnumItemBase>("CCITT3");
        public EnumItemBase CCITT4 => GetProperty<EnumItemBase>("CCITT4");
        public EnumItemBase LZW => GetProperty<EnumItemBase>("LZW");
        public EnumItemBase RLE => GetProperty<EnumItemBase>("RLE");
        public EnumItemBase БезСжатия => GetProperty<EnumItemBase>("БезСжатия");
    }
}
