using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ОснованияЛьготПоПособию:V1C8COMObject
    {
        public ОснованияЛьготПоПособию(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Чернобыль => GetProperty<EnumItemBase>();
        public EnumItemBase ВетераныВойны => GetProperty<EnumItemBase>();
        public EnumItemBase ЖертвыНацистскихПреследований => GetProperty<EnumItemBase>();
        public EnumItemBase РодительРебенкаЧернобыльца => GetProperty<EnumItemBase>();
        public EnumItemBase Донор => GetProperty<EnumItemBase>();
        public EnumItemBase УчастникРеволюцииДостоинства => GetProperty<EnumItemBase>();
    }
}
