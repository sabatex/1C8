using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОперацийРегистрацияАвансовВНалоговомУчете:V1C8COMObject
    {
        public ВидыОперацийРегистрацияАвансовВНалоговомУчете(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase АвансОпределениеПараметровНУ => GetProperty<EnumItemBase>("АвансОпределениеПараметровНУ");
        public EnumItemBase АвансВозвратОпределениеПараметровНУ => GetProperty<EnumItemBase>("АвансВозвратОпределениеПараметровНУ");
        public EnumItemBase ОтгрузкаОтменаРегистрацииВНУ => GetProperty<EnumItemBase>("ОтгрузкаОтменаРегистрацииВНУ");
        public EnumItemBase ОтгрузкаВозвратОтменаРегистрацииВНУ => GetProperty<EnumItemBase>("ОтгрузкаВозвратОтменаРегистрацииВНУ");
    }
}
