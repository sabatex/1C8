using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class УчетНачисленийВСреднемЗаработкеОбщий:V1C8COMObject
    {
        public УчетНачисленийВСреднемЗаработкеОбщий(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОбщийЗаработок => GetProperty<EnumItemBase>("ОбщийЗаработок");
        public EnumItemBase ПремияФиксированнойСуммой => GetProperty<EnumItemBase>("ПремияФиксированнойСуммой");
        public EnumItemBase ПремияПроцентом => GetProperty<EnumItemBase>("ПремияПроцентом");
        public EnumItemBase ПремияГодоваяФиксированнойСуммой => GetProperty<EnumItemBase>("ПремияГодоваяФиксированнойСуммой");
        public EnumItemBase ПремияГодоваяПроцентом => GetProperty<EnumItemBase>("ПремияГодоваяПроцентом");
        public EnumItemBase НеВключать => GetProperty<EnumItemBase>("НеВключать");
    }
}
