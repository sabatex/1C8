using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СпособыРасчетаПоШкале:V1C8COMObject
    {
        public СпособыРасчетаПоШкале(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПоШкале => GetProperty<EnumItemBase>();
        public EnumItemBase Прогрессивный => GetProperty<EnumItemBase>();
        public EnumItemBase СДекретных => GetProperty<EnumItemBase>();
    }
}
