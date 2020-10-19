using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыРасчетаУдержаний:EnumBase
    {
        public СпособыРасчетаУдержаний(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ФиксированнойСуммой => GetProperty<EnumItem>("ФиксированнойСуммой");
        public EnumItem Процентом => GetProperty<EnumItem>("Процентом");
        public EnumItem ПроизвольнаяФормула => GetProperty<EnumItem>("ПроизвольнаяФормула");
        public EnumItem ИсполнительныйЛист => GetProperty<EnumItem>("ИсполнительныйЛист");
        public EnumItem ВознаграждениеПлатежногоАгента => GetProperty<EnumItem>("ВознаграждениеПлатежногоАгента");
    }
}
