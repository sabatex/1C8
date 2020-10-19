using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыРасчетаПоШкале:EnumBase
    {
        public СпособыРасчетаПоШкале(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ПоШкале => GetProperty<EnumItem>("ПоШкале");
        public EnumItem Прогрессивный => GetProperty<EnumItem>("Прогрессивный");
        public EnumItem СДекретных => GetProperty<EnumItem>("СДекретных");
    }
}
