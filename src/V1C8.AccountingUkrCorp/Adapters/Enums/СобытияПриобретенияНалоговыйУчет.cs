using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СобытияПриобретенияНалоговыйУчет:V1C8COMObject
    {
        public СобытияПриобретенияНалоговыйУчет(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОплатаПоставщику => GetProperty<EnumItemBase>();
        public EnumItemBase ВозвратОплатыПоставщиком => GetProperty<EnumItemBase>();
        public EnumItemBase ПоступлениеОтПоставщика => GetProperty<EnumItemBase>();
        public EnumItemBase ВозвратПоставщику => GetProperty<EnumItemBase>();
    }
}
