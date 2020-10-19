using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВерсииПодсистемыОбменаДанными:V1C8COMObject
    {
        public ВерсииПодсистемыОбменаДанными(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Версия10 => GetProperty<EnumItemBase>();
        public EnumItemBase Версия20 => GetProperty<EnumItemBase>();
        public EnumItemBase Версия30 => GetProperty<EnumItemBase>();
    }
}
