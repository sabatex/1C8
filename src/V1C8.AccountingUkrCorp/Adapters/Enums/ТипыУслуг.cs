using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ТипыУслуг:V1C8COMObject
    {
        public ТипыУслуг(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Безлимитная => GetProperty<EnumItemBase>();
        public EnumItemBase Лимитированная => GetProperty<EnumItemBase>();
        public EnumItemBase Уникальная => GetProperty<EnumItemBase>();
    }
}
