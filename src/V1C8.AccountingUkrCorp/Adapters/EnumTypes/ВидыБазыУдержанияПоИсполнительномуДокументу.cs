using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыБазыУдержанияПоИсполнительномуДокументу:V1C8COMObject
    {
        public ВидыБазыУдержанияПоИсполнительномуДокументу(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Заработок => GetProperty<EnumItemBase>("Заработок");
        public EnumItemBase ПрожиточныйМинимум => GetProperty<EnumItemBase>("ПрожиточныйМинимум");
    }
}
