using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыПоворотаИзображения:EnumBase
    {
        public СпособыПоворотаИзображения(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem НетПоворота => GetProperty<EnumItem>("НетПоворота");
        public EnumItem ВправоНа90 => GetProperty<EnumItem>("ВправоНа90");
        public EnumItem ВправоНа180 => GetProperty<EnumItem>("ВправоНа180");
        public EnumItem ВлевоНа90 => GetProperty<EnumItem>("ВлевоНа90");
    }
}
