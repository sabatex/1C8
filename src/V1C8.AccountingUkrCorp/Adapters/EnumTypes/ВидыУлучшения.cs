using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыУлучшения:V1C8COMObject
    {
        public ВидыУлучшения(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Модернизация => GetProperty<EnumItemBase>("Модернизация");
        public EnumItemBase Ремонт => GetProperty<EnumItemBase>("Ремонт");
    }
}
