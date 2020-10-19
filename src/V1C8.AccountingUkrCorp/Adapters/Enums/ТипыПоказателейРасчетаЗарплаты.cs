using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ТипыПоказателейРасчетаЗарплаты:V1C8COMObject
    {
        public ТипыПоказателейРасчетаЗарплаты(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Денежный => GetProperty<EnumItemBase>();
        public EnumItemBase Числовой => GetProperty<EnumItemBase>();
        public EnumItemBase ЧисловойЗависящийОтДругогоПоказателя => GetProperty<EnumItemBase>();
        public EnumItemBase ЧисловойЗависящийОтСтажа => GetProperty<EnumItemBase>();
    }
}
