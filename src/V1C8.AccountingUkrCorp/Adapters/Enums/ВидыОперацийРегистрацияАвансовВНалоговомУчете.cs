using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыОперацийРегистрацияАвансовВНалоговомУчете:V1C8COMObject
    {
        public ВидыОперацийРегистрацияАвансовВНалоговомУчете(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase АвансОпределениеПараметровНУ => GetProperty<EnumItemBase>();
        public EnumItemBase АвансВозвратОпределениеПараметровНУ => GetProperty<EnumItemBase>();
        public EnumItemBase ОтгрузкаОтменаРегистрацииВНУ => GetProperty<EnumItemBase>();
        public EnumItemBase ОтгрузкаВозвратОтменаРегистрацииВНУ => GetProperty<EnumItemBase>();
    }
}
