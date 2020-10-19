using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ОснованияДляДоначисленияСтраховыхВзносов:V1C8COMObject
    {
        public ОснованияДляДоначисленияСтраховыхВзносов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase КамеральнаяПроверка => GetProperty<EnumItemBase>("КамеральнаяПроверка");
        public EnumItemBase ВыезднаяПроверка => GetProperty<EnumItemBase>("ВыезднаяПроверка");
        public EnumItemBase ДляИсправленияОшибок => GetProperty<EnumItemBase>("ДляИсправленияОшибок");
        public EnumItemBase КорректировкаНеПризнаннаяОшибкой => GetProperty<EnumItemBase>("КорректировкаНеПризнаннаяОшибкой");
    }
}
