using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ТипыУслуг:V1C8COMObject
    {
        public ТипыУслуг(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Безлимитная => GetProperty<EnumItemBase>("Безлимитная");
        public EnumItemBase Лимитированная => GetProperty<EnumItemBase>("Лимитированная");
        public EnumItemBase Уникальная => GetProperty<EnumItemBase>("Уникальная");
    }
}
