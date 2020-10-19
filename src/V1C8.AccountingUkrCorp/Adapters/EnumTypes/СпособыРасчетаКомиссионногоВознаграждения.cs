using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыРасчетаКомиссионногоВознаграждения:EnumBase
    {
        public СпособыРасчетаКомиссионногоВознаграждения(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem НеРассчитывается => GetProperty<EnumItem>("НеРассчитывается");
        public EnumItem ПроцентОтРазностиСуммПродажиИПоступления => GetProperty<EnumItem>("ПроцентОтРазностиСуммПродажиИПоступления");
        public EnumItem ПроцентОтСуммыПродажи => GetProperty<EnumItem>("ПроцентОтСуммыПродажи");
    }
}
