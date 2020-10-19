using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СпособыПримененияЛьготРаботников:V1C8COMObject
    {
        public СпособыПримененияЛьготРаботников(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Основной => GetProperty<EnumItemBase>();
        public EnumItemBase НаКаждогоРебенка => GetProperty<EnumItemBase>();
        public EnumItemBase НаКаждогоРебенкаИнвалида => GetProperty<EnumItemBase>();
        public EnumItemBase НаТроихДетей => GetProperty<EnumItemBase>();
    }
}
