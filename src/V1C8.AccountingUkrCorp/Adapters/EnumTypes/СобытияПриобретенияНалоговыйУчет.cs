using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СобытияПриобретенияНалоговыйУчет:EnumBase
    {
        public СобытияПриобретенияНалоговыйУчет(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ОплатаПоставщику => GetProperty<EnumItem>("ОплатаПоставщику");
        public EnumItem ВозвратОплатыПоставщиком => GetProperty<EnumItem>("ВозвратОплатыПоставщиком");
        public EnumItem ПоступлениеОтПоставщика => GetProperty<EnumItem>("ПоступлениеОтПоставщика");
        public EnumItem ВозвратПоставщику => GetProperty<EnumItem>("ВозвратПоставщику");
    }
}
