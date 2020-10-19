using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class УчетНачисленийВСреднемЗаработкеОбщий:EnumBase
    {
        public УчетНачисленийВСреднемЗаработкеОбщий(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ОбщийЗаработок => GetProperty<EnumItem>("ОбщийЗаработок");
        public EnumItem ПремияФиксированнойСуммой => GetProperty<EnumItem>("ПремияФиксированнойСуммой");
        public EnumItem ПремияПроцентом => GetProperty<EnumItem>("ПремияПроцентом");
        public EnumItem ПремияГодоваяФиксированнойСуммой => GetProperty<EnumItem>("ПремияГодоваяФиксированнойСуммой");
        public EnumItem ПремияГодоваяПроцентом => GetProperty<EnumItem>("ПремияГодоваяПроцентом");
        public EnumItem НеВключать => GetProperty<EnumItem>("НеВключать");
    }
}
