using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыПримененияЛьготРаботников:V1C8COMObject
    {
        public СпособыПримененияЛьготРаботников(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Основной => GetProperty<EnumItemBase>("Основной");
        public EnumItemBase НаКаждогоРебенка => GetProperty<EnumItemBase>("НаКаждогоРебенка");
        public EnumItemBase НаКаждогоРебенкаИнвалида => GetProperty<EnumItemBase>("НаКаждогоРебенкаИнвалида");
        public EnumItemBase НаТроихДетей => GetProperty<EnumItemBase>("НаТроихДетей");
    }
}
