using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ФорматыСканированногоИзображения:V1C8COMObject
    {
        public ФорматыСканированногоИзображения(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase BMP => GetProperty<EnumItemBase>("BMP");
        public EnumItemBase JPG => GetProperty<EnumItemBase>("JPG");
        public EnumItemBase GIF => GetProperty<EnumItemBase>("GIF");
        public EnumItemBase PNG => GetProperty<EnumItemBase>("PNG");
        public EnumItemBase TIF => GetProperty<EnumItemBase>("TIF");
    }
}
