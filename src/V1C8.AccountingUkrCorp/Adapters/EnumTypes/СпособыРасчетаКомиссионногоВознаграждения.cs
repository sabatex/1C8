using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыРасчетаКомиссионногоВознаграждения:V1C8COMObject
    {
        public СпособыРасчетаКомиссионногоВознаграждения(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase НеРассчитывается => GetProperty<EnumItemBase>("НеРассчитывается");
        public EnumItemBase ПроцентОтРазностиСуммПродажиИПоступления => GetProperty<EnumItemBase>("ПроцентОтРазностиСуммПродажиИПоступления");
        public EnumItemBase ПроцентОтСуммыПродажи => GetProperty<EnumItemBase>("ПроцентОтСуммыПродажи");
    }
}
