using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ОтношениеКВоинскойОбязанности:EnumBase
    {
        public ОтношениеКВоинскойОбязанности(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Военнообязанный => GetProperty<EnumItem>("Военнообязанный");
        public EnumItem НеВоеннообязанный => GetProperty<EnumItem>("НеВоеннообязанный");
        public EnumItem Призывник => GetProperty<EnumItem>("Призывник");
    }
}
