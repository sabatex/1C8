using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class РежимНачисленияЗарплаты:V1C8COMObject
    {
        public РежимНачисленияЗарплаты(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОкончательныйРасчет => GetProperty<EnumItemBase>("ОкончательныйРасчет");
        public EnumItemBase РасчетПервойПоловиныМесяца => GetProperty<EnumItemBase>("РасчетПервойПоловиныМесяца");
    }
}
