using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыРабочегоВремениСотрудников:EnumBase
    {
        public ВидыРабочегоВремениСотрудников(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ОтработанноеВПределахНормы => GetProperty<EnumItem>("ОтработанноеВПределахНормы");
        public EnumItem ОтработанноеСверхНормы => GetProperty<EnumItem>("ОтработанноеСверхНормы");
        public EnumItem ЦелодневноеНеотработанное => GetProperty<EnumItem>("ЦелодневноеНеотработанное");
        public EnumItem ЧасовоеНеотработанное => GetProperty<EnumItem>("ЧасовоеНеотработанное");
        public EnumItem ДополнительноОплачиваемоеВПределахНормы => GetProperty<EnumItem>("ДополнительноОплачиваемоеВПределахНормы");
        public EnumItem ЧасовоеОтработанноеВПределахНормы => GetProperty<EnumItem>("ЧасовоеОтработанноеВПределахНормы");
    }
}
