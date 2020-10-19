using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыРасчетаУдержаний:V1C8COMObject
    {
        public СпособыРасчетаУдержаний(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ФиксированнойСуммой => GetProperty<EnumItemBase>("ФиксированнойСуммой");
        public EnumItemBase Процентом => GetProperty<EnumItemBase>("Процентом");
        public EnumItemBase ПроизвольнаяФормула => GetProperty<EnumItemBase>("ПроизвольнаяФормула");
        public EnumItemBase ИсполнительныйЛист => GetProperty<EnumItemBase>("ИсполнительныйЛист");
        public EnumItemBase ВознаграждениеПлатежногоАгента => GetProperty<EnumItemBase>("ВознаграждениеПлатежногоАгента");
    }
}
