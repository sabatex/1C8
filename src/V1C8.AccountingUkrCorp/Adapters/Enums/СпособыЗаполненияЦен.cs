using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СпособыЗаполненияЦен:V1C8COMObject
    {
        public СпособыЗаполненияЦен(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПоЦенамНоменклатуры => GetProperty<EnumItemBase>();
        public EnumItemBase ПоЦенамНоменклатурыКонтрагентов => GetProperty<EnumItemBase>();
        public EnumItemBase ПоНоменклатуреИЦенамКонтрагентов => GetProperty<EnumItemBase>();
        public EnumItemBase ПоРозничнымЦенам => GetProperty<EnumItemBase>();
    }
}
