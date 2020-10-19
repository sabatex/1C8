using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class МетодыНачисленияРезервовОтпусков:V1C8COMObject
    {
        public МетодыНачисленияРезервовОтпусков(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase МетодОбязательств => GetProperty<EnumItemBase>();
        public EnumItemBase НормативныйМетод => GetProperty<EnumItemBase>();
    }
}
