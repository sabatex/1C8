using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВариантыСжатияTIFF:V1C8COMObject
    {
        public ВариантыСжатияTIFF(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase CCITT3 => GetProperty<EnumItemBase>();
        public EnumItemBase CCITT4 => GetProperty<EnumItemBase>();
        public EnumItemBase LZW => GetProperty<EnumItemBase>();
        public EnumItemBase RLE => GetProperty<EnumItemBase>();
        public EnumItemBase БезСжатия => GetProperty<EnumItemBase>();
    }
}
