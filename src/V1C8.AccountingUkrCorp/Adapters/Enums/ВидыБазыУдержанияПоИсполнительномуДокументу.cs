using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыБазыУдержанияПоИсполнительномуДокументу:V1C8COMObject
    {
        public ВидыБазыУдержанияПоИсполнительномуДокументу(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Заработок => GetProperty<EnumItemBase>();
        public EnumItemBase ПрожиточныйМинимум => GetProperty<EnumItemBase>();
    }
}
