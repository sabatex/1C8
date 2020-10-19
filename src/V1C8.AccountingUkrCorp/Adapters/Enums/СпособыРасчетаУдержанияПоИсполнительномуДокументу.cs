using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СпособыРасчетаУдержанияПоИсполнительномуДокументу:V1C8COMObject
    {
        public СпособыРасчетаУдержанияПоИсполнительномуДокументу(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Процентом => GetProperty<EnumItemBase>();
        public EnumItemBase Долей => GetProperty<EnumItemBase>();
        public EnumItemBase ФиксированнойСуммой => GetProperty<EnumItemBase>();
    }
}
