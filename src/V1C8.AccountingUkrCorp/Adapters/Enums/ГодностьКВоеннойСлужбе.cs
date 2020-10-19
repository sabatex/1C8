using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ГодностьКВоеннойСлужбе:V1C8COMObject
    {
        public ГодностьКВоеннойСлужбе(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Годен => GetProperty<EnumItemBase>();
        public EnumItemBase ГоденСОграничениями => GetProperty<EnumItemBase>();
        public EnumItemBase ОграниченноГоден => GetProperty<EnumItemBase>();
        public EnumItemBase ВременноНеГоден => GetProperty<EnumItemBase>();
        public EnumItemBase НеГоден => GetProperty<EnumItemBase>();
    }
}
