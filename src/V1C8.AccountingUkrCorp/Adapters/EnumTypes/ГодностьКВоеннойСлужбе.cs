using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ГодностьКВоеннойСлужбе:EnumBase
    {
        public ГодностьКВоеннойСлужбе(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Годен => GetProperty<EnumItem>("Годен");
        public EnumItem ГоденСОграничениями => GetProperty<EnumItem>("ГоденСОграничениями");
        public EnumItem ОграниченноГоден => GetProperty<EnumItem>("ОграниченноГоден");
        public EnumItem ВременноНеГоден => GetProperty<EnumItem>("ВременноНеГоден");
        public EnumItem НеГоден => GetProperty<EnumItem>("НеГоден");
    }
}
