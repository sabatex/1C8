using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СобытияПродажиНалоговыйУчет:V1C8COMObject
    {
        public СобытияПродажиНалоговыйУчет(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОплатаПокупателем => GetProperty<EnumItemBase>("ОплатаПокупателем");
        public EnumItemBase ВозвратОплатыПокупателю => GetProperty<EnumItemBase>("ВозвратОплатыПокупателю");
        public EnumItemBase РеализацияПокупателю => GetProperty<EnumItemBase>("РеализацияПокупателю");
        public EnumItemBase ВозвратОтПокупателя => GetProperty<EnumItemBase>("ВозвратОтПокупателя");
    }
}
