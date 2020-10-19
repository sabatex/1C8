using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ОтношениеКВоинскойОбязанности:V1C8COMObject
    {
        public ОтношениеКВоинскойОбязанности(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Военнообязанный => GetProperty<EnumItemBase>();
        public EnumItemBase НеВоеннообязанный => GetProperty<EnumItemBase>();
        public EnumItemBase Призывник => GetProperty<EnumItemBase>();
    }
}
