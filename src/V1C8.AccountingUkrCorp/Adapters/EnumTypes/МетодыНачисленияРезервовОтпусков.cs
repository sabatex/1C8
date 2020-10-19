using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class МетодыНачисленияРезервовОтпусков:V1C8COMObject
    {
        public МетодыНачисленияРезервовОтпусков(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase МетодОбязательств => GetProperty<EnumItemBase>("МетодОбязательств");
        public EnumItemBase НормативныйМетод => GetProperty<EnumItemBase>("НормативныйМетод");
    }
}
