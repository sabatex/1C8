using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class КатегорииРасчетов:V1C8COMObject
    {
        public КатегорииРасчетов(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Первичное => GetProperty<EnumItemBase>();
        public EnumItemBase ЗависимоеПервогоУровня => GetProperty<EnumItemBase>();
        public EnumItemBase ЗависимоеВторогоУровня => GetProperty<EnumItemBase>();
        public EnumItemBase ЗависимоеТретьегоУровня => GetProperty<EnumItemBase>();
    }
}
