using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class КатегорииРасчетов:V1C8COMObject
    {
        public КатегорииРасчетов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Первичное => GetProperty<EnumItemBase>("Первичное");
        public EnumItemBase ЗависимоеПервогоУровня => GetProperty<EnumItemBase>("ЗависимоеПервогоУровня");
        public EnumItemBase ЗависимоеВторогоУровня => GetProperty<EnumItemBase>("ЗависимоеВторогоУровня");
        public EnumItemBase ЗависимоеТретьегоУровня => GetProperty<EnumItemBase>("ЗависимоеТретьегоУровня");
    }
}
