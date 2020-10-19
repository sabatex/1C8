using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОперацийРегистрацияАвансовВНалоговомУчете:EnumBase
    {
        public ВидыОперацийРегистрацияАвансовВНалоговомУчете(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem АвансОпределениеПараметровНУ => GetProperty<EnumItem>("АвансОпределениеПараметровНУ");
        public EnumItem АвансВозвратОпределениеПараметровНУ => GetProperty<EnumItem>("АвансВозвратОпределениеПараметровНУ");
        public EnumItem ОтгрузкаОтменаРегистрацииВНУ => GetProperty<EnumItem>("ОтгрузкаОтменаРегистрацииВНУ");
        public EnumItem ОтгрузкаВозвратОтменаРегистрацииВНУ => GetProperty<EnumItem>("ОтгрузкаВозвратОтменаРегистрацииВНУ");
    }
}
