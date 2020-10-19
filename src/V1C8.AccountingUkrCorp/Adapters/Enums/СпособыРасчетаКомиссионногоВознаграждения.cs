using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СпособыРасчетаКомиссионногоВознаграждения:V1C8COMObject
    {
        public СпособыРасчетаКомиссионногоВознаграждения(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase НеРассчитывается => GetProperty<EnumItemBase>();
        public EnumItemBase ПроцентОтРазностиСуммПродажиИПоступления => GetProperty<EnumItemBase>();
        public EnumItemBase ПроцентОтСуммыПродажи => GetProperty<EnumItemBase>();
    }
}
