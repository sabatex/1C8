using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ОснованияДляДоначисленияСтраховыхВзносов:V1C8COMObject
    {
        public ОснованияДляДоначисленияСтраховыхВзносов(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase КамеральнаяПроверка => GetProperty<EnumItemBase>();
        public EnumItemBase ВыезднаяПроверка => GetProperty<EnumItemBase>();
        public EnumItemBase ДляИсправленияОшибок => GetProperty<EnumItemBase>();
        public EnumItemBase КорректировкаНеПризнаннаяОшибкой => GetProperty<EnumItemBase>();
    }
}
