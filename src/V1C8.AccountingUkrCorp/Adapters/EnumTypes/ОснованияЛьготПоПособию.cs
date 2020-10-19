using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ОснованияЛьготПоПособию:EnumBase
    {
        public ОснованияЛьготПоПособию(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Чернобыль => GetProperty<EnumItem>("Чернобыль");
        public EnumItem ВетераныВойны => GetProperty<EnumItem>("ВетераныВойны");
        public EnumItem ЖертвыНацистскихПреследований => GetProperty<EnumItem>("ЖертвыНацистскихПреследований");
        public EnumItem РодительРебенкаЧернобыльца => GetProperty<EnumItem>("РодительРебенкаЧернобыльца");
        public EnumItem Донор => GetProperty<EnumItem>("Донор");
        public EnumItem УчастникРеволюцииДостоинства => GetProperty<EnumItem>("УчастникРеволюцииДостоинства");
    }
}
