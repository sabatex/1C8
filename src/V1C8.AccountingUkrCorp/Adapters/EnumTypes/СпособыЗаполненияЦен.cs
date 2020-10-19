using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыЗаполненияЦен:EnumBase
    {
        public СпособыЗаполненияЦен(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ПоЦенамНоменклатуры => GetProperty<EnumItem>("ПоЦенамНоменклатуры");
        public EnumItem ПоЦенамНоменклатурыКонтрагентов => GetProperty<EnumItem>("ПоЦенамНоменклатурыКонтрагентов");
        public EnumItem ПоНоменклатуреИЦенамКонтрагентов => GetProperty<EnumItem>("ПоНоменклатуреИЦенамКонтрагентов");
        public EnumItem ПоРозничнымЦенам => GetProperty<EnumItem>("ПоРозничнымЦенам");
    }
}
