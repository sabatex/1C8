using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ОснованияДляДоначисленияСтраховыхВзносов:EnumBase
    {
        public ОснованияДляДоначисленияСтраховыхВзносов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem КамеральнаяПроверка => GetProperty<EnumItem>("КамеральнаяПроверка");
        public EnumItem ВыезднаяПроверка => GetProperty<EnumItem>("ВыезднаяПроверка");
        public EnumItem ДляИсправленияОшибок => GetProperty<EnumItem>("ДляИсправленияОшибок");
        public EnumItem КорректировкаНеПризнаннаяОшибкой => GetProperty<EnumItem>("КорректировкаНеПризнаннаяОшибкой");
    }
}
