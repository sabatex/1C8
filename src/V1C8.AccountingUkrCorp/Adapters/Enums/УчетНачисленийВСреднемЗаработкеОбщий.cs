using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class УчетНачисленийВСреднемЗаработкеОбщий:V1C8COMObject
    {
        public УчетНачисленийВСреднемЗаработкеОбщий(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОбщийЗаработок => GetProperty<EnumItemBase>();
        public EnumItemBase ПремияФиксированнойСуммой => GetProperty<EnumItemBase>();
        public EnumItemBase ПремияПроцентом => GetProperty<EnumItemBase>();
        public EnumItemBase ПремияГодоваяФиксированнойСуммой => GetProperty<EnumItemBase>();
        public EnumItemBase ПремияГодоваяПроцентом => GetProperty<EnumItemBase>();
        public EnumItemBase НеВключать => GetProperty<EnumItemBase>();
    }
}
