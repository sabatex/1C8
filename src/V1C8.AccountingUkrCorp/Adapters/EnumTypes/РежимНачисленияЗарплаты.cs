using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class РежимНачисленияЗарплаты:EnumBase
    {
        public РежимНачисленияЗарплаты(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ОкончательныйРасчет => GetProperty<EnumItem>("ОкончательныйРасчет");
        public EnumItem РасчетПервойПоловиныМесяца => GetProperty<EnumItem>("РасчетПервойПоловиныМесяца");
    }
}
