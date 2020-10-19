using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class РежимНачисленияЗарплаты:V1C8COMObject
    {
        public РежимНачисленияЗарплаты(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОкончательныйРасчет => GetProperty<EnumItemBase>();
        public EnumItemBase РасчетПервойПоловиныМесяца => GetProperty<EnumItemBase>();
    }
}
