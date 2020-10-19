using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СпособыПоворотаИзображения:V1C8COMObject
    {
        public СпособыПоворотаИзображения(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase НетПоворота => GetProperty<EnumItemBase>();
        public EnumItemBase ВправоНа90 => GetProperty<EnumItemBase>();
        public EnumItemBase ВправоНа180 => GetProperty<EnumItemBase>();
        public EnumItemBase ВлевоНа90 => GetProperty<EnumItemBase>();
    }
}
