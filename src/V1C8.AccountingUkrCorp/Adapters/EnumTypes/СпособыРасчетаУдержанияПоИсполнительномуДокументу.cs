using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыРасчетаУдержанияПоИсполнительномуДокументу:V1C8COMObject
    {
        public СпособыРасчетаУдержанияПоИсполнительномуДокументу(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Процентом => GetProperty<EnumItemBase>("Процентом");
        public EnumItemBase Долей => GetProperty<EnumItemBase>("Долей");
        public EnumItemBase ФиксированнойСуммой => GetProperty<EnumItemBase>("ФиксированнойСуммой");
    }
}
