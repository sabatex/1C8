using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СобытияПриобретенияНалоговыйУчет:V1C8COMObject
    {
        public СобытияПриобретенияНалоговыйУчет(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОплатаПоставщику => GetProperty<EnumItemBase>("ОплатаПоставщику");
        public EnumItemBase ВозвратОплатыПоставщиком => GetProperty<EnumItemBase>("ВозвратОплатыПоставщиком");
        public EnumItemBase ПоступлениеОтПоставщика => GetProperty<EnumItemBase>("ПоступлениеОтПоставщика");
        public EnumItemBase ВозвратПоставщику => GetProperty<EnumItemBase>("ВозвратПоставщику");
    }
}
