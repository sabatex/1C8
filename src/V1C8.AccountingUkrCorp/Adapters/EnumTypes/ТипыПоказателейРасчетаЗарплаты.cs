using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ТипыПоказателейРасчетаЗарплаты:V1C8COMObject
    {
        public ТипыПоказателейРасчетаЗарплаты(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Денежный => GetProperty<EnumItemBase>("Денежный");
        public EnumItemBase Числовой => GetProperty<EnumItemBase>("Числовой");
        public EnumItemBase ЧисловойЗависящийОтДругогоПоказателя => GetProperty<EnumItemBase>("ЧисловойЗависящийОтДругогоПоказателя");
        public EnumItemBase ЧисловойЗависящийОтСтажа => GetProperty<EnumItemBase>("ЧисловойЗависящийОтСтажа");
    }
}
