using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СобытияПродажиНалоговыйУчет:EnumBase
    {
        public СобытияПродажиНалоговыйУчет(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ОплатаПокупателем => GetProperty<EnumItem>("ОплатаПокупателем");
        public EnumItem ВозвратОплатыПокупателю => GetProperty<EnumItem>("ВозвратОплатыПокупателю");
        public EnumItem РеализацияПокупателю => GetProperty<EnumItem>("РеализацияПокупателю");
        public EnumItem ВозвратОтПокупателя => GetProperty<EnumItem>("ВозвратОтПокупателя");
    }
}
