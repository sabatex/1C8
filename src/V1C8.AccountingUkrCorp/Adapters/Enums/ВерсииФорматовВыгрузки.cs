using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВерсииФорматовВыгрузки:V1C8COMObject
    {
        public ВерсииФорматовВыгрузки(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ГНСУ_XML => GetProperty<EnumItemBase>();
    }
}
