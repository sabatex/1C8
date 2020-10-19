using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ГодностьКВоеннойСлужбе:V1C8COMObject
    {
        public ГодностьКВоеннойСлужбе(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Годен => GetProperty<EnumItemBase>("Годен");
        public EnumItemBase ГоденСОграничениями => GetProperty<EnumItemBase>("ГоденСОграничениями");
        public EnumItemBase ОграниченноГоден => GetProperty<EnumItemBase>("ОграниченноГоден");
        public EnumItemBase ВременноНеГоден => GetProperty<EnumItemBase>("ВременноНеГоден");
        public EnumItemBase НеГоден => GetProperty<EnumItemBase>("НеГоден");
    }
}
