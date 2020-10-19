using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ОтношениеКВоинскойОбязанности:V1C8COMObject
    {
        public ОтношениеКВоинскойОбязанности(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Военнообязанный => GetProperty<EnumItemBase>("Военнообязанный");
        public EnumItemBase НеВоеннообязанный => GetProperty<EnumItemBase>("НеВоеннообязанный");
        public EnumItemBase Призывник => GetProperty<EnumItemBase>("Призывник");
    }
}
