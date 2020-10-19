using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыРасчетаУдержанияПоИсполнительномуДокументу:EnumBase
    {
        public СпособыРасчетаУдержанияПоИсполнительномуДокументу(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Процентом => GetProperty<EnumItem>("Процентом");
        public EnumItem Долей => GetProperty<EnumItem>("Долей");
        public EnumItem ФиксированнойСуммой => GetProperty<EnumItem>("ФиксированнойСуммой");
    }
}
