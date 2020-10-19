using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ИсточникиПравилДляОбменаДанными:V1C8COMObject
    {
        public ИсточникиПравилДляОбменаДанными(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase МакетКонфигурации => GetProperty<EnumItemBase>();
        public EnumItemBase Файл => GetProperty<EnumItemBase>();
    }
}
