using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СобытияПродажиНалоговыйУчет:V1C8COMObject
    {
        public СобытияПродажиНалоговыйУчет(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОплатаПокупателем => GetProperty<EnumItemBase>();
        public EnumItemBase ВозвратОплатыПокупателю => GetProperty<EnumItemBase>();
        public EnumItemBase РеализацияПокупателю => GetProperty<EnumItemBase>();
        public EnumItemBase ВозвратОтПокупателя => GetProperty<EnumItemBase>();
    }
}
