using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВерсииПодсистемыОбменаДанными:V1C8COMObject
    {
        public ВерсииПодсистемыОбменаДанными(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Версия10 => GetProperty<EnumItemBase>("Версия10");
        public EnumItemBase Версия20 => GetProperty<EnumItemBase>("Версия20");
        public EnumItemBase Версия30 => GetProperty<EnumItemBase>("Версия30");
    }
}
