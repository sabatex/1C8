using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ТипыПоказателейРасчетаЗарплаты:EnumBase
    {
        public ТипыПоказателейРасчетаЗарплаты(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Денежный => GetProperty<EnumItem>("Денежный");
        public EnumItem Числовой => GetProperty<EnumItem>("Числовой");
        public EnumItem ЧисловойЗависящийОтДругогоПоказателя => GetProperty<EnumItem>("ЧисловойЗависящийОтДругогоПоказателя");
        public EnumItem ЧисловойЗависящийОтСтажа => GetProperty<EnumItem>("ЧисловойЗависящийОтСтажа");
    }
}
