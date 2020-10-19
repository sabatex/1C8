using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыЗаполненияЦен:V1C8COMObject
    {
        public СпособыЗаполненияЦен(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПоЦенамНоменклатуры => GetProperty<EnumItemBase>("ПоЦенамНоменклатуры");
        public EnumItemBase ПоЦенамНоменклатурыКонтрагентов => GetProperty<EnumItemBase>("ПоЦенамНоменклатурыКонтрагентов");
        public EnumItemBase ПоНоменклатуреИЦенамКонтрагентов => GetProperty<EnumItemBase>("ПоНоменклатуреИЦенамКонтрагентов");
        public EnumItemBase ПоРозничнымЦенам => GetProperty<EnumItemBase>("ПоРозничнымЦенам");
    }
}
