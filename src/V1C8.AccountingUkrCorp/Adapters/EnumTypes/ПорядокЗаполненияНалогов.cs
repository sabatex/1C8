using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ПорядокЗаполненияНалогов:EnumBase
    {
        public ПорядокЗаполненияНалогов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem БезНалогов => GetProperty<EnumItem>("БезНалогов");
        public EnumItem НДФЛИВзносы => GetProperty<EnumItem>("НДФЛИВзносы");
        public EnumItem НДФЛ => GetProperty<EnumItem>("НДФЛ");
        public EnumItem Взносы => GetProperty<EnumItem>("Взносы");
    }
}
