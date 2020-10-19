using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ОснованияЛьготПоПособию:V1C8COMObject
    {
        public ОснованияЛьготПоПособию(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Чернобыль => GetProperty<EnumItemBase>("Чернобыль");
        public EnumItemBase ВетераныВойны => GetProperty<EnumItemBase>("ВетераныВойны");
        public EnumItemBase ЖертвыНацистскихПреследований => GetProperty<EnumItemBase>("ЖертвыНацистскихПреследований");
        public EnumItemBase РодительРебенкаЧернобыльца => GetProperty<EnumItemBase>("РодительРебенкаЧернобыльца");
        public EnumItemBase Донор => GetProperty<EnumItemBase>("Донор");
        public EnumItemBase УчастникРеволюцииДостоинства => GetProperty<EnumItemBase>("УчастникРеволюцииДостоинства");
    }
}
