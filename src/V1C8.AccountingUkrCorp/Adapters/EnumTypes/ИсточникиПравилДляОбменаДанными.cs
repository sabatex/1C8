using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ИсточникиПравилДляОбменаДанными:V1C8COMObject
    {
        public ИсточникиПравилДляОбменаДанными(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase МакетКонфигурации => GetProperty<EnumItemBase>("МакетКонфигурации");
        public EnumItemBase Файл => GetProperty<EnumItemBase>("Файл");
    }
}
