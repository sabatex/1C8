using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class КатегорииРасчетов:EnumBase
    {
        public КатегорииРасчетов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Первичное => GetProperty<EnumItem>("Первичное");
        public EnumItem ЗависимоеПервогоУровня => GetProperty<EnumItem>("ЗависимоеПервогоУровня");
        public EnumItem ЗависимоеВторогоУровня => GetProperty<EnumItem>("ЗависимоеВторогоУровня");
        public EnumItem ЗависимоеТретьегоУровня => GetProperty<EnumItem>("ЗависимоеТретьегоУровня");
    }
}
