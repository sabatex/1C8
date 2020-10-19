using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВерсииФорматовВыгрузки:V1C8COMObject
    {
        public ВерсииФорматовВыгрузки(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ГНСУ_XML => GetProperty<EnumItemBase>("ГНСУ_XML");
    }
}
