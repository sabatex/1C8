using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыПоворотаИзображения:V1C8COMObject
    {
        public СпособыПоворотаИзображения(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase НетПоворота => GetProperty<EnumItemBase>("НетПоворота");
        public EnumItemBase ВправоНа90 => GetProperty<EnumItemBase>("ВправоНа90");
        public EnumItemBase ВправоНа180 => GetProperty<EnumItemBase>("ВправоНа180");
        public EnumItemBase ВлевоНа90 => GetProperty<EnumItemBase>("ВлевоНа90");
    }
}
